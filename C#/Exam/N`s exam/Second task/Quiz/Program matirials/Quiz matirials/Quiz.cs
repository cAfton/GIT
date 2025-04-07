using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.Program_matirials.Quiz_matirials
{
    public class Quiz
    {
        private string Text;
        private string FirstOption;
        private string SecondOption;
        private string CorrectOption;

        public bool Question()
        {
            Console.WriteLine(Text);

            List<string> options = new List<string> { FirstOption, SecondOption, CorrectOption };

            // Перемішуємо варіанти
            Shufчfle(options);

            // Виводимо варіанти у випадковому порядку
            for (int i = 0; i < options.Count; i++)
            {
                Console.WriteLine($"{i + 1}) {options[i]}");
            }

            int choice = int.Parse( Console.ReadLine() );
            if
        }
    }
}
