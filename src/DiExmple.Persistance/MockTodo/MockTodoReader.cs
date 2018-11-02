using DiExmple.Domain;
using DiExmple.Persistance.Interfaces;
using System.IO;
using System.Threading.Tasks;
using nj = Newtonsoft.Json;

namespace DiExmple.Persistance
{
	public class MockTodoReader : IReader<Todo[]>
	{
		public Task<Todo[]> Read()
		{
			var result = nj.JsonConvert.DeserializeObject<Todo[]>(File.ReadAllText(@".\assets\todos.json"));
			return Task.FromResult(result);
		}
	}
}
