using Dictionary.Dictionary.MyDictionaries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Dictionary.Dictionary.Menu
{
    public class Menu
    {
        public List<MyDictionary> Dictionaries;
        public void ProgramMenu()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("=============================");
            Console.WriteLine("     📚 СЛОВНИКАР 1.0");
            Console.WriteLine("=============================\n");

            Console.WriteLine("[1] ➕ Додати новий словник");
            Console.WriteLine("[2] 📂 Переглянути словники");
            Console.WriteLine("[3] 📝 Додати слово до словника");
            Console.WriteLine("[4] 🔍 Знайти слово");
            Console.WriteLine("[5] ❌ Видалити слово");
            Console.WriteLine("[6] 🗑️ Видалити словник");
            Console.WriteLine("[7] 💾 Зберегти зміни");
            Console.WriteLine("[8] 🚪 Вийти з програми");

            Console.Write("\nВиберіть опцію (1-8): ");
            int uzerChoice = int.Parse(Console.ReadLine());
            MenuSwicher(uzerChoice);
        }
        public void MenuSwicher(int uzerChoice)
        {
            switch (uzerChoice)
            {
                case 1:
                    AddNewDictionary();
                    break;
                case 2:
                    PrintAll();
                    break;
                case 3:
                    AddNewWord();
                    break;
                case 4:
                    SearchForAWordTranslation();
                    break;
                case 5:
                    DeleteWord();
                    break;
                case 6:
                    DeleteDictionary();
                    break;
                case 7:
                    Save();
                    break;
                case 8:
                    ProgramMeneger.Stop();
                    break;
                default:
                    break;
            }
        }

        public void PrintAll()
        {
            if (Dictionaries.Count == 0)
            {
                Console.WriteLine("There is no dictionary yet.");
            }
            else
            {
                foreach (var item in Dictionaries)
                {
                    Console.WriteLine($"{item.Name.ToString()}");
                }
            }
        }
        public void AddNewDictionary()
        {
            Console.WriteLine("Enter name:");
            string name = Console.ReadLine();
            var tmpDictionary = Dictionaries.FirstOrDefault(elem => elem.Name == name);
            if (tmpDictionary == new MyDictionary())
            {
                Dictionaries.Add(new MyDictionary(name));
                Console.WriteLine("Done");
                return;
            }
            Console.WriteLine("This dictionary already exists.");
        }
        public void Save()
        {
            string json = JsonSerializer.Serialize(Dictionaries, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText($"Dictionaries.json", json);
            Console.WriteLine("Done");
        }
        public void AddNewWord()
        {
            Console.WriteLine("Select the desired dictionary:");
            PrintAll();
            string choice = Console.ReadLine();

            var tmpDictionary = Dictionaries.FirstOrDefault(elem => elem.Name == choice);
            if (tmpDictionary == new MyDictionary())
            {
                Console.WriteLine("Such a dictionary does not exist, would you like to create one?(1-yes, 2-no)");
                string newChoice = Console.ReadLine();
                if(newChoice == "1")
                {
                    AddNewDictionary();
                }
                return;
            }
            tmpDictionary.AddNewWord();
        }

        public void SearchForAWordTranslation()
        {
            Console.WriteLine("Enter word to search");
            string word = Console.ReadLine();
            Dictionaries.ForEach(elem =>
            {
                elem.FindTheWord(word);
            });
        }
        public void DeleteDictionary()
        {
            PrintAll();
            Console.WriteLine("Enter dictionary to delete:");
            string choice = Console.ReadLine();
            var tmpDictionary = Dictionaries.FirstOrDefault(elem => elem.Name == choice);
            if (Dictionaries.Remove(tmpDictionary))
                Console.WriteLine("Done");
            else
                Console.WriteLine("Not found");
        }
        public void DeleteWord()
        {
            PrintAll();
            Console.WriteLine("Keep a dictionary with the word you need");
            string choice = Console.ReadLine();
            var tmpDictionary = Dictionaries.FirstOrDefault(elem => elem.Name == choice);
            Console.WriteLine("Enter word to delete:");
            choice = Console.ReadLine();
            tmpDictionary.RemoveWord(choice);
        }
    }
}
