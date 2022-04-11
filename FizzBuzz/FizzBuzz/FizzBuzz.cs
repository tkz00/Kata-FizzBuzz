using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class FizzBuzzList
    {
        public List<string> GetList()
        {
            List<string> list = new List<string>();

            for (int i = 1; i < 21; i++)
            {
                if (IsFizz(i))
                {
                    list.Add("Fizz");

                    if(IsBuzz(i))
                    {
                        list[i - 1] += "Buzz";
                    }
                }
                else if(IsBuzz(i))
                {
                    list.Add("Buzz");
                }
                else
                {
                    list.Add(i.ToString());
                }
            }

            return list;
        }

        private bool IsFizz(int number)
        {
            return number % 3 == 0;
        }

        private bool IsBuzz(int number)
        {
            return number % 5 == 0;
        }
    }
}
