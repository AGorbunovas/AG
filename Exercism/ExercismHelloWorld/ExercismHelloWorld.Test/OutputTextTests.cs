using Xunit;

namespace ExercismHelloWorld.Test
{
    public class OutputTextTests
    {
        [Fact]
        public void OutputText()
        {
            var textToConsole = new TextToConsole();
            
            Assert.Equal("Hello, World!", textToConsole.Text("sentence"));
        }
    }
}
