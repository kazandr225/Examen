using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace Examen
{
    /// <summary>
    /// Класс с информацией, здесь производятся расчеты
    /// </summary>
    internal class Info
    {


        public static string[] articleNumber = new string[100]; // артикул присваевается, если вклад превышает 700 тыс. удельных единиц (А>=700 тыс у.е.; B<700 тыс у.е.)
        public static double[] N = new double[100]; // количество у.е., которые пользователь положил в банк
        
        public static double[] M = new double[100]; // проценты годовых
        public static double[] Y = new double[100]; // количество лет

        public static double Mmin = 1; // минимальная процентная ставка
        public static double Mmax = 5; // максимальная процентная вставка

        public static int Numbers = 0; //Число вкладов
        /// <summary>
        /// Метод получения данных из файла
        /// </summary>
        /// <returns></returns>
        static public bool GetInfo()
        {


            string path = "data.txt";
            string[] file = File.ReadAllLines(path); // Обращение к исходному файлу
            for (int i = 0; i < file.Length; i++)
            {
                Console.WriteLine(file[i]);
            }

            Console.WriteLine("Данные вкладам:\n");
            
            Debug.WriteLine("Программа завершила вывод");

            Trace.Listeners.Add(new TextWriterTraceListener("TraceLog.txt")); // Создание слушателя
            Trace.WriteLine("Програмы произвела вывод");
            Trace.Flush();


            for (int i = 0; i < file.Length; i++)
            {

                string[] par = file[i].Split(';');
                articleNumber[Numbers] = par[0];
                N[Numbers] = Convert.ToDouble(par[1]);
                M[Numbers] = Convert.ToDouble(par[2]);
                Y[Numbers] = Convert.ToDouble(par[3]);
                
                Numbers++;

                Console.WriteLine("Артиул:" + articleNumber[i] + "Количество вложенных у.е. :" + N[i] + "Проценты годовых:" + M[i] + "Количество лет:" + Y[i]);

            }
            
            
            Console.WriteLine();


       
            return true;
        }



    }
}
