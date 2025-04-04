using System.Text;
using System.Text.RegularExpressions;
using System.Security.Cryptography;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace TaskV
{
    public enum Job_Work
    {
        Programmer,
        Doctor,
        Teacher,
        Engineer,
        Lawyer,
        Designer,
        Manager,
        Pilot,
        Farmer
    }
    [Serializable]
    public class Registration_Form
    {
        private string name;
        public string Name { get { return name; } set {
                if (Regex.IsMatch(value, @"^[A-Z][a-z]+$"))
                {
                    name = value;
                }
                else
                {
                    name = "No_Name";
                    throw new ArgumentException();
                }
            } }

        private string surname;
        public string Surname { get { return surname; } set {
                if (Regex.IsMatch(value, @"^[A-Z][a-z]+$"))
                {
                    surname = value;
                }
                else
                {
                    surname = "No_Surname";
                    throw new ArgumentException();
                }
            } }

        private int age;
        public int Age { get { return age; } set {
                if (Regex.IsMatch(value.ToString(), @"^[1-9]\d{0,2}$"))
                {
                    age = value;
                }
                else
                {
                    age = 0;
                    throw new ArgumentException();
                }
            } }

        private string email;
        public string Email { get { return email; } set {
                if (Regex.IsMatch(value, @"^[\w\.]+@[a-z]+\.[a-z]+$"))
                {
                    email = value;
                }
                else
                {
                    email = "No_Email";
                    throw new ArgumentException();
                }
            } }

        private string address;
        public string Address { get { return address; } set {
                if (Regex.IsMatch(value, @"^(Str\.|Pl\.|Sq\.)\s[A-Z][a-z]+\,\s[1-9]\d*[A-Z]?$"))
                {
                    address = value;
                }
                else
                {
                    address = "No_Address";
                    throw new ArgumentException();
                }
            } }

        private string index;
        public string Index { get { return index; } set {
                if (Regex.IsMatch(value, @"^\d{5}$"))
                {
                    index = value;
                }
                else
                {
                    index = "No_Index";
                    throw new ArgumentException();
                }
            } }

        private string phonenum;
        public string PhoneNumber { get { return phonenum; } set {
                if (Regex.IsMatch(value, @"^\+\d{12}$"))
                {
                    phonenum = value;
                }
                else
                {
                    phonenum = "No_Phone_Number";
                    throw new ArgumentException();
                }
            } }
        [JsonConverter(typeof(StringEnumConverter))]
        public Job_Work Job { get; set; }

        private string pass;

        [JsonIgnore]
        public string Password { get { return pass; } set {
                if (Regex.IsMatch(value, @"^.{8,}"))
                pass = ComputeSha256Hash(value);
            } }

        private string ComputeSha256Hash(string rawData)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                    builder.Append(b.ToString("x2"));
                return builder.ToString();
            }
        }

        public override string ToString()
        {
            return $"Name: {Name}\n" +
                $"Surname: {Surname}\n" +
                $"Age: {Age}\n" +
                $"Email: {Email}\n" +
                $"Address: {Address}\n" +
                $"Index: {Index}\n" +
                $"Phone number: {PhoneNumber}\n" +
                $"Job: {Job}\n" +
                $"Password: {Password}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Registration_Form form1 = new Registration_Form();
            Console.WriteLine("Input your name: ");
            try
            {
                form1.Name = Console.ReadLine();
            }
            catch(ArgumentException)
            {
                Console.WriteLine("Inputed name is incorrect. Set name: No_Name");
            }


            Console.WriteLine("Input your surname: ");
            try
            {
                form1.Surname = Console.ReadLine();
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Inputed surname is incorrect. Set surname: No_Surname");
            }


            Console.WriteLine("Input your age: ");
            try
            {
                form1.Age = int.Parse(Console.ReadLine());
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Inputed age is incorrect. Set age: 0");
            }


            Console.WriteLine("Input your email: ");
            try
            {
                form1.Email = Console.ReadLine();
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Inputed email is incorrect. Set email: No_Email");
            }


            Console.WriteLine("Input address: ");
            try
            {
                form1.Address = Console.ReadLine();
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Inputed address is incorrect. Set address: No_Address");
            }


            Console.WriteLine("Input index: ");
            try
            {
                form1.Index = Console.ReadLine();
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Inputed index is incorrect. Set index: No_Index");
            }


            Console.WriteLine("Input your phone number: (please start with + and your country's code) ");
            try
            {
                form1.PhoneNumber = Console.ReadLine();
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Inputed phone number is incorrect. Set phone number: No_Phone_Number");
            }


            Console.WriteLine("        1. Programmer\r\n        2. Doctor\r\n        3. Teacher\r\n        4. Engineer\r\n        5. Lawyer\r\n" +
                              "        6. Designer\r\n        7. Manager\r\n        8. Pilot\r\n        9. Farmer");
            switch (Console.ReadLine())
            {
                case "1":
                    form1.Job = Job_Work.Programmer;
                    break;
                case "2":
                    form1.Job = Job_Work.Doctor;
                    break;
                case "3":
                    form1.Job = Job_Work.Teacher;
                    break;
                case "4":
                    form1.Job = Job_Work.Engineer;
                    break;
                case "5":
                    form1.Job = Job_Work.Lawyer;
                    break;
                case "6":
                    form1.Job = Job_Work.Designer;
                    break;
                case "7":
                    form1.Job = Job_Work.Manager;
                    break;
                case "8":
                    form1.Job = Job_Work.Pilot;
                    break;
                case "9":
                    form1.Job = Job_Work.Farmer;
                    break;
                default:
                    Console.WriteLine("Inputed job is incorrect. Set job: Programmer");
                    break;
            }

            Console.WriteLine("Input password");
            form1.Password = Console.ReadLine();

            Console.WriteLine(form1);
            using (StreamWriter File = new StreamWriter("fileWithUserJSON.json"))
            {
                JsonSerializer.Create().Serialize(File, form1);
            }
        }
    }
}
