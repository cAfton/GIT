using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V
{
    namespace evenNumbers
    {
        public class Number
        {
            public static List<int> Value { get; set; }

            public Number() {
                Value = new List<int>();
            }

            private static void create(int start, int end) {
                if (start > end)
                {
                    (start, end) = (end,  start);
                }

                if (start % 2 == 1)
                    start++;
                if (end % 2 == 1)
                    end--;

                for (int i = start; i <= end; i += 2)
                {
                    if (!Value.Contains(i))
                    {
                        try
                        {
                            if (i < Value.First())
                            {
                                Value.Insert(0, i);
                                continue;
                            }
                            Value.Add(i);
                        }
                        catch(Exception)
                        {
                            Value.Add(i);
                        }

                    }
                }
            }


        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            evenNumbers.Number number = new evenNumbers.Number();

            number.create(1, 20);
            number.create(-10, 20);

            for (int i = 0; i < number.Value.Count; i++)
            {
                Console.WriteLine(number.Value[i]);
            }

            Console.ReadLine();
        }
    }
}
