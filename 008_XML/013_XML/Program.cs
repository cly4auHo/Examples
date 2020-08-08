using System;
using System.Xml.XPath;

/// <summary>
/// Вычисление выражений с помощью XPath. (Пример: Вычисление суммы элементов)
/// </summary>
namespace _013_XML
{
    class Program
    {
        static void Main()
        {
            double sum = 0;

            // Создание XPath документа.
            XPathDocument document = new XPathDocument("Books.xml");
            XPathNavigator navigator = document.CreateNavigator();

            // Вычисляющий запрос с предварительной компиляцией.
            XPathExpression expression = navigator.Compile("sum(ListOfBooks/Book/Price/text())");

            Console.WriteLine(expression.ReturnType);

            if (expression.ReturnType == XPathResultType.Number)
            {
                sum = (double)navigator.Evaluate(expression);
                Console.WriteLine(sum);
            }

            // Вычисляющий запрос без предварительной компиляции.
            // Кроме выборки производится арифметическое вычисление.
            sum = (double)navigator.Evaluate("sum(//Price/text())*10");
            Console.WriteLine(sum);

            // Задержка.
            Console.ReadKey();
        }
    }
}
