using Para1.notevenNumbers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Para1
{

    namespace notevenNumbers
    {
        public class Number
        {
            private static List<int> Value { get; set; } = new List<int>();

            

            private static void create(int start, int end)
            {
                if (start > end)
                {
                    (start, end) = (end, start);
                }

                if (start % 2 == 1)
                    start++;
                if (end % 2 == 1)
                    end--;

                


                if (Value.Count != 0)
                {
                    if ((end > Value[0] && end < Value.Last<int>()) && (start > Value[0] && start < Value.Last<int>()))
                    {

                        return;
                    }

                    if (end > Value[0] && end < Value.Last<int>())
                    {
                        end = Value[0] - 1;
                    }

                    if (start > Value[0] && start < Value.Last<int>())
                    {
                        start = Value.Last<int>() + 1;
                    }



                }


                int psI = 0;

                if(!(end > Value[0] && end < Value.Last<int>()) && !(start > Value[0] && start < Value.Last<int>()))
                {
                    for (int i = start; i < Value[0]; i += 2)
                    {
                        Value.Insert(psI, Value[i]);
                        psI++;
                    }
                    for (int i = Value.Last<int>(); i < end; i += 2)
                    {
                        Value.Add(i);
                    }
                }

                for (int i = start; i <= end; i += 2)
                {
                    if (i < Value[0])
                    {
                        
                        Value.Insert(psI, Value[i]);
                        psI++;
                    }
                    
                }

                

            }

            public static int[] GetNumbers(int start, int end)
            {
                if (start > end)
                {
                    (start, end) = (end, start);
                }




                if (Value.Count == 0)
                {
                    create(start, end);
                }
                else if (start < Value[0] || end > Value.Last<int>())
                {
                    create(start, end);
                }

                if (Math.Abs(start) % 2 == 1)
                    start++;
                if (Math.Abs(end) % 2 == 1)
                    end--;



                int[] N = new int[(end - start) / 2 + 1];
                Value.CopyTo(Value.FindIndex(elem => start == elem),N,0,(end - start)/2 + 1);

                return N;
            }

        }
    }

    internal class Program
    {


        static void Main(string[] args)
        {

            int[] arr = notevenNumbers.Number.GetNumbers(5,100);

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]}, ");

            }
            Console.WriteLine("\n");

            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());


            arr = notevenNumbers.Number.GetNumbers(start, end);

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]}, ");

            }
            Console.WriteLine("\n");

            Console.ReadLine();
        }
    }
}
