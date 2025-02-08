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
            private static List<int?> Value { get; set; } = new List<int?>();

            

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
                    #region if_start_and_end_in_array
                    if ((end > Value[0] && end < Value.Last<int?>()) && (start > Value[0] && start < Value.Last<int?>()))
                    {
                        if(Value.FindIndex(elem => elem == null) != Value.Count)
                        {
                            int s = Value.FindIndex(elem => elem == null);

                            for (int i = s; i < end; i += 2)
                            {
                                Value.Insert(s, Value[i]);
                                s++;
                            }
                        }
                        Value.Add(null);
                        return;
                    }
                    #endregion

                    #region if_end_in_array_or_start_in_array
                    if (end > Value[0] && end < Value.Last<int?>())
                    {
                        if (Value.FindIndex(elem => elem == null) != Value.Count)
                        {
                            int s = Value.FindIndex(elem => elem == null);
                            if (end >= s)
                            {
                                for (int i = s; i < end; i += 2)
                                {
                                    Value.Insert(s, Value[i]);
                                    s++;
                                }
                            }
                            
                        }
                        end = (int)Value[0] - 1;

                        for (int i = start; i <= end; i += 2)
                        {
                            Value.Add(i);
                        }
                        Value.Add(null);
                    }

                    if (start > Value[0] && start < Value.Last<int?>())
                    {

                        if (Value.FindIndex(elem => elem == null) != Value.Count)
                        {
                            int s = Value.FindIndex(elem => elem == null);
                            if (start <= s)
                            {
                                for (int i = s; i < Value[s+1]; i += 2)
                                {
                                    Value.Insert(s, Value[i]);
                                    s++;
                                }
                            }

                        }


                        start = (int)Value.Last<int?>() + 1;

                        for (int i = start; i <= end; i += 2)
                        {
                            Value.Add(i);
                        }
                        Value.Add(null);
                    }
                    #endregion

                    #region if_start_and_end_out_of_array
                    int psI = 0;

                    if (!(end > Value[0] && end < Value.Last<int?>()) && !(start > Value[0] && start < Value.Last<int?>()))
                    {
                        for (int i = start; i < Value[0]; i += 2)
                        {
                            Value.Insert(psI, Value[i]);
                            psI++;
                        }
                        for (int i = (int)Value.Last<int?>(); i < end; i += 2)
                        {
                            Value.Add(i);
                        }
                        Value.Add(null);
                    }
                    #endregion

                }
                else
                {
                    #region if_array_is_empty
                    for (int i = start; i <= end; i += 2)
                    {
                        Value.Add(i);

                    }
                    Value.Add(null);
                    #endregion
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
                if (Value.Count == 0)
                {
                    create(start, end);
                }

                else if (start < Value[0] || end > (int)Value.Last<int?>())
                {
                    create(start, end);
                }
                #endregion

                #region para
                if (Math.Abs(start) % 2 == 1)
                    start++;
                if (Math.Abs(end) % 2 == 1)
                    end--;
                #endregion
                //Get the value of the desired range 
                int?[] N = new int?[(end - start) / 2 + 1];
                Value.CopyTo(Value.FindIndex(elem => start == elem),N,0,(end - start)/2 + 1);

                #region to_normal_int
                int[] rezalt = new int[(end - start) / 2 + 1];

                for (int i = (int)N[0]; i <= N.Length; i++)
                {
                    rezalt[i] = (int)N[i];
                }
                #endregion

                return rezalt;
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
