using System.Text;

namespace FizzBuzz
{
    public class FizzBuzzService : IFizzBuzzService
    {
        public object GetFizzBuzzResponse(int integer)
        {
            if (integer != 0 && (integer % 3 == 0 || integer % 5 == 0))
            {
                StringBuilder sb = new StringBuilder();
                if (integer % 3 == 0)
                    sb.Append("Fizz");

                if (integer % 5 == 0)
                    sb.Append("Buzz");

                return sb.ToString();
            }
            else
                return integer;
        }
    }
}
