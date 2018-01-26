using Autofac;
using DiExmple.CompositionRoot;
using DiExmple.Services;

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
                var reader = scope.Resolve<IMessageReader>();
                reader.Read();
            }
        }
    }
}
