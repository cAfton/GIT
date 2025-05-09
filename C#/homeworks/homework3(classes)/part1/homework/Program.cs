using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{

    public class Methods
    {
        public Methods() { }

        public void printSquare(int size, char symbol)
        {
            if (size < 0) size *= -1;

            for (int i = 0; i < size; i++)
            {
                for(int j = 0; j < size; j++)
                {
                    Console.Write($" {symbol} ");
                }
                Console.WriteLine();
            }
        }

        public bool isPalindrom(int number) {
            string line = number.ToString();
            for (int i = 0; i < line.Length / 2; i++)
            {
                if (line[i] != line[line.Length - i - 1])
                {
                    return false;
                }
            }

            return true;
        }

    }

    public class Container
    {
        public double MaxVolume { get; set; }

        public double Volume {  get; set; }

        public string Material { get; set; }

        public bool IsEmpty {  get; set; }
        public Container() {
            MaxVolume = 10;
            Volume = 0;
            Material = "plastic";
            IsEmpty = true;
        }

        public Container(double maxVolume)
        {
            if (maxVolume > 0)
            {
                MaxVolume = maxVolume;
            }
            else
            {
                MaxVolume = maxVolume * -1;
            }
            Volume = 0;
            Material = "plastic";
            IsEmpty = true;
        }

        public Container(double maxVolume, double volume) {
            MaxVolume = Math.Max(maxVolume, volume);
            Volume = Math.Min(maxVolume, volume);
            Material = "plastic";
            IsEmpty = true;
        }

        public Container(double maxVolume, string material)
        {
            MaxVolume = maxVolume;
            Volume = 0;
            Material = material;
            IsEmpty = true;
        }

        public Container(double maxVolume, bool isEmpty)
        {
            MaxVolume = maxVolume;
            Volume = 0;
            Material = "plastic";
            IsEmpty = isEmpty;
        }

        public Container(double maxVolume, double volume, string material)
        {
            MaxVolume = Math.Max(maxVolume, volume);
            Volume = Math.Min(maxVolume, volume);
            Material = material;
            IsEmpty = true;
        }

        public Container(double maxVolume, double volume, bool isEmpty)
        {
            MaxVolume = Math.Max(maxVolume, volume);
            Volume = Math.Min(maxVolume, volume);
            Material = "plastic";
            if (isEmpty)
            {
                Volume = 0;
            }
            
            IsEmpty = isEmpty;
        }

        public Container(double maxVolume, double volume, string material, bool isEmpty)
        {
            MaxVolume = Math.Max(maxVolume, volume);
            Volume = Math.Min(maxVolume, volume);
            Material = material;
            if (isEmpty)
            {
                Volume = 0;
            }
            this.IsEmpty = isEmpty;
        }

        public override string ToString()
        { 
            return ($"Max Volume: {MaxVolume}\nVolume: {Volume}\nMaterial: {Material}\nIs Empty: {IsEmpty}");
        }

        public void read(string line)
        {
            string[] strings = line.Split(' ');
            MaxVolume = Math.Max(int.Parse(strings[0]), int.Parse(strings[1]));
            Volume = Math.Min(int.Parse(strings[0]), int.Parse(strings[1]));
            Material = strings[2];
            try
            {
                IsEmpty = bool.Parse(strings[3]);
                if (IsEmpty) Volume = 0;
                else if(Volume == 0) IsEmpty = true;
            }
            catch(FormatException exc)
            {
                if (Volume == 0) IsEmpty = false;
                else IsEmpty = true;
                Console.WriteLine(exc.Message);
                Console.WriteLine($"IsEmpty = {IsEmpty}");
            }
        }

        public void Full(int full)
        {
            if (full < 0)
            {
                Release(full * -1);
            }
            else if (Volume + full > MaxVolume)
            {
                Volume = MaxVolume;
                if (IsEmpty)
                {
                    IsEmpty = false;
                }
            }
            else
            {
                Volume += full;
            }
        }

        public void Release(int release)
        {
            if (release < 0)
            {
                release *= -1;
            }

            if (Volume - release < 0)
            {
                Volume = 0;
                IsEmpty = true;
            }
            else
            {
                Volume -= release;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Methods methods = new Methods();
            bool isWrong = true;

            #region tast1
            int size = 1;

            do
            {
                try
                {
                    Console.Write("Input size: ");
                    size = int.Parse(Console.ReadLine());

                    isWrong = false;
                }
                catch (FormatException exc)
                {
                    Console.WriteLine(exc.Message);
                }
            } while (isWrong);


            char symbol = '1';
            isWrong = true;
            do
            {
                try
                {
                    Console.Write("Input char: ");
                    symbol = char.Parse(Console.ReadLine());
                    isWrong = false;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            } while (isWrong);

            methods.printSquare(size, symbol);

            #endregion


            #region task2
            int palindrom = 0;
            isWrong = true;
            do
            {
                try
                {
                    Console.Write("Input number: ");
                    palindrom = int.Parse(Console.ReadLine());

                    isWrong = false;
                }
                catch (FormatException exc)
                {
                    Console.WriteLine(exc.Message);
                }
            } while (isWrong);

            if (methods.isPalindrom(palindrom))
            {
                Console.WriteLine("Palindrom");
            }
            else
            {
                Console.WriteLine("Not palindrom");
            }
            #endregion


            #region task7
            Container container1 = new Container();
            Container container2 = new Container(25);
            Container container3 = new Container(25, 5);
            Container container4 = new Container(25, "glass");
            Container container5 = new Container(25, true);
            Container container6 = new Container(25, 5, "glass");
            Container container7 = new Container(25, 5, true);
            Container container8 = new Container(25, 5, "glass", true);

            Console.WriteLine(container1.ToString());
            Console.WriteLine(container2.ToString());
            Console.WriteLine(container3.ToString());
            Console.WriteLine(container4.ToString());
            Console.WriteLine(container5.ToString());
            Console.WriteLine(container6.ToString());
            Console.WriteLine(container7.ToString());
            Console.WriteLine(container8.ToString());

            Container container9 = new Container();
            string line = Console.ReadLine();
            container9.read(line);
            Console.WriteLine(container9.ToString());


            #endregion


            Console.ReadLine();
        }
    }
}
