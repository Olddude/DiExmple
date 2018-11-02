using FluentAssertions;
using System.Threading.Tasks;
using Xunit;
using System.Linq;

namespace DiExmple.Persistance.Tests
{
	public class WhenReadingTodos
	{
		[Fact]
		public async Task ThenValuesAreReturned()
		{
			var sut = new MockTodoReader();

			var result = await sut.Read();

			result.Count().Should().Be(3);
		}
	}
}
