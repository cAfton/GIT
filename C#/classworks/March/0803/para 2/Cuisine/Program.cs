using System.Collections;
using System.Linq.Expressions;
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

        public void Edit(string elemToEdit)
        {
            var b = recipes[0].GetType().GetProperties();
            for (int i = 0; i < b.Length; i++)
            {
                Console.WriteLine(b[i].Name);
            }

            Console.WriteLine("Enter parametr to edit: ");
            string param = Console.ReadLine();

            var elem = recipes.Find(item => item.Name == elemToEdit);

            switch (param)
            {
                case "Name":
                    Console.WriteLine("Enter new name: ");
                    elem.Name = Console.ReadLine();
                    break;
                case "cuisine":
                    Console.WriteLine("Enter new cuisine: ");
                    if(Enum.TryParse(typeof(Cuisine.Сuisine), Console.ReadLine(), true, out var result))
                    {
                        elem.cuisine = (Cuisine.Сuisine)result;
                    }
                    
                    break;
                case "Time":
                    Console.WriteLine("Enter new time: ");
                    elem.Time = double.Parse( Console.ReadLine());
                    break;
                case "Steps":
                    Console.WriteLine("Enter new step: ");
                    do
                    {
                        elem.Steps.Add(Console.ReadLine());
                        Console.WriteLine("Add another step? \n1 - yes\n2 - no");

                    } while (int.Parse(Console.ReadLine()) == 1);
                    break;
                case "type1":
                    Console.WriteLine("Enter new type: ");
                    if (Enum.TryParse(typeof(Cuisine.Type1), Console.ReadLine(), true, out result))
                    {
                        elem.type1 = (Cuisine.Type1)result;
                    }
                    break;
                case "Ingridients":
                    Console.WriteLine("Add or edit?");
                    if (Console.ReadLine().ToLower() == "add")
                    {
                        Console.WriteLine("Enter new inradient: ");
                        string newIngad = Console.ReadLine();

                        Console.WriteLine("Enter grams: ");
                        int newGrams = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter new Kkal: ");
                        int newKkal = int.Parse( Console.ReadLine());

                        elem.Ingridients.Add(newIngad, (newGrams, newKkal));
                    }
                    else
                    {
                        Console.WriteLine("Enter name of ingradient to edit: ");
                        string toFind = Console.ReadLine();
                        Console.WriteLine("Enter grams and Kkal: ");
                        elem.Ingridients[elem.Ingridients.First(item => item.Key == toFind).Key] = (int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
                    }
                    break;
                default:
                    break;
            }
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
            RecipeBook book = new RecipeBook();
            book.readFromFile();


            book.Edit("BorchCool");


            Console.WriteLine();


            foreach (var item in book)
            {
                Console.WriteLine(item);
            }

            book.writeToFile();

        }
    }
}
