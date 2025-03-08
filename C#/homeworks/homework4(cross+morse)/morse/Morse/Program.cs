using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Morse
{

    namespace MorseKod
    {
        class Transletor
        {
            static Dictionary<string, char> Kods = new Dictionary<string, char>(){
                { ".-", 'A' }, 
                { "-...", 'B' }, 
                { "-.-.", 'C' }, 
                { "-..", 'D' }, 
                { ".", 'E' },
                { "..-.", 'F' }, 
                { "--.", 'G' }, 
                { "....", 'H' }, 
                { "..", 'I' }, 
                { ".---", 'J' },
                { "-.-", 'K' }, 
                { ".-..", 'L' }, 
                { "--", 'M' }, 
                { "-.", 'N' }, 
                { "---", 'O' },
                { ".--.", 'P' }, 
                { "--.-", 'Q' }, 
                { ".-.", 'R' }, 
                { "...", 'S' }, 
                { "-", 'T' },
                { "..-", 'U' }, 
                { "...-", 'V' }, 
                { ".--", 'W' }, 
                { "-..-", 'X' },
                { "-.--", 'Y' },
                { "--..", 'Z' },
                { "-----", '0' }, 
                { ".----", '1' }, 
                { "..---", '2' }, 
                { "...--", '3' },
                { "....-", '4' }, 
                { ".....", '5' }, 
                { "-....", '6' }, 
                { "--...", '7' }, 
                { "---..", '8' },
                { "----.", '9' }, 
                { "/", ' ' }
            };
            public static string toNormal(string line)
            {
                string[] kodes = line.Split(' ');
                string ret = "";
                foreach (var item in kodes)
                {
                    foreach (var item2 in Kods)
                    {
                        if (item2.Key == item)
                        {
                            ret += item2.Value;
                        }
                    }
                }

                return ret;

            }
            
            public static string toMorse(string line)
            {
                char[] chars = line.ToCharArray();
                string ret = "";
                foreach (var item in chars)
                {
                    foreach (var item2 in Kods)
                    {
                        if (item2.Value == char.ToUpper(item))
                        {
                            ret += item2.Key;
                            ret += " ";
                        }
                    }
                }

                return ret;

            }
        }
        
        
    }
    internal class Program
    {
        
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1 - to normal\n2 - to morse\n3 - exit");
                int userChoise = int.Parse(Console.ReadLine());
                switch (userChoise)
                {
                    case 1:
                        Console.Write("Morse: ");
                        Console.WriteLine(MorseKod.Transletor.toNormal(Console.ReadLine()));
                        break;
                    case 2:
                        Console.Write("Morse: ");
                        Console.WriteLine(MorseKod.Transletor.toMorse(Console.ReadLine()));
                        break;
                    case 3:
                        return;
                    default:
                        break;
                }
            }
        }
    }
}
