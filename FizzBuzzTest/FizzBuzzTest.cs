using FizzBuzz;
using Moq;
using Xunit;

namespace FizzBuzzTest
{
    public class Class1Test
    {
        [Fact]
        public void Test1()
        {
            FizzBuzzGame fizzBuzzGame = new FizzBuzzGame();

            //then
            Assert.NotNull(fizzBuzzGame);
        }
    }
}