using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace saper
{
    public class ButtonTag
    {
        public Status ButtonStatus {  get; set; }
        public int Number {  get; set; }

        public ButtonTag(Status bs)
        {
            ButtonStatus = bs;
        }
    }
}
