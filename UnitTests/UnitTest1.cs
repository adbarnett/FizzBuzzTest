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

        [DataTestMethod]
        [DynamicData(nameof(DivisibleBy3TestData))]
        public void GetFizzBuzzResponse_ReturnFizzWhenDivisibleBy3(int value)
        {
            var result = _fizzBuzzService.GetFizzBuzzResponse(value);
            Assert.IsTrue(result.GetType() == typeof(string) && result.ToString().ToLowerInvariant() == "fizz");
        }
        public static IEnumerable<object[]> DivisibleBy3TestData
        {
            get
            {
                return Enumerable
                    .Range(0, 101)
                    .Where(i => i != 0 && i % 3 == 0 && i % 5 != 0)
                    .Select(i => new object[] { i })
                    .ToArray();
            }
        }

        [DataTestMethod]
        [DynamicData(nameof(DivisibleBy5TestData))]
        public void GetFizzBuzzResponse_ReturnBuzzWhenDivisibleBy5(int value)
        {
            var result = _fizzBuzzService.GetFizzBuzzResponse(value);
            Assert.IsTrue(result.GetType() == typeof(string) && result.ToString().ToLowerInvariant() == "buzz");
        }

        public static IEnumerable<object[]> DivisibleBy5TestData
        {
            get
            {
                return Enumerable
                    .Range(0, 101)
                    .Where(i => i != 0 && i % 3 != 0 && i % 5 == 0)
                    .Select(i => new object[] { i })
                    .ToArray();
            }
        }

        [DataTestMethod]
        [DynamicData(nameof(DivisibleBy3And5TestData))]
        public void GetFizzBuzzResponse_ReturnFizzBuzzWhenDivisibleBy3And5(int value)
        {
            var result = _fizzBuzzService.GetFizzBuzzResponse(value);
            Assert.IsTrue(result.GetType() == typeof(string) && result.ToString().ToLowerInvariant() == "fizzbuzz");
        }
        public static IEnumerable<object[]> DivisibleBy3And5TestData
        {
            get
            {
                return Enumerable
                    .Range(0, 101)
                    .Where(i => i != 0 && i % 3 == 0 && i % 5 == 0)
                    .Select(i => new object[] { i })
                    .ToArray();
            }
        }

        [DataTestMethod]
        [DynamicData(nameof(NotDivisibleBy3Or5TestData))]
        public void GetFizzBuzzResponse_ReturnIntWhenNotDivisibleBy3And5(int value)
        {
            var result = _fizzBuzzService.GetFizzBuzzResponse(value);
            Assert.IsTrue(result.GetType() == typeof(int) && (int)result == value);
        }

        public static IEnumerable<object[]> NotDivisibleBy3Or5TestData
        {
            get
            {
                return Enumerable
                    .Range(0, 101)
                    .Where(i => i == 0 || (i % 3 != 0 && i % 5 != 0))
                    .Select(i => new object[] { i })
                    .ToArray();
            }
        }
    }
}