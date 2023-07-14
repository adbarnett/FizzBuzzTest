namespace FizzBuzz;

public class Program
{
    static IFizzBuzzService _fizzBuzzService = new FizzBuzzService();

    static void Main(string[] args)
    {
        var numbersList = Enumerable.Range(0, 101).OrderBy(i => i).ToList();

        foreach (var number in numbersList)
        {
            Console.WriteLine(_fizzBuzzService.GetFizzBuzzResponse(number).ToString());
        }
    }
}