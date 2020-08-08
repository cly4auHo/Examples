using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _028_StringBuilder
{
    class Program
    {
        static void Main()
        {
            //  Предоставляет изменяемую строку символов. 
            StringBuilder builder = new StringBuilder();

            // Append - Добавляет копию указанной строки к данному экземпляру.
            builder.Append("StringBuilder ").Append("является ").Append("очень ... ");

            // Преобразует значение данного экземпляра в System.String.
            string build1 = builder.ToString();

            //Добавляет копию указанной строки к данному экземпляру
            builder.Append("быстрым");

            // Преобразует значение данного экземпляра в System.String.
            string build2 = builder.ToString();

            Console.WriteLine(build1);

            Console.WriteLine(new string('-',10));

            Console.WriteLine(build2);

            // Задержка.
            Console.ReadKey();
        }
    }
}
