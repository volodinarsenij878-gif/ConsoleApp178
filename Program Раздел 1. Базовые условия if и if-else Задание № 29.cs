using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program29
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Свободное место на диске (ГБ): ");
            if (double.TryParse(Console.ReadLine(), out double space))
            {
                if (space < 5)
                    Console.WriteLine("Предупреждение: мало места!");
                else
                    Console.WriteLine("Места достаточно.");
            }
            else
            {
                Console.WriteLine("Ошибка ввода.");
            }
        }
    }
}