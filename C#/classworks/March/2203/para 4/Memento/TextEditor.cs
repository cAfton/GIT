using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class TextEditor
    {
        public string Text { get; set; }
        public MementoClass Save()
        {
            return new MementoClass() {state = Text };
        }

        public void Restore(MementoClass memento) {
            Text = memento.state;
        }
    }
}
