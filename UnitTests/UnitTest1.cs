using FizzBuzz;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        IFizzBuzzService _fizzBuzzService;

        public UnitTest1()
        {
            _fizzBuzzService = new FizzBuzzService();
        }

        [TestMethod]
        [DataRow(3)]
        [DataRow(6)]
        [DataRow(9)]
        [DataRow(12)]
        [DataRow(15)]
        [DataRow(18)]
        [DataRow(21)]
        [DataRow(24)]
        [DataRow(27)]
        public void GetFizzBuzzResponse_ReturnFizzWhenDivisibleBy3(int value)
        {
            var result = _fizzBuzzService.GetFizzBuzzResponse(value);
            Assert.IsTrue(result.GetType() == typeof(string) && result.ToString().ToLowerInvariant() == "fizz");
        }

        [TestMethod]
        [DataRow(5)]
        [DataRow(10)]
        [DataRow(15)]
        [DataRow(20)]
        [DataRow(25)]
        [DataRow(30)]
        [DataRow(35)]
        [DataRow(40)]
        [DataRow(45)]
        public void GetFizzBuzzResponse_ReturnFizzWhenDivisibleBy5(int value)
        {
            var result = _fizzBuzzService.GetFizzBuzzResponse(value);
            Assert.IsTrue(result.GetType() == typeof(string) && result.ToString().ToLowerInvariant() == "buzz");
        }

        [TestMethod]
        [DataRow(15)]
        [DataRow(30)]
        [DataRow(45)]
        public void GetFizzBuzzResponse_ReturnFizzBuzzWhenDivisibleBy3And5(int value)
        {
            var result = _fizzBuzzService.GetFizzBuzzResponse(value);
            Assert.IsTrue(result.GetType() == typeof(string) && result.ToString().ToLowerInvariant() == "fizzbuzz");
        }

        [TestMethod]
        [DataRow(1)]
        [DataRow(2)]
        [DataRow(4)]
        [DataRow(7)]
        public void GetFizzBuzzResponse_ReturnIntWhenNotDivisibleBy3And5(int value)
        {
            var result = _fizzBuzzService.GetFizzBuzzResponse(value);
            Assert.IsTrue(result.GetType() == typeof(int) && (int)result == value);
        }
    }
}