using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Servises
{
    public class Logger : IDisposable
    {
        private static Logger instance;
        private StreamWriter streamWriter = new StreamWriter("log.log");
        private Logger() 
        { 

        }

        public void CreateLog(string Text)
        {
            streamWriter.WriteLine($"{DateTime.Now} {Text}");
        }

        public void Dispose()
        {
            streamWriter.Close();
        }

        public static Logger Instance 
        {
            get
            {
                if (instance == null)
                {
                    instance = new Logger();
                }
                return instance;
            }
        }
    }
}
