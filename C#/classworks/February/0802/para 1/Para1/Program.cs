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

            private static void regen(int start, int end)
            {
                int s = Value.FindIndex(elem => elem == start);
                if(s == -1)
                {
                    s = 0;
                }
                for (int i = start; i <= end; i += 2)
                {
                    if (Value.Contains(i))
                    {
                        s++;
                        continue;
                    }
                    Value.Insert(s,i);
                    s++;
                }
            }

            private static void create(int start, int end)
            {
                #region swap_and_para
                if (start > end)
                {
                    (start, end) = (end, start);
                }

                if (start % 2 == 1)
                    start++;
                if (end % 2 == 1)
                    end--;
                #endregion


                if (Value.Count != 0)
                {
                    if(start > Value[0] && start < Value.Last<int>())
                    {
                        if(end > Value[0] && end < Value.Last<int>())
                        {
                            int c = end - start;
                            int one = Value.FindIndex(elem => elem == start);
                            int two = Value.FindIndex(elem => elem == end);

                            if(c != two - one)
                            {
                                regen(start, end);
                            }

                            return;

                        }
                        else
                        {
                            regen(start, end);
                            return;
                        }


                    }
                    else
                    {
                        regen(start, end);
                    }
                }
                else
                {
                    #region if_array_is_empty
                    for (int i = start; i <= end; i += 2)
                    {
                        Value.Add(i);

                    }
                    #endregion
                    return;
                }

            }

            public static int[] GetNumbers(int start, int end)
            {
                #region swap
                if (start > end)
                {
                    (start, end) = (end, start);
                }
                #endregion


                #region create_array
                //if (Value.Count == 0)
                //{
                //    create(start, end);
                //}
                //else if (start < Value[0] || end > (int)Value.Last<int?>())
                //{

                //}
                create(start, end);
                #endregion

                #region para
                if (Math.Abs(start) % 2 == 1)
                    start++;
                if (Math.Abs(end) % 2 == 1)
                    end--;
                #endregion
                //Get the value of the desired range 
                int[] N = new int[(end - start) / 2 + 1];
                Value.CopyTo(Value.FindIndex(elem => start == elem),N,0,(end - start)/2 + 1);


                return N;
            }

        }
    }

    namespace evenNumbers
    {
        public class Number
        {
            private static List<int> Value { get; set; } = new List<int>();

            private static void regen(int start, int end)
            {
                int s = Value.FindIndex(elem => elem == start);
                if (s == -1)
                {
                    s = 0;
                }
                for (int i = start; i <= end; i += 2)
                {
                    if (Value.Contains(i))
                    {
                        s++;
                        continue;
                    }
                    Value.Insert(s, i);
                    s++;
                }
            }

            private static void create(int start, int end)
            {
                #region swap_and_para
                if (start > end)
                {
                    (start, end) = (end, start);
                }

                if (start % 2 == 0)
                    start++;
                if (end % 2 == 0)
                    end--;
                #endregion


                if (Value.Count != 0)
                {
                    if (start > Value[0] && start < Value.Last<int>())
                    {
                        if (end > Value[0] && end < Value.Last<int>())
                        {
                            int c = end - start;
                            int one = Value.FindIndex(elem => elem == start);
                            int two = Value.FindIndex(elem => elem == end);

                            if (c != two - one)
                            {
                                regen(start, end);
                            }

                            return;

                        }
                        else
                        {
                            regen(start, end);
                            return;
                        }


                    }
                    else
                    {
                        regen(start, end);
                    }
                }
                else
                {
                    #region if_array_is_empty
                    for (int i = start; i <= end; i += 2)
                    {
                        Value.Add(i);

                    }
                    #endregion
                    return;
                }

            }

            public static int[] GetNumbers(int start, int end)
            {
                #region swap
                if (start > end)
                {
                    (start, end) = (end, start);
                }
                #endregion


                #region create_array
                
                create(start, end);
                #endregion

                #region para
                if (Math.Abs(start) % 2 == 0)
                    start++;
                if (Math.Abs(end) % 2 == 0)
                    end--;
                #endregion
                //Get the value of the desired range 
                int[] N = new int[(end - start) / 2 + 1];
                Value.CopyTo(Value.FindIndex(elem => start == elem), N, 0, (end - start) / 2 + 1);


                return N;
            }

        }
    }


    internal class Program
    {


        static void Main(string[] args)
        {
            
            #region even
            int[] arr1 = notevenNumbers.Number.GetNumbers(25, 40);

            for (int i1 = 0; i1 < arr1.Length; i1++)
            {
                Console.Write($"{arr1[i1]}, ");

            }
            Console.WriteLine("\n");

            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());


            arr1 = notevenNumbers.Number.GetNumbers(start, end);

            for (int i1 = 0; i1 < arr1.Length; i1++)
            {
                Console.Write($"{arr1[i1]}, ");

            }
            Console.WriteLine("\n");


            int i = 6;
            while (i <= 5)
            {
                start = int.Parse(Console.ReadLine());
                end = int.Parse(Console.ReadLine());


                arr1 = notevenNumbers.Number.GetNumbers(start, end);

                for (int i1 = 0; i1 < arr1.Length; i1++)
                {
                    Console.Write($"{arr1[i1]}, ");

                }
                Console.WriteLine("\n");
                i++;
            }
            #endregion
            ///////////////////////////////////////////////
            #region notEven
            int[] arr2 = evenNumbers.Number.GetNumbers(25, 40);

            for (int i2 = 0; i2 < arr2.Length; i2++)
            {
                Console.Write($"{arr2[i2]}, ");

            }
            Console.WriteLine("\n");

            int start2 = int.Parse(Console.ReadLine());
            int end2 = int.Parse(Console.ReadLine());


            arr2 = evenNumbers.Number.GetNumbers(start2, end2);

            for (int i2 = 0; i2 < arr2.Length; i2++)
            {
                Console.Write($"{arr2[i2]}, ");

            }
            Console.WriteLine("\n");



            while (true)
            {
                start2 = int.Parse(Console.ReadLine());
                end2 = int.Parse(Console.ReadLine());


                arr2 = evenNumbers.Number.GetNumbers(start2, end2);

                for (int i2 = 0; i2 < arr2.Length; i2++)
                {
                    Console.Write($"{arr2[i2]}, ");

                }
                Console.WriteLine("\n");

            }
            #endregion

        }
    }
}
