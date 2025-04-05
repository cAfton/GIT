using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Dictionary.Dictionary.MyDictionaries
{
    public class MyDictionary
    {
        public string Name;
        public Dictionary<string, List<string>> Dictionary;

        public MyDictionary() { }
        public MyDictionary(string name)
        {
            Name = name;
            Dictionary = new Dictionary<string, List<string>>();
        }

        public void AddNewWorda()
        {
            Console.WriteLine("Enter word");
            string key = Console.ReadLine();
            AddWord(key, AddTranslations());
        }
        public void AddWord(string key, List<string> value)
        {
            if (Dictionary.TryGetValue(key, out List<string> Value))
            {
                Console.WriteLine("This word already exists");
                printWords(Value);
            }
            else
            {
                Dictionary[key] = value;
                Console.WriteLine("Done");
            }
        }
        public void PrintAllWords()
        {
            foreach (var item in Dictionary)
            {
                Console.WriteLine($"{item.Key} - {printWords(item.Value)}");
            }
        }
        private List<string> AddTranslations()
        {
            Console.WriteLine("Enter translations (0-to stop)");
            List<string> tmpValue = new List<string>();
            string tmpTranslation = "";
            int i = 1;
            while (tmpTranslation != "0")
            {
                Console.WriteLine($"Your {i} translation:)");
                tmpTranslation = Console.ReadLine();
                if (tmpTranslation != "0")
                {
                    tmpValue.Add(tmpTranslation);
                }
                i++;
            }
            return tmpValue;
        }
        private string printWords(List<string> Value)
        {
            string listOfValues = "";
            int i = 1;
            foreach (string item in Value)
            {
                listOfValues += $"{i}) {item} ";
                i++;
            }
            return listOfValues;
        }
        public void Edit(string key)
        {
            if (Dictionary.TryGetValue(key, out List<string> Value))
            {
                Console.WriteLine($"Here is the translation of this word:\n{key} - {printWords(Value)};");
                Console.WriteLine("Which word do you want to edit/delete? 0-if adding a new translation");
                int choice = int.Parse(Console.ReadLine());
                if (choice == 0)
                {
                    Console.WriteLine("Enter new translation:");
                    Value.Add(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine($"{Value[choice - 1]}\nEnter the correct word. Press Enter to delete the word.");
                    string newTranslation = Console.ReadLine();
                    if (newTranslation == "")
                    {
                        Value.Remove(Value[choice - 1]);
                    }
                    else
                    {
                        Value[choice - 1] = newTranslation;
                    }
                }
                Dictionary[key] = Value;
            }
            else
            {
                Console.WriteLine("There is no such word. Would you like to write a new word?(1-yes, 2-no)");
                int choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    AddWord(key, AddTranslations());
                }
                else
                {
                    return;
                }
            }
        }

        public void RemoveWord(string key)
        {
            if (Dictionary.Remove(key))
            {
                Console.WriteLine("Done");
            }
            else
            {
                Console.WriteLine("Word not found");
            }
        }
        public void RemoveTranslation(string key, string translation)
        {
            if (Dictionary[key].Remove(translation))
            {
                Console.WriteLine("Done");
            }
            else
            {
                Console.WriteLine("Word not found");
            }
        }
        public void FindTheWord(string key)
        {
            if (Dictionary.TryGetValue(key, out List<string> words))
            {
                Console.WriteLine($"{key} - {printWords(words)};");
            }
            else
            {
                Console.WriteLine("Erorr");
            }
        }
        public void SaveToFile()
        {
            string path = $"Dictionary({Name}).txt";

            File.WriteAllText(path, Dictionary.ToString());
        }
        public string ExportWord(string key)
        {
            if (Dictionary.TryGetValue(key, out List<string> Value))
            {
                return $"{key} - {printWords(Value)}";
            }
            Console.WriteLine("There is no such word. Would you like to write a new word?(1-yes, 2-no)");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                AddWord(key, AddTranslations());
            }
            return "0";
        }
        public override string ToString()
        {
            string lineToFile = "";
            foreach (var item in Dictionary)
            {
                lineToFile += $"{item.Key.ToString()} - {printWords(item.Value)}\n";
            }
            return lineToFile;
        }

    }
}
