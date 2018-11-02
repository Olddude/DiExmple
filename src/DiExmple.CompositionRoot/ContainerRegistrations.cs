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
			builder.RegisterType<MockTodoReader<string>>()
				   .As<IReader<Todo<string>>>();

			builder.RegisterType<TodoProvider<string>>()
				   .As<IProvider<Todo<string>>>();

			builder.RegisterType<MockTodoReader<double?>>()
				   .As<IReader<Todo<double?>>>();

			builder.RegisterType<TodoProvider<double?>>()
				   .As<IProvider<Todo<double?>>>();
		}
    }
}
