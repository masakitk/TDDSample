using System.Collections.Generic;
using System.Linq;

namespace TddFizzBuzz
{
    class FizzBuzzService
    {
        internal static FizzBuzzService GetInstance()
        {
            return new FizzBuzzService();
        }

        internal List<FizzBuzz> GetFizzBuzzList(int maxNumber)
        {
            return (from i in Enumerable.Range(1, maxNumber)
                    select new FizzBuzz(i)).ToList();
        }

        public class FizzBuzz
        {
            int _number;
            internal FizzBuzz(int number)
            {
                _number = number;
            }

            public string FizzBuzzValue
            {
                get
                {
                    return _number % 15 == 0 ? "FizzBuzz"
                        : _number % 5 == 0 ? "Buzz"
                        : _number % 3 == 0 ? "Fizz"
                        : _number.ToString();
                }
            }
        }
    }
}
