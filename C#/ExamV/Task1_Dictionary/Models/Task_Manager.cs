using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;
using System.Transactions;

namespace Task1_Dictionary.Models
{
    public static class Task_Manager
    {
        private static List<User> Users { get; set; } = new List<User>();
        public static void RunTask()
        {
            LoadUsers();

            Console.WriteLine("1 - Log in\n2 - Sign up\nElse - exit");
            User user;
            switch (Console.ReadLine())
            {
                case "1":
                    user = LogIn();
                    break;
                case "2":
                    user = SignUp();
                    break;
                default:
                    Console.WriteLine("Bye:)");
                    return;
            }

            int userChoise = -1;

            while(userChoise != 0)
            {
                Console.WriteLine("1 - new game\n2 - show history\n3 - Top-20\n4 - Change something\n0 - exit");

                switch(Console.ReadLine())
                {
                    case "1":
                        
                        Console.WriteLine("Choose type of quiz: ");
                        Console.WriteLine("1 - History\n2 - Math\n3 - Geografy\n4 - Biology\n5 - mixed");
                        int type = int.Parse(Console.ReadLine());

                        if (type >= 1 && type <= 4)
                        {
                            Quiz_Manager quiz_Manager = RunQuiz(type);

                            Console.WriteLine("Level:\n1 - Hard\n2 - Madium\n3 - Easy");
                            int level = int.Parse(Console.ReadLine());

                            RunGame(quiz_Manager, level, user, type);
                        }
                        else if(type == 5)
                        {
                            List<Quiz_Manager> quiz_Managers = new List<Quiz_Manager>();
                            quiz_Managers.Add(RunQuiz(1));
                            quiz_Managers.Add(RunQuiz(2));
                            quiz_Managers.Add(RunQuiz(3));
                            quiz_Managers.Add(RunQuiz(4));

                            Random random = new Random();

                            Console.WriteLine("Level:\n1 - Hard\n2 - Madium\n3 - Easy");
                            int level = int.Parse(Console.ReadLine());
                            int scoreMixed = 0;
                            switch (level)
                            {
                                case 1:
                                    for (int i = 0; i < 15; i++)
                                    {
                                        int random1 = random.Next() % 4;
                                        int random2 = random.Next() % 16; 
                                        Console.WriteLine(quiz_Managers[random1].Quizes_Hard[random2]);

                                        int chose = int.Parse(Console.ReadLine());

                                        if (IsAnswerCorrect(chose, quiz_Managers[random1].Quizes_Hard[random2].RightAnswer, quiz_Managers[random1].Quizes_Hard[random2]))
                                        {
                                            scoreMixed++;
                                        }
                                    }
                                    
                                    break;
                                case 2:

                                    for (int i = 0; i < 15; i++)
                                    {
                                        int random1 = random.Next() % 4;
                                        int random2 = random.Next() % 16;
                                        Console.WriteLine(quiz_Managers[random1].Quizes_Medium[random2]);

                                        int chose = int.Parse(Console.ReadLine());

                                        if (IsAnswerCorrect(chose, quiz_Managers[random1].Quizes_Medium[random2].RightAnswer, quiz_Managers[random1].Quizes_Medium[random2]))
                                        {
                                            scoreMixed++;
                                        }
                                    }
                                    break;
                                case 3:

                                    for (int i = 0; i < 15; i++)
                                    {
                                        int random1 = random.Next() % 4;
                                        int random2 = random.Next() % 16;
                                        Console.WriteLine(quiz_Managers[random1].Quizes_Easy[random2]);

                                        int chose = int.Parse(Console.ReadLine());

                                        if (IsAnswerCorrect(chose, quiz_Managers[random1].Quizes_Easy[random2].RightAnswer, quiz_Managers[random1].Quizes_Easy[random2]))
                                        {
                                            scoreMixed++;
                                        }
                                    }
                                    break;
                                default:
                                    break;
                            }

                            SaveHistory(level, TypesOfQuiz.Mixed, scoreMixed, user);
                        }
                        else
                        {
                            Console.WriteLine("Wrong option.");
                        }

                        


                        break;
                    case "2":
                        user.HistoryOfQuizes.ForEach(elem => Console.WriteLine(elem));
                        break;
                    case "3":
                        Console.WriteLine("Soon...");
                        //Users.OrderBy(elem => elem.getMaxScore());
                        //int top;
                        //if (Users.Count >= 20)
                        //{
                        //    top = 20;
                        //}
                        //else
                        //{
                        //    top = Users.Count;
                        //}

                        //for (int i = 0; i < top; i++)
                        //{
                        //    Console.WriteLine(Users[i]);
                        //}

                        break;
                    case "4":
                        Console.WriteLine("Change\n1 - Password\n2 - Birthday");
                        switch (Console.ReadLine())
                        {
                            case "1":
                                Console.WriteLine("Enter new password: ");
                                user.Password = Console.ReadLine();
                                break;
                            case "2":
                                Console.WriteLine("Enter birthday: ");
                                user.Birthday = DateTime.Parse(Console.ReadLine());
                                break;
                            default:
                                Console.WriteLine("Wrong option");
                                break;
                        }
                        break;
                    case "0":
                        Console.WriteLine("Bye:)");
                        string save = JsonConvert.SerializeObject(Users, Formatting.Indented, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto });
                        File.WriteAllText("Users.json", save);
                        return;
                    default:
                        break;
                }
            }
        }

