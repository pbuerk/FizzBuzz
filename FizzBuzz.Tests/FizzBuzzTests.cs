using FizzBuzz.Library;
using Xunit;

namespace FizzBuzz.Tests
{
    public class FizzBuzzTests
    {
        //creating a service
        private FizzBuzzService fizzBuzz;

        //creating a constructor
        public FizzBuzzTests()
         {
             fizzBuzz = new FizzBuzzService();
         }

        [Fact]
        public void ShouldReturnNumber()
        {
           Assert.Equal("1", fizzBuzz.Print(1));
        }
        
        [Fact]
        public void ShouldReturnFizz()
        {
        Assert.Equal("Fizz", fizzBuzz.Print(3));

        }

        [Fact]
        public void ShouldReturnBuzz()
        {
        Assert.Equal("Buzz", fizzBuzz.Print(5));
        }

        [Fact]
        public void ShouldReturnFizzBuzz()
        {
        Assert.Equal("FizzBuzz", fizzBuzz.Print(15));
        }

    }
}