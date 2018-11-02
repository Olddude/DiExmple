using Autofac;
using Autofac.Extensions.DependencyInjection;
using DiExmple.CompositionRoot;
using DiExmple.Domain;
using DiExmple.Persistance;
using DiExmple.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Serilog;
using System;
using System.IO;

namespace DiExmple.Runner
{
	class Program
    {
		static IServiceProvider ConfigureServices(IServiceCollection services, IConfiguration configuration)
		{
			services.AddLogging(_ =>
			{
				_.AddSerilog
				(
					new LoggerConfiguration()
						.Enrich.FromLogContext()
						.ReadFrom.Configuration(configuration)
						.CreateLogger()
				);
			});

			var todosConnectionString = configuration.GetConnectionString("TodosConnectionString");

			services.AddDbContext<MsSqlTodoDataContext>(options =>
			{
				options.UseSqlServer(todosConnectionString);
			});

			services.AddTransient(typeof(ILogger<>), typeof(Logger<>));

			var builder = new ContainerBuilder();

			builder.Populate(services);

			ContainerRegistrations.Register(builder);

			return new AutofacServiceProvider(builder.Build());
		}

		static void Main(string[] args)
        {
			var configuration = new ConfigurationBuilder()
				.SetBasePath(Directory.GetCurrentDirectory())
				.AddJsonFile(path: "appsettings.json", optional: false, reloadOnChange: true)
				.Build();

			var serviceCollection = new ServiceCollection();

			var serviceProvider = ConfigureServices(serviceCollection, configuration);

			var rootLogger = serviceProvider.GetService<ILogger<Program>>();

			var service = serviceProvider.GetService<IProvider<Todo[]>>();

			var values = service.GetValues().Result;

			rootLogger.LogInformation("{0}", JsonConvert.SerializeObject(values));
        }
	}
}
