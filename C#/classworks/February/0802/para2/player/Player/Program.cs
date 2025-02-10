using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Player
{
    /*Створіть клас Player із властивостями Name, Score і Level.
    Властивість Score має автоматично збільшувати рівень гравця (Level), 
    коли кількість очок досягає певного порога.
    Використовуйте автоматичні властивості для полів Name і Score.
    Реалізуйте логіку в set-аксесорі властивості Score, 
    щоб перевіряти необхідність підвищення рівня гравця.*/
    public class Player
    {
        public const int toNextLevel = 100;
        public string Name {  get; set; }
        public int Level { get; set; }
        private int score { get; set; }

        public int Score {  get { return score; }  set {
                
                double pointForLevel = toNextLevel * Math.Exp(Level / 2);
                if (value > pointForLevel)
                {
                    Level++;
                    Score = value - (int)pointForLevel;
                }
                else
                {
                    score = value;
                }
            } }

        public Player(string name, int level, int score) {
            Name = name;
            Level = level;
            Score = score;
            
        }

        public Player(string line)
        {
            string[] strings = line.Split(' ');

            try
            {
                Name = strings[0];
                Level = int.Parse(strings[1]);
                Score = int.Parse(strings[2]);
            }
            catch (FormatException exc)
            {
                Console.WriteLine(exc.Message);
                Level = 1;
                Score = 0;
            }
            catch(IndexOutOfRangeException)
            {
                Console.WriteLine("Wrong input, nothing is saved");
            }
        }

        public override string ToString()
        {
            string ret = $"Name: {Name}\nLevel: {Level}\nScore: {Score}/{(toNextLevel * Math.Exp(Level / 2)).ToString("0.")}";
            return ret;
        }

        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player("name1", 1, 1000);
            Console.WriteLine(player1);
            //Player player2 = new Player(Console.ReadLine());

            Console.WriteLine($"{player1}\n");

            Console.ReadLine();

        }
    }
}
