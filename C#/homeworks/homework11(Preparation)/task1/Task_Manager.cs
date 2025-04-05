using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using task1.Models;

namespace task1
{
    public static class Task_Manager
    {
        public static List<Training> Trainings { get; set; } = new List<Training>();
        public static void Menu()
        {
            Console.Write("========= TRAINING TRACKER MENU =========\n\n" +
                "1. Add a New Training\n" +
                "2. Edit Existing Training\n" +
                "3. Delete a Training\n" +
                "4. View Statistics\n" +
                "5. Search Trainings\n" +
                "6. Save Data\n" +
                "7. Exit Program\n\n" +
                "========================================\n" +
                "Please select an option (1-7):");
            Console.Clear();
            switch (Console.ReadLine())
            {
                case "1":
                    Add();
                    break;
                case "2":
                    Edit();
                    break;
                case "3":
                    Delete();
                    break;
                case "4":
                    View();
                    break;
                case "5":
                    Search();
                    break;
                case "6":
                    Save();
                    break;
                case "7":
                    return;
                default:
                    break;
            }

            
        }

        private static void Add() {
            Console.WriteLine("Choose type of training: ");
            Console.Write("" +
                "1. Running\n" +
                "2. Swimming\n" +
                "3. Bicycling\n\n>>> ");

            TypeOfTraining newType = new TypeOfTraining();
            switch (Console.ReadLine())
            {
                case "1":
                    newType = TypeOfTraining.Running;
                    break;
                case "2":
                    newType = TypeOfTraining.Swimming;
                    break;
                case "3":
                    newType = TypeOfTraining.Bicycling;
                    break;
                default:
                    break;
            }

            Console.Write("Enter date of training\n>>> ");
            DateTime date = DateTime.Parse(Console.ReadLine());

            Console.Write("Enter duration of training\n>>> ");
            double duration = double.Parse(Console.ReadLine());

            Console.Write("Enter distanse of training\n>>> ");
            double distanse = double.Parse(Console.ReadLine());

            Console.Write("Enter lost Kkal\n>>> ");
            int lostKkal = int.Parse(Console.ReadLine());

            Trainings.Add(new Training() { TrainingType = newType, Date =  date, Duration = duration, Distanse = distanse, LostKkal = lostKkal });

        }

        private static void Edit() {
            Console.WriteLine("Choose what to edit: ");
            Console.Write("" +
                "1. Type\n" +
                "2. Duration\n" +
                "3. Distanse\n" +
                "4. Lost Kkal\n\n>>> ");

            string userChose = Console.ReadLine();

            Console.WriteLine("Enter date of training");
            DateTime dateTime = DateTime.Parse(Console.ReadLine());

            switch (userChose)
            {
                case "1":
                    Console.WriteLine("Enter new type: ");
                    Console.WriteLine("Choose type of training: ");
                    Console.Write("" +
                        "1. Running\n" +
                        "2. Swimming\n" +
                        "3. Bicycling\n\n>>> ");

                    TypeOfTraining newType = new TypeOfTraining();
                    switch (Console.ReadLine())
                    {
                        case "1":
                            Trainings.Find(elem => elem.Date == dateTime).TrainingType = TypeOfTraining.Running;
                            break;
                        case "2":
                            Trainings.Find(elem => elem.Date == dateTime).TrainingType = TypeOfTraining.Swimming;
                            break;
                        case "3":
                            Trainings.Find(elem => elem.Date == dateTime).TrainingType = TypeOfTraining.Bicycling;
                            break;
                        default:
                            break;
                    }

                    

                    break;
                case "2":
                    Console.WriteLine("Enter new duration: ");
                    Trainings.Find(elem => elem.Date == dateTime).Duration = double.Parse(Console.ReadLine());
                    break;
                case "3":
                    Console.WriteLine("Enter new distanse: ");
                    Trainings.Find(elem => elem.Date == dateTime).Distanse = double.Parse(Console.ReadLine());
                    break;
                case "4":
                    Console.WriteLine("Enter new duration: ");
                    Trainings.Find(elem => elem.Date == dateTime).LostKkal = int.Parse(Console.ReadLine());
                    break;
                default:
                    break;
            }
        }

        private static void Delete() {
            Console.WriteLine("Enter date of training to delete: ");
            DateTime dateTime = DateTime.Parse(Console.ReadLine());
            Trainings.Remove(Trainings.Find(elem => elem.Date == dateTime));
        }

        private static void View() {
            Trainings.ForEach(elem => Console.WriteLine(elem));
        }

        private static void Search() {
            Console.WriteLine("Enter date of training to seach: ");
            DateTime dateTime = DateTime.Parse(Console.ReadLine());
            Console.WriteLine(Trainings.Find(elem => elem.Date == dateTime));
        }

        private static void Save() {
            string json = JsonConvert.SerializeObject(Trainings, Formatting.Indented, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto });
            File.WriteAllText("Trainings.json", json);
        }
    }
}
