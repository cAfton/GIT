using Microsoft.VisualBasic;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace task1_RealDictionary.Models
{
    public static class task_manager
    {
        public static void Menu()
        {
            string jsonFromFile = File.ReadAllText("Dictionaries.json");

            Dictionary<string, LanguageDictionary> dictionaries = JsonConvert.DeserializeObject<Dictionary<string, LanguageDictionary>>(jsonFromFile, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto });
            while (true){
                
                Console.WriteLine("1 - add new dictionary\n2 - add new word\n3 - add new translation\n4 - Change word or translation\n5 - delete word or translation\n6 - find\n7 - export one word\n8 - exit");
                switch (Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine("Enter type of dictionary: ");
                        string name = Console.ReadLine();

                        dictionaries.Add(name, new LanguageDictionary());

                        break;
                    case "2":
                        foreach (var item in dictionaries)
                        {
                            Console.WriteLine(item.Key);
                        }
                        Console.WriteLine("Choose dictionary: ");
                        string chose = Console.ReadLine();

                        Console.WriteLine("Enter word: ");
                        string word = Console.ReadLine();

                        Console.WriteLine("Enter translate: ");
                        string trans = Console.ReadLine();

                        try
                        {
                            dictionaries[chose].DictionaryLang.Add(word, new List<string>() { trans });
                        }
                        catch
                        {
                            Console.WriteLine("Couldnt find dictionary");
                        }
                        break;
                    case "3":
                        foreach (var item in dictionaries)
                        {
                            Console.WriteLine(item.Key);
                        }
                        Console.WriteLine("Choose dictionary: ");
                        string choseToAdd = Console.ReadLine();

                        Console.WriteLine("Enter word: ");
                        string wordToAddTrans = Console.ReadLine();

                        Console.WriteLine("Enter translation: ");

                        try
                        {
                            dictionaries[choseToAdd].DictionaryLang[wordToAddTrans].Add(Console.ReadLine());
                        }
                        catch
                        {
                            Console.WriteLine("Couldn't find dictionary or word");
                        }

                        break;
                    case "4":
                        Console.WriteLine("Change\n1 - word\n2 - translate");
                        switch (Console.ReadLine())
                        {
                            case "1":
                                foreach (var item in dictionaries)
                                {
                                    Console.WriteLine(item.Key);
                                }
                                Console.WriteLine("Choose dictionary: ");
                                string choseToChange = Console.ReadLine();

                                Console.WriteLine("Enter word to change: ");
                                string wordToChange = Console.ReadLine();

                                Console.WriteLine("Enter new word: ");
                                string newWord = Console.ReadLine();

                                try
                                {
                                    List<string> save = dictionaries[choseToChange].DictionaryLang[wordToChange];
                                    dictionaries[choseToChange].DictionaryLang.Remove(wordToChange);
                                    dictionaries[choseToChange].DictionaryLang.Add(newWord, save);
                                }
                                catch
                                {
                                    Console.WriteLine("Couldn't find dictionary or word");
                                }
                                break;
                            case "2":
                                foreach (var item in dictionaries)
                                {
                                    Console.WriteLine(item.Key);
                                }
                                Console.WriteLine("Choose dictionary: ");
                                string choseToChangeTranslate = Console.ReadLine();

                                Console.WriteLine("Enter word to change: ");
                                string wordToChangeTranslate = Console.ReadLine();
                                try
                                {
                                    Console.WriteLine("Translations: ");
                                    dictionaries[choseToChangeTranslate].DictionaryLang[wordToChangeTranslate].ForEach(elem => Console.WriteLine(elem));


                                    Console.WriteLine("Enter translation to change: ");
                                    string ToChangeTranslate = Console.ReadLine();
                                    dictionaries[choseToChangeTranslate].DictionaryLang[wordToChangeTranslate].Remove(ToChangeTranslate);


                                    Console.WriteLine("Enter new translation: ");
                                    string newTranslate = Console.ReadLine();

                                    dictionaries[choseToChangeTranslate].DictionaryLang[wordToChangeTranslate].Add(newTranslate);


                                }
                                catch
                                {
                                    Console.WriteLine("Couldn't find dictionary or word");
                                }
                                break;
                            default:
                                break;
                        }
                        break;
                    case "5":
                        Console.WriteLine("Delete\n1 - word\n2 - translate");
                        switch (Console.ReadLine())
                        {
                            case "1":
                                foreach (var item in dictionaries)
                                {
                                    Console.WriteLine(item.Key);
                                }
                                Console.WriteLine("Choose dictionary: ");
                                string choseToDelete = Console.ReadLine();

                                Console.WriteLine("Enter word to delete: ");
                                string wordToDelete = Console.ReadLine();

                                try
                                {
                                    dictionaries[choseToDelete].DictionaryLang.Remove(wordToDelete);
                                }
                                catch
                                {
                                    Console.WriteLine("Couldn't find dictionary or word");
                                }
                                break;
                            case "2":
                                foreach (var item in dictionaries)
                                {
                                    Console.WriteLine(item.Key);
                                }
                                Console.WriteLine("Choose dictionary: ");
                                string choseToDeleteTransl = Console.ReadLine();

                                Console.WriteLine("Enter word to delete: ");
                                string wordToDeleteTransl = Console.ReadLine();

                                try
                                {
                                    Console.WriteLine("Translations: ");
                                    dictionaries[choseToDeleteTransl].DictionaryLang[wordToDeleteTransl].ForEach(elem => Console.WriteLine(elem));


                                    Console.WriteLine("Enter translation to change: ");
                                    string ToChangeTranslate = Console.ReadLine();
                                    dictionaries[choseToDeleteTransl].DictionaryLang[wordToDeleteTransl].Remove(ToChangeTranslate);
                                }
                                catch
                                {
                                    Console.WriteLine("Couldn't find dictionary or word");
                                }
                                break;
                        }
                        break;
                    case "6":
                        Console.WriteLine("Enter word: ");
                        string toFind = Console.ReadLine();
                        foreach (var item in dictionaries)
                        {
                            if (item.Value.DictionaryLang.Keys.Contains(toFind))
                            {
                                Console.WriteLine($"Word: {toFind}\nTranslate: ");
                                item.Value.DictionaryLang[toFind].ForEach(elem => Console.WriteLine(elem));
                            }
                        }
                        break;
                    case "7":
                        Console.WriteLine("Enter word: ");
                        string toFindandSave = Console.ReadLine();
                        foreach (var item in dictionaries)
                        {
                            if (item.Value.DictionaryLang.Keys.Contains(toFindandSave))
                            {
                                string translations = "";
                                item.Value.DictionaryLang[toFindandSave].ForEach(elem => translations += elem);
                                File.WriteAllText("word.txt", $"Word: {toFindandSave}\nTranslate: {translations}");
                            }
                        }
                        break;
                    case "8":
                        string jsonToFile = JsonConvert.SerializeObject(dictionaries, Formatting.Indented, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto });
                        File.WriteAllText("Dictionaries.json", jsonToFile);
                        return;
                    default:
                        break;
                }
            }
        }
    }
}
