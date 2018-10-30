using DiExmple.Domain;
using DiExmple.Persistance.Interfaces;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using nj = Newtonsoft.Json;

namespace DiExmple.Persistance
{
	public class MockTodoReader<T> : IReader<Todo<T>>
	{
		public Task<IEnumerable<Todo<T>>> Read()
		{
			var result = nj.JsonConvert.DeserializeObject<IEnumerable<Todo<T>>>(File.ReadAllText(@".\assets\test_todos.json"));
			return Task.FromResult(result);
		}
	}
}
