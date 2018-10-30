using DiExmple.Domain;
using DiExmple.Persistance.Interfaces;
using DiExmple.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DiExmple.Services
{
	public class TodoProvider<T> : IProvider<Todo<T>>
    {
		private readonly IReader<Todo<T>> reader;

		public TodoProvider(IReader<Todo<T>> reader)
		{
			this.reader = reader;
		}

		public Task<IEnumerable<Todo<T>>> GetValues()
		{
			return this.reader.Read();
		}
	}
}
