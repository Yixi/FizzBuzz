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

        [Fact]
        public void Should_return_4_when_given_number_is_2()
        {
            int number = 2;
            string result = FizzBuzzGame.CountOff(number);
            Assert.Equal("4", result);
        }
    }
}