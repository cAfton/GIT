using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Helpers
{
    internal class ColorHelper
    {
        public static string ColorRGBToHex(byte colorR, byte colorG, byte colorB)
        {
            string ret = "#";
            List<byte> bytes = new List<byte> { colorR, colorG, colorB };
            bytes.ForEach(elem => ret += (elem.ToString("X").Length == 1 ? "0" + elem.ToString("X") : elem.ToString("X")));
            return ret;
        }
    }
}
