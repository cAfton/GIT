using System.Collections;
using Newtonsoft.Json;

namespace Cuisine
{
    public enum Сuisine
    {
        Ukranian,
        American,
        Chinise,
        Japanice,
        Brasilian,
        Indian,
        Mexican
    }

    public enum Type1
    {
        Soop,
        Salad,
        Dessert /*eagle "pow pow baby"*/,
        SecondCourse,
        Snack
    }
    public class Recipe
    {
        public string Name { get; set; }
        public Сuisine cuisine { get; set; }
        public double Time { get; set; }
        public List<string> Steps { get; set; }
        public Type1 type1 { get; set; }
        public Dictionary<string, (int, int)> Ingridients { get; set; }

       
        public override string ToString()
        {
            string steps = "";
            int i = 1;
            foreach (var step in Steps) {
                steps += $" {i}) ";
                steps += step.ToString();
                i++;
            }

            string ingridients = "";
            foreach (var item in Ingridients)
            {
                ingridients += $"{item.Key}\nGrams:{item.Value.Item1}\tKkal:{item.Value.Item2}\n";
            }

            return $"{Name}\n{cuisine.ToString()}\n{type1.ToString()}\n{Time}\n\n{ingridients}\n\n{steps}\n";
        }
    }

    public class RecipeBook : IEnumerable<Recipe>, IDisposable
    {
        public List<Recipe> recipes = new List<Recipe>();

        private string filePath = "RecipeBook.json";

        public void AddRecipe(Recipe recipe)
        {
            recipes.Add(recipe);
        }
        public void DeleteRecipe(string Name)
        {
            Recipe a = recipes.Find((name) => { return name.Name == Name; });
            recipes.Remove(a);
        }

        public void readFromFile()
        {
            string text = File.ReadAllText(filePath);
            recipes = JsonConvert.DeserializeObject<List<Recipe>>(text);
        }
        public void writeToFile()
        {
            string text = JsonConvert.SerializeObject(recipes, Formatting.Indented);
            File.WriteAllText(filePath, text);
        }

        public List<Recipe> FindRecepe()
        {

            if (recipes.Count != 0)
            {

                var b = recipes[0].GetType().GetProperties();
                for (int i = 0; i < b.Length; i++)
                {
                    if (b[i].Name != "Ingridients")
                    {
                        Console.WriteLine(b[i].Name);
                    }
                }
                Console.WriteLine("enter search paramether: ");
                string BB = Console.ReadLine();
                Console.WriteLine("enter what to find");
                string KK = Console.ReadLine();
                return recipes.FindAll((param) => { return param.GetType().GetProperty(BB).GetValue(param).ToString() == KK; });
            }
            return recipes;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerator<Recipe> GetEnumerator()
        {
            return recipes.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    internal class Program
    {
        


        static void Main(string[] args)
        {
            /*RecipeBook book = new RecipeBook()
            {
                recipes = new List<Recipe>() {
                    new Recipe() {
                        Name = "borch",
                        cuisine = Сuisine.Ukranian,
                        Ingridients = new Dictionary <string, (int,int)>(),
                        Steps = new List<string>(),
                        Time = 2,
                        type1 = Type1.Soop

                    },
                    new Recipe() {
                        Name = "borch1",
                        cuisine = Сuisine.Ukranian,
                        Ingridients = new Dictionary <string, (int,int)>(),
                        Steps = new List<string>(),
                        Time = 2,
                        type1 = Type1.Soop

                    },
                }
            };

            var elem = book.FindRecepe();
            foreach (var item in elem)
            {
                Console.WriteLine(item.Name);
            }*/
            RecipeBook book = new RecipeBook();
            book.readFromFile();

            book.writeToFile();

            foreach (var item in book)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();

        }
    }
}
