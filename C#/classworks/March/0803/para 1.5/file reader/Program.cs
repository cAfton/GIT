namespace file_reader
{

    public class FileHandler : IDisposable
    {

        private StreamReader Reader;

        private StreamWriter Writer;

        public FileHandler(string filePathToRead, string filePathToWrite)
        {
            Reader = new StreamReader(filePathToRead);
            Writer = new StreamWriter(filePathToWrite);
        }

        public string ReadFromFile()
        {
            string currentText = Reader.ReadToEnd();
            return currentText;
        }

        public void WrightTOFile(string textToWright)
        {
            Writer.Write(textToWright);
            Writer.Flush();
            Console.WriteLine("Text wrote");
        }



        public void Dispose()
        {
            Reader.Dispose();
            Writer.Flush();
            Writer.Dispose();
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            string filePathToRead = "TextFile1.txt";
            string filePathToWrite = "TextFile2.txt";

            using (FileHandler FileMeneger = new FileHandler(filePathToRead, filePathToWrite))
            {
                string text = FileMeneger.ReadFromFile();
                int N = text
                    .Where(item=>char.IsLetter(item))
                    .Count();
                Console.WriteLine(N);
                FileMeneger.WrightTOFile(N.ToString());
            }
        }
    }
}
