using DiExmple.Domain;
using DiExmple.Persistance.Interfaces;
using FakeItEasy;
using FluentAssertions;
using System;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace DiExmple.Services.Tests
{
	public class WhenValueIsRequested
    {
        [Fact]
        public async Task ThenValueIsReturned()
        {
			var fakeValue = "clean up kitchen";

			var fakeResult = Task.FromResult
			(
				new Todo<string>[]
				{
					new Todo<string>
					{
						Value = fakeValue,
						IsDone = false,
						Created = DateTime.Now,
						Updated = DateTime.Now
					}
				}.AsEnumerable()
			);

			var fakeTodoReader = A.Fake<IReader<Todo<string>>>();
			A.CallTo(() => fakeTodoReader.Read()).Returns(fakeResult);

			var sut = new TodoProvider<string>(fakeTodoReader);

			var values = await sut.GetValues();

			values.FirstOrDefault().Value.Should().Be(fakeValue);
        }
    }
}
