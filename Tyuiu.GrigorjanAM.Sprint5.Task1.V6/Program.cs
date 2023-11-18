using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GrigorjanAM.Sprint5.Task1.V6.Lib;
using System.IO;

namespace Tyuiu.GrigorjanAM.Sprint5.Task1.V6
{
    class Program
    {
        static void Main(string[] args)
        {

            int startvalue = -5;
            int stopvalue = 5;
            DataService ds = new DataService();


            Console.Title = "Спринт #5 | Выполнил: Григорян А. М. | ИИПб-23-3";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись данных в текстовый файл                        *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #6                                                              *");
            Console.WriteLine("* Выполнил: Григорян Арсен Мовсесович | ИИПб-23-3                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана функция, вычислить её значения на [-5;5] (произвести табулирование)*");
            Console.WriteLine("* округлить до двух значений, результат сохранить в текстовый файл.       *");
            Console.WriteLine(" F(x) = cos(x) + 4x/2 - sin(x) * 3x.                                      *");

            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("startvalue = " + startvalue);
            Console.WriteLine("stopvalue = " + stopvalue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            string res = ds.SaveToFileTextData(startvalue, stopvalue);
            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");

            Console.ReadKey();
        }
    }
}
