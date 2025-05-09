namespace Task2
{
    public class DictionaryEngFran
    {
        Dictionary<string, List<string>> dictionaries { get; set; } = new Dictionary<string, List<string>>();

        public void Add(string newWord, string newTrans)
        {
            if (dictionaries.ContainsKey(newWord))
            {
                dictionaries[newWord].Add(newTrans);
            }
            else
            {
                dictionaries.Add(newWord, new List<string> { newTrans});
            }
        }

        public void RemoveWord(string Word)
        {
            dictionaries.Remove(Word);
        }

        public void RemoveTranslation(string Word)
        {
            if (dictionaries.ContainsKey(Word))
            {
                Console.WriteLine();
                foreach (var item in dictionaries[Word])
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("\nWhat word to delete: ");
                string wordToDel = Console.ReadLine();
                dictionaries[Word].Remove(wordToDel);
            }
            else
            {
                Console.WriteLine("Error word");
            }
        }

        public void EditWord(string Word)
        {
            if (dictionaries.ContainsKey(Word))
            {
                Console.WriteLine("Enter new word: ");
                string newWord = Console.ReadLine();
                List<string> tmp = dictionaries[Word];
                dictionaries.Remove(Word);
                dictionaries.Add(newWord, tmp);
            }
            else
            {
                Console.WriteLine("Error word");
            }
        }

        public void EditWordTrans(string Word)
        {
            if (dictionaries.ContainsKey(Word))
            {
                Console.WriteLine("Translations: ");
                foreach (var item in dictionaries[Word])
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("\nWhat word to edit: ");
                string wordToDel = Console.ReadLine();
                dictionaries[Word].Remove(wordToDel);
            }
            else
            {
                Console.WriteLine("Error word");
            }
        }

        public void FindTranslate(string Word, bool EngFran)
        {
            if (dictionaries.ContainsKey(Word))
            {
                if (EngFran)
                {
                    Console.WriteLine("\nTranslation: ");
                    foreach (var item in dictionaries[Word])
                    {
                        Console.WriteLine($"{item} ");
                    }
                }
                
            }
            else
            {
                Console.WriteLine("\nTranslation: ");
                foreach (var item in dictionaries)
                {
                    foreach (var translate in item.Value)
                    {
                        if (translate == Word)
                        {
                            Console.WriteLine(item.Key);
                        }
                    }
                }
            }
            
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            DictionaryEngFran dictionary = new DictionaryEngFran();
            int userChoise = -1;
            while (userChoise != 0)
            {
                Console.WriteLine("\n1 - Add new word\\translation\n2 - Delete...\n3 - Edit...\n4 - Find translation...");
                userChoise = int.Parse(Console.ReadLine());
                switch (userChoise)
                {
                    case 1:
                        Console.WriteLine("Enter word: ");
                        string word = Console.ReadLine();
                        bool toContinue = true;
                        do
                        {
                            Console.WriteLine("Enter new translation: ");
                            dictionary.Add(word, Console.ReadLine());

                            Console.WriteLine("Enter another translation?\n1 - yes\n2 - no");
                            int choisContinue = int.Parse(Console.ReadLine());
                            if (choisContinue == 2)
                            {
                                toContinue = false;
                            }
                        } while (toContinue);
                        break;
                    case 2:
                        Console.WriteLine("Delete\n1 - word\n2 - translation");
                        userChoise = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter word to delete: ");
                        if (userChoise == 1)
                        {
                            dictionary.RemoveWord(Console.ReadLine());
                        }
                        else
                        {
                            dictionary.RemoveTranslation(Console.ReadLine());
                        }
                        break;
                    case 3:
                        Console.WriteLine("Edit\n1 - word\n2 - translation");
                        userChoise = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter word to edit: ");
                        if (userChoise == 1)
                        {
                            dictionary.EditWord(Console.ReadLine());
                        }
                        else
                        {
                            dictionary.EditWordTrans(Console.ReadLine());
                        }
                        break;
                    case 4:
                        Console.WriteLine("Translate \n1 - from English to Franch\n2 - from Franch to English");
                        userChoise = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter word to translate: ");
                        if (userChoise == 1)
                        {
                            dictionary.FindTranslate(Console.ReadLine(), true);
                        }
                        else
                        {
                            dictionary.FindTranslate(Console.ReadLine(), true);
                        }
                        break;
                    default:
                        Console.WriteLine("Error option");
                        break;
                }
            }
        }
    }
}
