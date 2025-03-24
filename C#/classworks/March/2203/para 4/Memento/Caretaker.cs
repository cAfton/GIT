using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class Caretaker
    {
        Stack<MementoClass> History = new Stack<MementoClass>();

        public void Undo(TextEditor text)
        {
            text.Restore(History.Pop());
        }

        public void Save(TextEditor text)
        {
            History.Push(text.Save());   
        }
    }
}
