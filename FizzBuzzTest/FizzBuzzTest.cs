using FizzBuzz;
using Moq;
using Xunit;

namespace FizzBuzzTest
{
    public class Class1Test
    {
        [Fact]
        public void Should_init_fizzBuzzGame_class_correctly()
        {
            FizzBuzzGame fizzBuzzGame = new FizzBuzzGame();

            //then
            Assert.NotNull(fizzBuzzGame);
        }

    }
}