using DiExmple.Domain;
using DiExmple.Persistance.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace DiExmple.Persistance
{
	public class MsSqlTodoReader : IReader<Todo[]>
	{
		private readonly MsSqlTodoDataContext dataContext;

		public MsSqlTodoReader(MsSqlTodoDataContext dataContext)
		{
			this.dataContext = dataContext;
		}

		public Task<Todo[]> Read()
		{
			return this.dataContext.Todos.ToArrayAsync();
		}
	}
}
