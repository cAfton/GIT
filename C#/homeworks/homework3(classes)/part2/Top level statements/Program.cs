using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Top_level_statements
{

    public class website
    {
        public string name;

        public string url { get; set; }

        public string description { get; set; }

        public string ip { get; set; }

        public website()
        {
            Console.WriteLine("Enter name:");
            this.name = Console.ReadLine();

            Console.WriteLine("Enter url:");
            this.url = Console.ReadLine();

            Console.WriteLine("Enter description:");
            this.description = Console.ReadLine();

            Console.WriteLine("Enter ip:");
            this.ip = Console.ReadLine();
        }

        public void print()
        {
            Console.WriteLine($"{this.name}, url: {this.url}\n{this.description}\nIP:{this.ip}");
        }

    }
        internal class Program
    {

        static void sortTask3(List<int> original_array, List<int> array_with_data_for_filtering)
        {
            for (int i = 0; i < original_array.Count; i++)
            {
                for (int j = 0; j < array_with_data_for_filtering.Count; j++)
                {
                    if (original_array[i] == array_with_data_for_filtering[j])
                    {
                        original_array.Remove(array_with_data_for_filtering[j]);
                        i--;
                    }
                }
            }
        }

        static void Square(int n, char a)
        {
            #region square1

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(a);
                    Console.Write(' ');
                }
                Console.WriteLine();
            }
            #endregion
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            #region square2
            for (int i = 0; i < n; i++)
            {
                Console.Write(a);
                Console.Write(' ');
            }
            Console.WriteLine();

            for (int i = 0; i < (n-2); i++)
            {
                Console.Write(a);

                for (int j = 0; j < 2*n-3; j++)
                {
                    Console.Write(' ');
                }

                Console.Write(a);

                Console.WriteLine();
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(a);
                Console.Write(' ');
            }
            #endregion
        }

        static void Main(string[] args)
        {
            
            #region Task 4
            website first = new website();
            website second = new website();
            website third = new website();

            first.print();
            second.print();
            third.print();

            Console.ReadLine();
            #endregion
        
            
            #region Task 3
            List<int> original = new List<int> { 1, 2, 6, -1, 88, 7, 6 };
            List<int> array = new List<int> { 6, 88, 7 };

            sortTask3(original, array);
            for (int i = 0; i < original.Count; i++)
            {
                Console.WriteLine(original[i]);
            }
            Console.ReadLine();
            #endregion
            

            #region Task1
            Console.WriteLine("Enter length:");
            int l = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter symbol:");
            char a = char.Parse(Console.ReadLine());
            Square(l, a);
            Console.ReadLine();
            #endregion
        }
    }
}