        private static void SaveHistory(int level, TypesOfQuiz type, int score, User user)
        {
            HardLevel levelToSave = new HardLevel();
            switch (level)
            {
                case 1:
                    levelToSave = HardLevel.Hard;
                    break;
                case 2:
                    levelToSave = HardLevel.Medium;
                    break;
                case 3:
                    levelToSave = HardLevel.Easy;
                    break;
                default:
                    break;

            }

            user.AddHistory(type, levelToSave, score);
        }

        private static bool IsAnswerCorrect(int answer, int rightAnswer, Quiz elem)
        {
            if (answer == rightAnswer)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Correct!");
                Console.ResetColor();
                return true;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong!");
                Console.ResetColor();
                Console.WriteLine($"The correct answer is {elem.RightAnswer}) {elem.Answers[elem.RightAnswer - 1]}");
                return false;
            }
        }
        private static void RunGame(Quiz_Manager quiz_Manager, int level, User user, int type)
        {
            int score = 0;
            switch (level)
            {
                case 1:
                    quiz_Manager.Quizes_Easy.ForEach(elem => {
                        Console.WriteLine(elem);
                        int chose = int.Parse(Console.ReadLine());

                        if(IsAnswerCorrect(chose, elem.RightAnswer, elem))
                        {
                            score++;
                        }

                    });
                    break;
                case 2:
                    quiz_Manager.Quizes_Medium.ForEach(elem =>
                    {
                        Console.WriteLine(elem);
                        int chose = int.Parse(Console.ReadLine());

                        if (IsAnswerCorrect(chose, elem.RightAnswer, elem))
                        {
                            score++;
                        }
                    });
                    break;
                case 3:
                    quiz_Manager.Quizes_Hard.ForEach(elem =>
                    {
                        Console.WriteLine(elem);
                        int chose = int.Parse(Console.ReadLine());

                        if (IsAnswerCorrect(chose, elem.RightAnswer, elem))
                        {
                            score++;
                        }
                    });
                    break;
            }

            TypesOfQuiz SaveofQuiz = new TypesOfQuiz();
            switch (type)
            {
                case 1:
                    SaveofQuiz = TypesOfQuiz.History;
                    break;
                case 2:
                    SaveofQuiz = TypesOfQuiz.Math;
                    break;
                case 3:
                    SaveofQuiz = TypesOfQuiz.Geografy;
                    break;
                case 4:
                    SaveofQuiz = TypesOfQuiz.Biology;
                    break;
                default:
                    break;
            }

            SaveHistory(level, SaveofQuiz, score, user);
        }
        private static Quiz_Manager RunQuiz (int chose) {
            switch (chose)
            {
                case 1:
                    string jsonFromFileHistory = File.ReadAllText("History.json");
                    return JsonConvert.DeserializeObject<Quiz_Manager>(jsonFromFileHistory, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto });
                case 2:
                    string jsonFromFileMath = File.ReadAllText("Math.json");
                    return JsonConvert.DeserializeObject<Quiz_Manager>(jsonFromFileMath, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto });
                case 3:
                    string jsonFromFileGeografy = File.ReadAllText("Geografy.json");
                    return JsonConvert.DeserializeObject<Quiz_Manager>(jsonFromFileGeografy, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto });
                case 4:
                    string jsonFromFileBiology = File.ReadAllText("Biology.json");
                    return JsonConvert.DeserializeObject<Quiz_Manager>(jsonFromFileBiology, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto });
                default:
                    return new Quiz_Manager();
                    break;
            }
            

            
            

        }

        private static bool isLoged(User user) {
            Console.WriteLine("Wrong pass. Try again");
            Console.Write("Enter pas: ");
            if (user.Password == Console.ReadLine())
            {
                Console.WriteLine("Welcome!");
                return true;
            }
            else
            {
                return false;
            }
        }

        private static User LogIn()
        {
            User user;

            while (true)
            {
                Console.Write("Enter login: ");
                string login = Console.ReadLine();

                Console.Write("Enter pas: ");
                string pass = Console.ReadLine();

                user = Users.FirstOrDefault(elem => elem.Login == login);

                if (user != null)
                {
                    if (user.Password == pass)
                    {
                        Console.WriteLine("Welcome!");
                        return user;
                    }
                    else
                    {
                        while (!isLoged(user)) ;
                        Console.WriteLine("Welcome!");
                        return user;
                    }
                }
                else
                {
                    Console.WriteLine("Couldn't find user. Would you like to\n1 - sign up\n2 - Try again");
                    switch (Console.ReadLine())
                    {
                        case "1":
                            return SignUp();
                        default:
                            Console.WriteLine("Wrong option");
                            break;
                    }

                }
            }
        }

        private static User SignUp()
        {
            User user;
            string login;
            do
            {
                Console.WriteLine("Enter new unique login: ");

                login = Console.ReadLine();

                if (!Users.Any(elem => elem.Login == login)) 
                {
                    break;
                }
            } while (true);

            Console.WriteLine("Enter password: ");

            string pass = Console.ReadLine();

            Console.WriteLine("Enter your date of birthday: ");

            string BD = Console.ReadLine();

            User newUser = new User() { Login = login, Password = pass, Birthday = DateTime.Parse(BD) };

            Users.Add(newUser);

            return newUser;

        }

        private static void LoadUsers()
        {
            string jsonFromFile = File.ReadAllText("Users.json");
            Users = JsonConvert.DeserializeObject<List<User>>(jsonFromFile, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto });
        }
    }
}
