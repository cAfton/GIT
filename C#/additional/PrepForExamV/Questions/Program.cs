using Newtonsoft.Json;

namespace Questions
{
    public class Quiz
    {
        public string Question {  get; set; }
        public string[] Answers { get; set; }
        public int RightAnswer { get; set;}

        public override string ToString()
        {
            return $"{Question}\n\n1) {Answers[0]}\n2) {Answers[1]}\n3) {Answers[2]}";
        }
    }

    public class QuizManager
    {
        public List<Quiz> Quizes_Easy { get; set; }
        public List<Quiz> Quizes_Medium { get; set; }
        public List<Quiz> Quizes_Hard { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto };

            #region History
            string jsonFromFile = File.ReadAllText("History.json");

            QuizManager manager_History = JsonConvert.DeserializeObject<QuizManager>(jsonFromFile, settings);

            manager_History.Quizes_Easy.ForEach(elem => Console.WriteLine($"{elem.Question}\n\n1) {elem.Answers[0]}\n2) {elem.Answers[1]}\n3) {elem.Answers[2]}\n({elem.RightAnswer})\n\n"));

            manager_History.Quizes_Medium.ForEach(elem => Console.WriteLine($"{elem.Question}\n\n1) {elem.Answers[0]}\n2) {elem.Answers[1]}\n3) {elem.Answers[2]}\n({elem.RightAnswer})\n\n"));

            manager_History.Quizes_Hard.ForEach(elem => Console.WriteLine($"{elem.Question}\n\n1) {elem.Answers[0]}\n2) {elem.Answers[1]}\n3) {elem.Answers[2]}\n({elem.RightAnswer})\n\n"));

