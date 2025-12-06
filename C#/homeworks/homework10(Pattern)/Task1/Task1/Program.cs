using Task1.Main_class;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AppConfig appConfig = AppConfig.Instance;
            appConfig.SetSetting("Theme", "Dark");
            appConfig.SetSetting("Language", "English");

            Console.WriteLine(appConfig.GetSetting("Theme")); // Dark
            Console.WriteLine(appConfig.GetSetting("Language")); // English
        }
    }
}
