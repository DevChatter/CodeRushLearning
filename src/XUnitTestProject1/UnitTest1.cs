using CodeRushLearning;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace XUnitTestProject1
{
    public class GetListShould
    {
        [Fact]
        void Return1_Given1()
        {
            List<string> fizzBuzzResults = FizzBuzzMaker.GetList(1, string.Empty);

            Assert.NotNull(fizzBuzzResults);
            Assert.Single(fizzBuzzResults);
            Assert.Equal("1", fizzBuzzResults.Single());
        }
        [Fact]
        void Return1and2_Given2()
        {
            List<string> fizzBuzzResults = FizzBuzzMaker.GetList(2, string.Empty);

            Assert.NotNull(fizzBuzzResults);
            Assert.Equal(2, fizzBuzzResults.Count);
            Assert.Equal("1", fizzBuzzResults.First());
            Assert.Equal("2", fizzBuzzResults.Last());
        }
        [Fact]
        void ReturnFizz_Given3()
        {
            List<string> fizzBuzzResults = FizzBuzzMaker.GetList(3, string.Empty);

            Assert.NotNull(fizzBuzzResults);
            Assert.Equal(3, fizzBuzzResults.Count);
            Assert.Equal("1", fizzBuzzResults.ElementAt(0));
            Assert.Equal("2", fizzBuzzResults.ElementAt(1));
            Assert.Equal("Fizz", fizzBuzzResults.ElementAt(2));
        }
        [Fact]
        void ReturnFizz_Given5()
        {
            List<string> fizzBuzzResults = FizzBuzzMaker.GetList(5, string.Empty);

            Assert.NotNull(fizzBuzzResults);
            Assert.Equal(5, fizzBuzzResults.Count);
            Assert.Equal("1", fizzBuzzResults.ElementAt(0));
            Assert.Equal("2", fizzBuzzResults.ElementAt(1));
            Assert.Equal("Fizz", fizzBuzzResults.ElementAt(2));
            Assert.Equal("4", fizzBuzzResults.ElementAt(3));
            Assert.Equal("Buzz", fizzBuzzResults.ElementAt(4));
        }
        [Fact]
        void ReturnFizzBuzz_Given15()
        {
            var msg = "hello world";
            List<string> fizzBuzzResults = FizzBuzzMaker.GetList(15, msg);

            Assert.NotNull(fizzBuzzResults);
            Assert.Equal(15, fizzBuzzResults.Count);
            Assert.Equal("FizzBuzz", fizzBuzzResults.ElementAt(14));
        }
    }
}
