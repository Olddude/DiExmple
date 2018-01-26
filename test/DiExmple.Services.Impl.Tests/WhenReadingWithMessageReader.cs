using FluentAssertions;
using Xunit;

namespace DiExmple.Services.Impl.Tests
{
    public class WhenReadingWithMessageReader
    {
        [Fact]
        public void ThenReturnMessageIsCorrect()
        {
            new MessageReader()
                .Read()
                .ShouldBeEquivalentTo("Hello, DiExmple");
        }
    }
}
