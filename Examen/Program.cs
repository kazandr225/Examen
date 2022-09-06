using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    /// <summary>
    /// Главный класс программы
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Главный метод
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Info.GetInfo(); // вызов метода
      
            Console.WriteLine("Вы хотите выйти? Y/N"); //Диалог с пользователем
            do
            {
                if (Console.ReadKey().Key == ConsoleKey.Y)
                {
                    break;
                }
                
            }
            while (Console.ReadKey().Key != ConsoleKey.N);
            Console.Clear();            
            Console.ReadKey();
        }
        }
}
