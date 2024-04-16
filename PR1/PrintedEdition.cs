using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR1
{
    public class PrintedEdition
    {
        int averageValue;
        int x;
        double result;
        public void InputFromKeyboard()
        {
            do
            {
                Console.Write("Введите необходимое количество листов для печати: ");
                x = Convert.ToInt32(Console.ReadLine());
                if (x < 0 || x == 0) Console.WriteLine("Некорректное значение! Пожалуйста, ещё раз.");
            }
            while (x < 0 || x == 0);
        }
        public PrintedEdition(int averageValue, int x, double result)
        {
            this.averageValue = averageValue;
            this.x = x;
            this.result = result;
            InputFromKeyboard();
        }

    }
}