            string json = JsonConvert.SerializeObject(manager_History, Formatting.Indented, settings);
            File.WriteAllText("History.json", json);
            #endregion
            /*
            #region Math

            string jsonFromFile = File.ReadAllText("Math.json");
            QuizManager manager_Mathematics = JsonConvert.DeserializeObject<QuizManager>(jsonFromFile, settings);

            /*
            manager_Mathematics.Quizes_Easy.Add(
            new Quiz
            {
                Question = "What is 2 + 2?",
                Answers = new string[3] { "3", "4", "5" },
                RightAnswer = 2
            });

            manager_Mathematics.Quizes_Easy.Add(
            new Quiz
            {
                Question = "What is 10 × 5?",
                Answers = new string[3] { "50", "100", "15" },
                RightAnswer = 1
            });

            manager_Mathematics.Quizes_Easy.Add(
            new Quiz
            {
                Question = "What is the square root of 9?",
                Answers = new string[3] { "3", "6", "9" },
                RightAnswer = 1
            });

            manager_Mathematics.Quizes_Easy.Add(
            new Quiz
            {
                Question = "What is 100 divided by 10?",
                Answers = new string[3] { "1", "10", "100" },
                RightAnswer = 2
            });

            manager_Mathematics.Quizes_Easy.Add(
            new Quiz
            {
                Question = "What is 15 - 7?",
                Answers = new string[3] { "9", "8", "7" },
                RightAnswer = 2
            });

            manager_Mathematics.Quizes_Easy.Add(
            new Quiz
            {
                Question = "What is the value of π (pi) rounded to two decimal places?",
                Answers = new string[3] { "3.12", "3.14", "3.16" },
                RightAnswer = 2
            });

            manager_Mathematics.Quizes_Easy.Add(
            new Quiz
            {
                Question = "What is 3 × 4?",
                Answers = new string[3] { "7", "12", "9" },
                RightAnswer = 2
            });

            manager_Mathematics.Quizes_Easy.Add(
            new Quiz
            {
                Question = "What is 8 × 8?",
                Answers = new string[3] { "64", "16", "32" },
                RightAnswer = 1
            });

            manager_Mathematics.Quizes_Easy.Add(
            new Quiz
            {
                Question = "What is 20% of 50?",
                Answers = new string[3] { "5", "10", "20" },
                RightAnswer = 2
            });

            manager_Mathematics.Quizes_Easy.Add(
            new Quiz
            {
                Question = "How many degrees are in a right angle?",
                Answers = new string[3] { "45", "90", "180" },
                RightAnswer = 2
            });

            manager_Mathematics.Quizes_Easy.Add(
            new Quiz
            {
                Question = "What is 7 × 6?",
                Answers = new string[3] { "36", "42", "49" },
                RightAnswer = 2
            });

            manager_Mathematics.Quizes_Easy.Add(
            new Quiz
            {
                Question = "What is the sum of the angles in a triangle?",
                Answers = new string[3] { "90°", "180°", "360°" },
                RightAnswer = 2
            });

            manager_Mathematics.Quizes_Easy.Add(
            new Quiz
            {
                Question = "What is the smallest prime number?",
                Answers = new string[3] { "0", "1", "2" },
                RightAnswer = 3
            });

            manager_Mathematics.Quizes_Easy.Add(
            new Quiz
            {
                Question = "How many sides does a hexagon have?",
                Answers = new string[3] { "5", "6", "7" },
                RightAnswer = 2
            });

            manager_Mathematics.Quizes_Easy.Add(
            new Quiz
            {
                Question = "If a square has a side length of 4, what is its area?",
                Answers = new string[3] { "12", "16", "8" },
                RightAnswer = 2
            });



            manager_Mathematics.Quizes_Medium.Add(
            new Quiz
            {
                Question = "What is the value of 7³?",
                Answers = new string[3] { "49", "343", "210" },
                RightAnswer = 2
            });

            manager_Mathematics.Quizes_Medium.Add(
            new Quiz
            {
                Question = "What is the derivative of x²?",
                Answers = new string[3] { "x", "2x", "x²" },
                RightAnswer = 2
            });

            manager_Mathematics.Quizes_Medium.Add(
            new Quiz
            {
                Question = "Solve for x: 2x + 5 = 15.",
                Answers = new string[3] { "5", "7.5", "10" },
                RightAnswer = 1
            });

            manager_Mathematics.Quizes_Medium.Add(
            new Quiz
            {
                Question = "What is the sum of the interior angles of a pentagon?",
                Answers = new string[3] { "360°", "540°", "720°" },
                RightAnswer = 2
            });

            manager_Mathematics.Quizes_Medium.Add(
            new Quiz
            {
                Question = "Which of the following numbers is a Fibonacci number?",
                Answers = new string[3] { "20", "21", "22" },
                RightAnswer = 2
            });

            manager_Mathematics.Quizes_Medium.Add(
            new Quiz
            {
                Question = "What is the factorial of 5?",
                Answers = new string[3] { "60", "120", "150" },
                RightAnswer = 2
            });

            manager_Mathematics.Quizes_Medium.Add(
            new Quiz
            {
                Question = "What is the solution to 3x - 7 = 11?",
                Answers = new string[3] { "4", "5", "6" },
                RightAnswer = 3
            });

            manager_Mathematics.Quizes_Medium.Add(
            new Quiz
            {
                Question = "If log₂(x) = 5, what is x?",
                Answers = new string[3] { "10", "16", "32" },
                RightAnswer = 3
            });

            manager_Mathematics.Quizes_Medium.Add(
            new Quiz
            {
                Question = "What is the sum of the first 10 natural numbers?",
                Answers = new string[3] { "45", "50", "55" },
                RightAnswer = 3
            });

            manager_Mathematics.Quizes_Medium.Add(
            new Quiz
            {
                Question = "If f(x) = 2x + 3, what is f(4)?",
                Answers = new string[3] { "8", "10", "11" },
                RightAnswer = 3
            });

            manager_Mathematics.Quizes_Medium.Add(
            new Quiz
            {
                Question = "Which of the following is an irrational number?",
                Answers = new string[3] { "√16", "π", "0.75" },
                RightAnswer = 2
            });

            manager_Mathematics.Quizes_Medium.Add(
            new Quiz
            {
                Question = "What is the least common multiple (LCM) of 4 and 6?",
                Answers = new string[3] { "12", "18", "24" },
                RightAnswer = 1
            });

            manager_Mathematics.Quizes_Medium.Add(
            new Quiz
            {
                Question = "What is 2⁵?",
                Answers = new string[3] { "16", "32", "64" },
                RightAnswer = 2
            });

            manager_Mathematics.Quizes_Medium.Add(
            new Quiz
            {
                Question = "What is the sum of the roots of the quadratic equation x² - 5x + 6 = 0?",
                Answers = new string[3] { "3", "5", "6" },
                RightAnswer = 2
            });

            manager_Mathematics.Quizes_Medium.Add(
            new Quiz
            {
                Question = "What is the area of a triangle with base 8 and height 5?",
                Answers = new string[3] { "20", "25", "40" },
                RightAnswer = 1
            });



            manager_Mathematics.Quizes_Hard.Add(
            new Quiz
            {
                Question = "What is the derivative of sin(x)?",
                Answers = new string[3] { "cos(x)", "-sin(x)", "-cos(x)" },
                RightAnswer = 1
            });

            manager_Mathematics.Quizes_Hard.Add(
            new Quiz
            {
                Question = "Solve the equation: 2x² - 5x + 2 = 0.",
                Answers = new string[3] { "1 and 2", "1/2 and 2", "2 and 5" },
                RightAnswer = 2
            });

            manager_Mathematics.Quizes_Hard.Add(
            new Quiz
            {
                Question = "What is the integral of e^x?",
                Answers = new string[3] { "e^x + C", "ln(x) + C", "xe^x + C" },
                RightAnswer = 1
            });

            manager_Mathematics.Quizes_Hard.Add(
            new Quiz
            {
                Question = "What is the determinant of the matrix [[1,2],[3,4]]?",
                Answers = new string[3] { "-2", "0", "2" },
                RightAnswer = 1
            });

            manager_Mathematics.Quizes_Hard.Add(
            new Quiz
            {
                Question = "If f(x) = x³ - 3x² + 4, what is f'(x)?",
                Answers = new string[3] { "3x² - 6x", "3x² - 6x + 4", "x² - 2x + 4" },
                RightAnswer = 1
            });

            manager_Mathematics.Quizes_Hard.Add(
            new Quiz
            {
                Question = "What is the limit of (sin x) / x as x approaches 0?",
                Answers = new string[3] { "1", "0", "∞" },
                RightAnswer = 1
            });

            manager_Mathematics.Quizes_Hard.Add(
            new Quiz
            {
                Question = "What is the sum of the infinite geometric series: 3 + 3/2 + 3/4 + 3/8 + ...?",
                Answers = new string[3] { "6", "5", "4" },
                RightAnswer = 1
            });

            manager_Mathematics.Quizes_Hard.Add(
            new Quiz
            {
                Question = "What is the value of cos(π/3)?",
                Answers = new string[3] { "1/2", "√3/2", "0" },
                RightAnswer = 1
            });

            manager_Mathematics.Quizes_Hard.Add(
            new Quiz
            {
                Question = "What is the Taylor series expansion of e^x centered at x = 0?",
                Answers = new string[3] { "Σ(x^n/n!)", "Σ(n!x^n)", "Σ(x^n)" },
                RightAnswer = 1
            });

            manager_Mathematics.Quizes_Hard.Add(
            new Quiz
            {
                Question = "What is the probability of rolling a sum of 7 with two six-sided dice?",
                Answers = new string[3] { "1/6", "1/7", "1/8" },
                RightAnswer = 1
            });

            manager_Mathematics.Quizes_Hard.Add(
            new Quiz
            {
                Question = "What is the Laplace transform of 1?",
                Answers = new string[3] { "1/s", "s", "e^s" },
                RightAnswer = 1
            });

            manager_Mathematics.Quizes_Hard.Add(
            new Quiz
            {
                Question = "What is the derivative of ln(x)?",
                Answers = new string[3] { "1/x", "x", "e^x" },
                RightAnswer = 1
            });

            manager_Mathematics.Quizes_Hard.Add(
            new Quiz
            {
                Question = "What is the sum of the first 100 natural numbers?",
                Answers = new string[3] { "5000", "5050", "4950" },
                RightAnswer = 2
            });

            manager_Mathematics.Quizes_Hard.Add(
            new Quiz
            {
                Question = "What is the eigenvalue of the identity matrix?",
                Answers = new string[3] { "1", "0", "It depends on the size" },
                RightAnswer = 1
            });

            manager_Mathematics.Quizes_Hard.Add(
            new Quiz
            {
                Question = "What is the solution to the equation x^2 + x - 6 = 0?",
                Answers = new string[3] { "2 and -3", "-2 and 3", "1 and -6" },
                RightAnswer = 1
            });

            string json = JsonConvert.SerializeObject(manager_Mathematics, Formatting.Indented, settings);
            File.WriteAllText("Math.json", json);*/
            /*
            #endregion

            #region Geografy
            string jsonFromFile = File.ReadAllText("Geografy.json");
            QuizManager manager_Geografy = JsonConvert.DeserializeObject<QuizManager>(jsonFromFile, settings);

            #region add
            //manager_Geografy.Quizes_Easy.Add(
            //new Quiz
            //{
            //    Question = "What is the largest continent by area?",
            //    Answers = new string[3] { "Africa", "Asia", "Europe" },
            //    RightAnswer = 2
            //});

            //manager_Geografy.Quizes_Easy.Add(
            //new Quiz
            //{
            //    Question = "What is the capital of France?",
            //    Answers = new string[3] { "Berlin", "Madrid", "Paris" },
            //    RightAnswer = 3
            //});

            //manager_Geografy.Quizes_Easy.Add(
            //new Quiz
            //{
            //    Question = "Which ocean is the largest?",
            //    Answers = new string[3] { "Atlantic Ocean", "Indian Ocean", "Pacific Ocean" },
            //    RightAnswer = 3
            //});

            //manager_Geografy.Quizes_Easy.Add(
            //new Quiz
            //{
            //    Question = "Which river is the longest in the world?",
            //    Answers = new string[3] { "Amazon", "Nile", "Mississippi" },
            //    RightAnswer = 2
            //});

            //manager_Geografy.Quizes_Easy.Add(
            //new Quiz
            //{
            //    Question = "Which country has the most people?",
            //    Answers = new string[3] { "India", "China", "USA" },
            //    RightAnswer = 2
            //});

            //manager_Geografy.Quizes_Easy.Add(
            //new Quiz
            //{
            //    Question = "What is the smallest country in the world?",
            //    Answers = new string[3] { "Monaco", "Vatican City", "San Marino" },
            //    RightAnswer = 2
            //});

            //manager_Geografy.Quizes_Easy.Add(
            //new Quiz
            //{
            //    Question = "Which desert is the largest in the world?",
            //    Answers = new string[3] { "Sahara", "Gobi", "Antarctic Desert" },
            //    RightAnswer = 3
            //});

            //manager_Geografy.Quizes_Easy.Add(
            //new Quiz
            //{
            //    Question = "Which is the tallest mountain in the world?",
            //    Answers = new string[3] { "Mount Everest", "K2", "Kilimanjaro" },
            //    RightAnswer = 1
            //});

            //manager_Geografy.Quizes_Easy.Add(
            //new Quiz
            //{
            //    Question = "What is the capital of Japan?",
            //    Answers = new string[3] { "Beijing", "Seoul", "Tokyo" },
            //    RightAnswer = 3
            //});

            //manager_Geografy.Quizes_Easy.Add(
            //new Quiz
            //{
            //    Question = "Which country is shaped like a boot?",
            //    Answers = new string[3] { "Italy", "Spain", "Portugal" },
            //    RightAnswer = 1
            //});

            //manager_Geografy.Quizes_Easy.Add(
            //new Quiz
            //{
            //    Question = "What is the longest river in Europe?",
            //    Answers = new string[3] { "Danube", "Volga", "Thames" },
            //    RightAnswer = 2
            //});

            //manager_Geografy.Quizes_Easy.Add(
            //new Quiz
            //{
            //    Question = "Which U.S. state is the largest by area?",
            //    Answers = new string[3] { "Texas", "Alaska", "California" },
            //    RightAnswer = 2
            //});

            //manager_Geografy.Quizes_Easy.Add(
            //new Quiz
            //{
            //    Question = "What is the capital of Australia?",
            //    Answers = new string[3] { "Sydney", "Canberra", "Melbourne" },
            //    RightAnswer = 2
            //});

            //manager_Geografy.Quizes_Easy.Add(
            //new Quiz
            //{
            //    Question = "Which country is known as the Land of the Rising Sun?",
            //    Answers = new string[3] { "Japan", "China", "South Korea" },
            //    RightAnswer = 1
            //});

            //manager_Geografy.Quizes_Easy.Add(
            //new Quiz
            //{
            //    Question = "Which two continents are entirely in the Southern Hemisphere?",
            //    Answers = new string[3] { "South America and Australia", "Africa and Antarctica", "Australia and Antarctica" },
            //    RightAnswer = 3
            //});

            //manager_Geografy.Quizes_Medium.Add(
            //new Quiz
            //{
            //    Question = "Which country has the longest coastline in the world?",
            //    Answers = new string[3] { "russia", "Australia", "Canada" },
            //    RightAnswer = 3
            //});

            //manager_Geografy.Quizes_Medium.Add(
            //new Quiz
            //{
            //    Question = "What is the capital of Brazil?",
            //    Answers = new string[3] { "Rio de Janeiro", "Brasília", "São Paulo" },
            //    RightAnswer = 2
            //});

            //manager_Geografy.Quizes_Medium.Add(
            //new Quiz
            //{
            //    Question = "Which U.S. state has the most active volcanoes?",
            //    Answers = new string[3] { "California", "Alaska", "Hawaii" },
            //    RightAnswer = 2
            //});

            //manager_Geografy.Quizes_Medium.Add(
            //new Quiz
            //{
            //    Question = "What is the name of the largest lake in Africa?",
            //    Answers = new string[3] { "Lake Tanganyika", "Lake Victoria", "Lake Malawi" },
            //    RightAnswer = 2
            //});

            //manager_Geografy.Quizes_Medium.Add(
            //new Quiz
            //{
            //    Question = "Which African country has the most pyramids?",
            //    Answers = new string[3] { "Egypt", "Sudan", "Ethiopia" },
            //    RightAnswer = 2
            //});

            //manager_Geografy.Quizes_Medium.Add(
            //new Quiz
            //{
            //    Question = "What is the deepest ocean trench in the world?",
            //    Answers = new string[3] { "Puerto Rico Trench", "Tonga Trench", "Mariana Trench" },
            //    RightAnswer = 3
            //});

            //manager_Geografy.Quizes_Medium.Add(
            //new Quiz
            //{
            //    Question = "Which country is home to the Atacama Desert?",
            //    Answers = new string[3] { "Peru", "Chile", "Argentina" },
            //    RightAnswer = 2
            //});

            //manager_Geografy.Quizes_Medium.Add(
            //new Quiz
            //{
            //    Question = "Which European country has the most islands?",
            //    Answers = new string[3] { "Norway", "Sweden", "Greece" },
            //    RightAnswer = 2
            //});

            //manager_Geografy.Quizes_Medium.Add(
            //new Quiz
            //{
            //    Question = "Which country has the highest number of time zones?",
            //    Answers = new string[3] { "USA", "France", "russia" },
            //    RightAnswer = 2
            //});

            //manager_Geografy.Quizes_Medium.Add(
            //new Quiz
            //{
            //    Question = "Which river flows through Baghdad?",
            //    Answers = new string[3] { "Tigris", "Euphrates", "Indus" },
            //    RightAnswer = 1
            //});

            //manager_Geografy.Quizes_Medium.Add(
            //new Quiz
            //{
            //    Question = "What is the only continent without an active volcano?",
            //    Answers = new string[3] { "Australia", "Antarctica", "Europe" },
            //    RightAnswer = 1
            //});

            //manager_Geografy.Quizes_Medium.Add(
            //new Quiz
            //{
            //    Question = "Which two continents are connected by the Isthmus of Panama?",
            //    Answers = new string[3] { "North America and South America", "Europe and Asia", "Africa and Asia" },
            //    RightAnswer = 1
            //});

            //manager_Geografy.Quizes_Medium.Add(
            //new Quiz
            //{
            //    Question = "What is the longest mountain range in the world?",
            //    Answers = new string[3] { "Himalayas", "Andes", "Rocky Mountains" },
            //    RightAnswer = 2
            //});

            //manager_Geografy.Quizes_Medium.Add(
            //new Quiz
            //{
            //    Question = "Which country has the most freshwater resources?",
            //    Answers = new string[3] { "russia", "Canada", "Brazil" },
            //    RightAnswer = 3
            //});

            //manager_Geografy.Quizes_Medium.Add(
            //new Quiz
            //{
            //    Question = "What is the name of the sea that separates Europe and Africa?",
            //    Answers = new string[3] { "Mediterranean Sea", "Red Sea", "Black Sea" },
            //    RightAnswer = 1
            //});

            //manager_Geografy.Quizes_Hard.Add(
            //new Quiz
            //{
            //    Question = "Which country has the highest average altitude above sea level?",
            //    Answers = new string[3] { "Nepal", "Tibet (China)", "Bhutan" },
            //    RightAnswer = 3
            //});

            //manager_Geografy.Quizes_Hard.Add(
            //new Quiz
            //{
            //    Question = "Which is the world's oldest active volcano?",
            //    Answers = new string[3] { "Mount Etna", "Kilauea", "Mount Vesuvius" },
            //    RightAnswer = 1
            //});

            //manager_Geografy.Quizes_Hard.Add(
            //new Quiz
            //{
            //    Question = "What is the least populated country in the world?",
            //    Answers = new string[3] { "Vatican City", "Tuvalu", "Nauru" },
            //    RightAnswer = 1
            //});

            //manager_Geografy.Quizes_Hard.Add(
            //new Quiz
            //{
            //    Question = "Which is the driest place on Earth?",
            //    Answers = new string[3] { "Atacama Desert", "McMurdo Dry Valleys", "Sahara Desert" },
            //    RightAnswer = 2
            //});

            //manager_Geografy.Quizes_Hard.Add(
            //new Quiz
            //{
            //    Question = "Which country has the most UNESCO World Heritage Sites?",
            //    Answers = new string[3] { "Italy", "China", "India" },
            //    RightAnswer = 1
            //});

            //manager_Geografy.Quizes_Hard.Add(
            //new Quiz
            //{
            //    Question = "Which ocean current is the strongest in the world?",
            //    Answers = new string[3] { "Gulf Stream", "Antarctic Circumpolar Current", "Kuroshio Current" },
            //    RightAnswer = 2
            //});

            //manager_Geografy.Quizes_Hard.Add(
            //new Quiz
            //{
            //    Question = "What is the largest tectonic plate?",
            //    Answers = new string[3] { "Pacific Plate", "Eurasian Plate", "North American Plate" },
            //    RightAnswer = 1
            //});

            //manager_Geografy.Quizes_Hard.Add(
            //new Quiz
            //{
            //    Question = "Which is the deepest lake in the world?",
            //    Answers = new string[3] { "Lake Tanganyika", "Caspian Sea", "Lake Baikal" },
            //    RightAnswer = 3
            //});

            //manager_Geografy.Quizes_Hard.Add(
            //new Quiz
            //{
            //    Question = "Which river has the largest drainage basin in the world?",
            //    Answers = new string[3] { "Amazon River", "Nile River", "Congo River" },
            //    RightAnswer = 1
            //});

            //manager_Geografy.Quizes_Hard.Add(
            //new Quiz
            //{
            //    Question = "Which is the only sea on Earth with no coastline?",
            //    Answers = new string[3] { "Sargasso Sea", "Aral Sea", "Red Sea" },
            //    RightAnswer = 1
            //});

            //manager_Geografy.Quizes_Hard.Add(
            //new Quiz
            //{
            //    Question = "Which city is the highest capital in the world?",
            //    Answers = new string[3] { "Quito", "La Paz", "Kathmandu" },
            //    RightAnswer = 2
            //});

            //manager_Geografy.Quizes_Hard.Add(
            //new Quiz
            //{
            //    Question = "What is the name of the world's fastest-moving glacier?",
            //    Answers = new string[3] { "Jakobshavn Glacier", "Lambert Glacier", "Pine Island Glacier" },
            //    RightAnswer = 1
            //});

            //manager_Geografy.Quizes_Hard.Add(
            //new Quiz
            //{
            //    Question = "Which continent has the most countries?",
            //    Answers = new string[3] { "Asia", "Europe", "Africa" },
            //    RightAnswer = 3
            //});

            //manager_Geografy.Quizes_Hard.Add(
            //new Quiz
            //{
            //    Question = "What is the world's largest inland delta?",
            //    Answers = new string[3] { "Okavango Delta", "Ganges Delta", "Niger Delta" },
            //    RightAnswer = 1
            //});

            //manager_Geografy.Quizes_Hard.Add(
            //new Quiz
            //{
            //    Question = "Which island country is the most isolated in the world?",
            //    Answers = new string[3] { "Iceland", "New Zealand", "Tristan da Cunha" },
            //    RightAnswer = 3
            //});
            #endregion

            string json = JsonConvert.SerializeObject(manager_Geografy, Formatting.Indented, settings);
            File.WriteAllText("Geografy.json", json);
            #endregion

            #region Biology
            string jsonFromFile1 = File.ReadAllText("Biology.json");

            QuizManager manager_Biology = JsonConvert.DeserializeObject<QuizManager>(jsonFromFile1, settings);

            #region add
            //manager_Biology.Quizes_Easy.Add(
            //new Quiz
            //{
            //    Question = "What is the basic unit of life?",
            //    Answers = new string[3] { "Atom", "Cell", "Molecule" },
            //    RightAnswer = 2
            //});

            //manager_Biology.Quizes_Easy.Add(
            //new Quiz
            //{
            //    Question = "Which organ pumps blood throughout the human body?",
            //    Answers = new string[3] { "Liver", "Lungs", "Heart" },
            //    RightAnswer = 3
            //});

            //manager_Biology.Quizes_Easy.Add(
            //new Quiz
            //{
            //    Question = "What gas do plants absorb from the atmosphere?",
            //    Answers = new string[3] { "Oxygen", "Carbon dioxide", "Nitrogen" },
            //    RightAnswer = 2
            //});

            //manager_Biology.Quizes_Easy.Add(
            //new Quiz
            //{
            //    Question = "Which of these is a mammal?",
            //    Answers = new string[3] { "Frog", "Shark", "Dolphin" },
            //    RightAnswer = 3
            //});

            //manager_Biology.Quizes_Easy.Add(
            //new Quiz
            //{
            //    Question = "What is the process by which green plants make their own food?",
            //    Answers = new string[3] { "Respiration", "Photosynthesis", "Fermentation" },
            //    RightAnswer = 2
            //});

            //manager_Biology.Quizes_Easy.Add(
            //new Quiz
            //{
            //    Question = "Which vitamin is produced when the skin is exposed to sunlight?",
            //    Answers = new string[3] { "Vitamin C", "Vitamin D", "Vitamin B12" },
            //    RightAnswer = 2
            //});

            //manager_Biology.Quizes_Easy.Add(
            //new Quiz
            //{
            //    Question = "What is the powerhouse of the cell?",
            //    Answers = new string[3] { "Nucleus", "Mitochondria", "Ribosome" },
            //    RightAnswer = 2
            //});

            //manager_Biology.Quizes_Easy.Add(
            //new Quiz
            //{
            //    Question = "What do herbivores primarily eat?",
            //    Answers = new string[3] { "Meat", "Plants", "Both plants and meat" },
            //    RightAnswer = 2
            //});

            //manager_Biology.Quizes_Easy.Add(
            //new Quiz
            //{
            //    Question = "Which human organ filters blood and produces urine?",
            //    Answers = new string[3] { "Liver", "Kidney", "Lungs" },
            //    RightAnswer = 2
            //});

            //manager_Biology.Quizes_Easy.Add(
            //new Quiz
            //{
            //    Question = "Which part of the plant absorbs water from the soil?",
            //    Answers = new string[3] { "Leaf", "Stem", "Root" },
            //    RightAnswer = 3
            //});

            //manager_Biology.Quizes_Easy.Add(
            //new Quiz
            //{
            //    Question = "Which animal is known as the king of the jungle?",
            //    Answers = new string[3] { "Tiger", "Lion", "Elephant" },
            //    RightAnswer = 2
            //});

            //manager_Biology.Quizes_Easy.Add(
            //new Quiz
            //{
            //    Question = "Which blood cells help fight infections?",
            //    Answers = new string[3] { "Red blood cells", "White blood cells", "Platelets" },
            //    RightAnswer = 2
            //});

            //manager_Biology.Quizes_Easy.Add(
            //new Quiz
            //{
            //    Question = "Which gas do humans exhale?",
            //    Answers = new string[3] { "Oxygen", "Carbon dioxide", "Nitrogen" },
            //    RightAnswer = 2
            //});

            //manager_Biology.Quizes_Easy.Add(
            //new Quiz
            //{
            //    Question = "Which part of the human body controls all functions?",
            //    Answers = new string[3] { "Heart", "Lungs", "Brain" },
            //    RightAnswer = 3
            //});

            //manager_Biology.Quizes_Easy.Add(
            //new Quiz
            //{
            //    Question = "Which is the largest organ in the human body?",
            //    Answers = new string[3] { "Liver", "Skin", "Lungs" },
            //    RightAnswer = 2
            //});

            //manager_Biology.Quizes_Medium.Add(
            //new Quiz
            //{
            //    Question = "What is the function of hemoglobin in the blood?",
            //    Answers = new string[3] { "Transport oxygen", "Fight infections", "Digest food" },
            //    RightAnswer = 1
            //});

            //manager_Biology.Quizes_Medium.Add(
            //new Quiz
            //{
            //    Question = "Which part of a plant is responsible for photosynthesis?",
            //    Answers = new string[3] { "Roots", "Stem", "Leaves" },
            //    RightAnswer = 3
            //});

            //manager_Biology.Quizes_Medium.Add(
            //new Quiz
            //{
            //    Question = "Which organ in the human body produces insulin?",
            //    Answers = new string[3] { "Liver", "Pancreas", "Kidney" },
            //    RightAnswer = 2
            //});

            //manager_Biology.Quizes_Medium.Add(
            //new Quiz
            //{
            //    Question = "What is the main structural component of a cell membrane?",
            //    Answers = new string[3] { "Proteins", "Lipids", "Carbohydrates" },
            //    RightAnswer = 2
            //});

            //manager_Biology.Quizes_Medium.Add(
            //new Quiz
            //{
            //    Question = "Which scientist is known as the father of modern genetics?",
            //    Answers = new string[3] { "Charles Darwin", "Gregor Mendel", "Louis Pasteur" },
            //    RightAnswer = 2
            //});

            //manager_Biology.Quizes_Medium.Add(
            //new Quiz
            //{
            //    Question = "What type of blood cells help in clotting?",
            //    Answers = new string[3] { "White blood cells", "Red blood cells", "Platelets" },
            //    RightAnswer = 3
            //});

            //manager_Biology.Quizes_Medium.Add(
            //new Quiz
            //{
            //    Question = "What type of biomolecule are enzymes?",
            //    Answers = new string[3] { "Proteins", "Carbohydrates", "Lipids" },
            //    RightAnswer = 1
            //});

            //manager_Biology.Quizes_Medium.Add(
            //new Quiz
            //{
            //    Question = "Which type of muscle is found in the walls of internal organs?",
            //    Answers = new string[3] { "Skeletal", "Smooth", "Cardiac" },
            //    RightAnswer = 2
            //});

            //manager_Biology.Quizes_Medium.Add(
            //new Quiz
            //{
            //    Question = "Which gas is released during photosynthesis?",
            //    Answers = new string[3] { "Oxygen", "Carbon dioxide", "Nitrogen" },
            //    RightAnswer = 1
            //});

            //manager_Biology.Quizes_Medium.Add(
            //new Quiz
            //{
            //    Question = "What is the largest bone in the human body?",
            //    Answers = new string[3] { "Femur", "Humerus", "Tibia" },
            //    RightAnswer = 1
            //});

            //manager_Biology.Quizes_Medium.Add(
            //new Quiz
            //{
            //    Question = "Which part of the human brain is responsible for balance and coordination?",
            //    Answers = new string[3] { "Cerebrum", "Cerebellum", "Medulla oblongata" },
            //    RightAnswer = 2
            //});

            //manager_Biology.Quizes_Medium.Add(
            //new Quiz
            //{
            //    Question = "What is the powerhouse of the cell?",
            //    Answers = new string[3] { "Nucleus", "Mitochondria", "Ribosome" },
            //    RightAnswer = 2
            //});

            //manager_Biology.Quizes_Medium.Add(
            //new Quiz
            //{
            //    Question = "What is the primary function of the large intestine?",
            //    Answers = new string[3] { "Absorb water", "Digest proteins", "Produce bile" },
            //    RightAnswer = 1
            //});

            //manager_Biology.Quizes_Medium.Add(
            //new Quiz
            //{
            //    Question = "Which blood type is known as the universal donor?",
            //    Answers = new string[3] { "A", "O", "AB" },
            //    RightAnswer = 2
            //});

            //manager_Biology.Quizes_Medium.Add(
            //new Quiz
            //{
            //    Question = "Which part of the flower contains pollen?",
            //    Answers = new string[3] { "Stigma", "Anther", "Sepal" },
            //    RightAnswer = 2
            //});

            //manager_Biology.Quizes_Hard.Add(
            //new Quiz
            //{
            //    Question = "Which type of RNA carries amino acids to the ribosome?",
            //    Answers = new string[3] { "mRNA", "tRNA", "rRNA" },
            //    RightAnswer = 2
            //});

            //manager_Biology.Quizes_Hard.Add(
            //new Quiz
            //{
            //    Question = "What is the term for programmed cell death?",
            //    Answers = new string[3] { "Necrosis", "Apoptosis", "Lysis" },
            //    RightAnswer = 2
            //});

            //manager_Biology.Quizes_Hard.Add(
            //new Quiz
            //{
            //    Question = "Which hormone regulates calcium levels in the blood?",
            //    Answers = new string[3] { "Insulin", "Parathyroid hormone", "Glucagon" },
            //    RightAnswer = 2
            //});

            //manager_Biology.Quizes_Hard.Add(
            //new Quiz
            //{
            //    Question = "What is the name of the protein that helps package DNA in the nucleus?",
            //    Answers = new string[3] { "Histone", "Actin", "Collagen" },
            //    RightAnswer = 1
            //});

            //manager_Biology.Quizes_Hard.Add(
            //new Quiz
            //{
            //    Question = "Which part of the nephron is responsible for filtering blood?",
            //    Answers = new string[3] { "Loop of Henle", "Glomerulus", "Collecting duct" },
            //    RightAnswer = 2
            //});

            //manager_Biology.Quizes_Hard.Add(
            //new Quiz
            //{
            //    Question = "Which enzyme is responsible for DNA replication?",
            //    Answers = new string[3] { "DNA polymerase", "RNA polymerase", "Ligase" },
            //    RightAnswer = 1
            //});

            //manager_Biology.Quizes_Hard.Add(
            //new Quiz
            //{
            //    Question = "What is the main function of ribosomes?",
            //    Answers = new string[3] { "DNA replication", "Protein synthesis", "Energy production" },
            //    RightAnswer = 2
            //});

            //manager_Biology.Quizes_Hard.Add(
            //new Quiz
            //{
            //    Question = "What is the primary pigment involved in photosynthesis?",
            //    Answers = new string[3] { "Carotene", "Chlorophyll", "Xanthophyll" },
            //    RightAnswer = 2
            //});

            //manager_Biology.Quizes_Hard.Add(
            //new Quiz
            //{
            //    Question = "Which structure connects muscles to bones?",
            //    Answers = new string[3] { "Ligament", "Tendon", "Cartilage" },
            //    RightAnswer = 2
            //});

            //manager_Biology.Quizes_Hard.Add(
            //new Quiz
            //{
            //    Question = "What is the name of the process by which bacteria exchange genetic material?",
            //    Answers = new string[3] { "Transduction", "Transformation", "Conjugation" },
            //    RightAnswer = 3
            //});

            //manager_Biology.Quizes_Hard.Add(
            //new Quiz
            //{
            //    Question = "Which organelle is responsible for the synthesis of lipids?",
            //    Answers = new string[3] { "Rough ER", "Smooth ER", "Golgi apparatus" },
            //    RightAnswer = 2
            //});

            //manager_Biology.Quizes_Hard.Add(
            //new Quiz
            //{
            //    Question = "What is the name of the bond that holds amino acids together in a protein?",
            //    Answers = new string[3] { "Hydrogen bond", "Peptide bond", "Ionic bond" },
            //    RightAnswer = 2
            //});

            //manager_Biology.Quizes_Hard.Add(
            //new Quiz
            //{
            //    Question = "Which structure in the brain is responsible for regulating homeostasis?",
            //    Answers = new string[3] { "Cerebellum", "Hippocampus", "Hypothalamus" },
            //    RightAnswer = 3
            //});

            //manager_Biology.Quizes_Hard.Add(
            //new Quiz
            //{
            //    Question = "What type of symbiotic relationship benefits one organism while harming the other?",
            //    Answers = new string[3] { "Commensalism", "Parasitism", "Mutualism" },
            //    RightAnswer = 2
            //});

            //manager_Biology.Quizes_Hard.Add(
            //new Quiz
            //{
            //    Question = "Which molecule serves as the primary energy carrier in cells?",
            //    Answers = new string[3] { "ATP", "DNA", "Glucose" },
            //    RightAnswer = 1
            //});
            #endregion

            string json1 = JsonConvert.SerializeObject(manager_Biology, Formatting.Indented, settings);
            File.WriteAllText("Biology.json", json1);
            #endregion

            #region Question

            Quiz quiz = manager_Geografy.Quizes_Easy[1];

            Console.Write($"{quiz}\n\n>>> ");
            int choose = int.Parse(Console.ReadLine());
            if (choose == quiz.RightAnswer)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Correct!");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong!");
                Console.ResetColor();
                Console.WriteLine($"The correct answer is {quiz.RightAnswer}) {quiz.Answers[quiz.RightAnswer - 1]}");
            }
            #endregion
            */
        }
    }
}
