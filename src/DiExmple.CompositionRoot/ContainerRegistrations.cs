using Autofac;
using DiExmple.Domain;
using DiExmple.Persistance;
using DiExmple.Persistance.Interfaces;
using DiExmple.Services;
using DiExmple.Services.Interfaces;

namespace DiExmple.CompositionRoot
{
	public static class ContainerRegistrations
    {
        public static void Register(this ContainerBuilder builder)
        {
			builder.RegisterType<MsSqlTodoReader>()
				   .As<IReader<Todo[]>>();

			builder.RegisterType<TodoProvider>()
				   .As<IProvider<Todo[]>>();
		}
    }
}
