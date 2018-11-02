using DiExmple.Domain;
using DiExmple.Persistance.Interfaces;
using DiExmple.Services.Interfaces;
using System.Threading.Tasks;

namespace DiExmple.Services
{
	public class TodoProvider : IProvider<Todo[]>
    {
		private readonly IReader<Todo[]> reader;

		public TodoProvider(IReader<Todo[]> reader)
		{
			this.reader = reader;
		}

		public Task<Todo[]> GetValues()
		{
			return this.reader.Read();
		}
	}
}
