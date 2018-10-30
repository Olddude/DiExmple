using Autofac;
using DiExmple.CompositionRoot;
using DiExmple.Domain;
using DiExmple.Services.Interfaces;

namespace DiExmple.Runner
{
	class Program
    {
        static void Main(string[] args)
        {
            var builder = new ContainerBuilder();
            ContainerRegistrations.Register(builder);
            var container = builder.Build();

            using (var scope = container.BeginLifetimeScope())
            {
				var todosReader = scope.Resolve<IProvider<Todo<string>>>();
				var values = todosReader.GetValues().Result;
			}
        }
    }
}
