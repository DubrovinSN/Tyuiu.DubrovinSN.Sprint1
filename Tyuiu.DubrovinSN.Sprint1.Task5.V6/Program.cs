using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.DubrovinSN.Sprint1.Task5.V6.Lib;

namespace Tyuiu.DubrovinSN.Sprint1.Task5.V6
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Дубровин С.Н | ИИПб-23-3";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы С#                                          *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #6                                                              *");
            Console.WriteLine("* Выполнил: Дубровин Степан Николаевич | ИИПб-23-3                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая решает следующую задачу                    ,*");
            Console.WriteLine("* Пусть k – целое от 1 до 365                                            ,*");
            Console.WriteLine("* Присвоить целой переменной n значение 1,2,...,7                         *");
            Console.WriteLine("* в зависимости от того, на какой день недели (понедельник, вторник,...)  *");
            Console.WriteLine("* приходится k-й день невисокосного года, в котором 1 января–понедельник. * ");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int k;
            Console.WriteLine("Введите число 1 до 365:");
            k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Результат                                                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("День недели 1-7 будет равен " + ds.Calculate(k));
            Console.ReadLine();
        }
    }
}
