using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace taska2
{
    public class LevelQuizKeeper
    {
        public List<Quiz> Quizes_Easy { get; set; }
        public List<Quiz> Quizes_Medium { get; set; }
        public List<Quiz> Quizes_Hard { get; set; }

        public static List<Quiz> LoadFromFile(TypesOfQuiz name, HardLevel level)
        {
            string read = File.ReadAllText($"{name.ToString()}.json");
            LevelQuizKeeper quizs = JsonConvert.DeserializeObject<LevelQuizKeeper>(read);

            switch (level)
            {
                case HardLevel.Easy:
                    return quizs.Quizes_Easy;
                case HardLevel.Medium:
                    return quizs.Quizes_Medium;
                case HardLevel.Hard:
                    return quizs.Quizes_Hard;
                default:
                    return new List<Quiz>();
            }
        }
        public static List<Quiz> LoadFromFile(string Filepath, HardLevel level)
        {
            string read = File.ReadAllText(Filepath);
            LevelQuizKeeper quizs = JsonConvert.DeserializeObject<LevelQuizKeeper>(read);

            switch (level)
            {
                case HardLevel.Easy:
                    return quizs.Quizes_Easy;
                case HardLevel.Medium:
                    return quizs.Quizes_Medium;
                case HardLevel.Hard:
                    return quizs.Quizes_Hard;
                default:
                    return new List<Quiz>();
            }
        }
    }
}
