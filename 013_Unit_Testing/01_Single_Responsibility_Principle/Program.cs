using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Single Responsibility Principle (Принцип единственной обязанности)
/// Под обязанностью здесь понимается набор функций, которые выполняют единую задачу. 
/// Суть этого принципа заключается в том, что класс должен выполнять одну единственную задачу
/// </summary>
namespace _01_Single_Responsibility_Principle
{
    class Program
    {
        static void Main()
        {
            Report report = new Report();
            report.Text = "Hello Wolrd";
            report.Print();

            /*************************************************/
            IPrinter printer = new ConsolePrinter();
            ReportRefactoring reportRefactoring = new ReportRefactoring();
            reportRefactoring.Text = "Hello Wolrd";
            reportRefactoring.Print(printer);

            Console.ReadKey();
        }
    }

    /// <summary>
    /// Класс - Report 
    /// У него первые три метода относятся к навигации по отчету и представляют 
    /// одно единое функциональное целое. А метод Print, производит печать.
    /// В этом случае мы могли бы вынести функционал печати в отдельный класс,
    /// а потом применить агрегацию:
    /// </summary>
    class Report
    {
        public string Text { get; set; }
        public void GoToFirstPage()
        {
            Console.WriteLine("Переход к первой странице");
        }

        public void GoToLastPage()
        {
            Console.WriteLine("Переход к последней странице");
        }

        public void GoToPage(int pageNumber)
        {
            Console.WriteLine("Переход к странице {0}", pageNumber);
        }

        public void Print()
        {
            Console.WriteLine("Печать отчета");
            Console.WriteLine(Text);
        }
    }

    interface IPrinter
    {
        void Print(string text);
    }

    class ConsolePrinter : IPrinter
    {
        public void Print(string text)
        {
            Console.WriteLine(text);
        }
    }

    /// <summary>
    /// Теперь объект Report получает ссылку на объект IPrinter, 
    /// который используется для печати, и через метод Print выводится содержимое отчета:
    /// </summary>
    class ReportRefactoring
    {
        public string Text { get; set; }

        public void GoToFirstPage()
        {
            Console.WriteLine("Переход к первой странице");
        }

        public void GoToLastPage()
        {
            Console.WriteLine("Переход к последней странице");
        }

        public void GoToPage(int pageNumber)
        {
            Console.WriteLine("Переход к странице {0}", pageNumber);
        }
        public void Print(IPrinter printer)
        {
            printer.Print(this.Text);
        }
    }

    /*Побочным положительным действием является то, что теперь функционал печати инкапсулируется 
     * в одном месте, и мы сможем использовать его повторно для объектов других классов, 
     * а не только Report.*/

    /*
     Нередко принцип единственной обязанности нарушает при смешивании в одном классе 
     функциональности разных уровней. Например, класс производит вычисления и выводит 
     их пользователю, то есть соединяет в себя бизнес-логику и работу с пользовательским интерфейсом.
     Либо класс управляет сохранением/получением данных и выполнением над ними вычислений, 
     что также нежелательно. Класс слеует применять только для одной задачи - либо бизнес-логика, 
     либо вычисления, либо работа с данными.
     Другой распространенный случай - наличие в классе или его методах абсолютно 
     несвязанного между собой функционала.
     */
}
