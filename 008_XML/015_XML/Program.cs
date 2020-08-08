using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

/// <summary>
/// Выборка элементов в LINQ to XML
/// </summary>
namespace _015_XML
{
    class Program
    {
        static void Main()
        {
            // XDocument - Представляет XML-документ
            XDocument document = XDocument.Load("Books.xml");

            //переберем элементы и выведем их значения на консоль:
            foreach (XElement Element in document.Element("ListOfBooks").Elements("Book"))
            {
                XElement titleElement = Element.Element("Title");
                XElement priceElement = Element.Element("Price");

                Console.WriteLine(string.Format(@"Заголовок {0}", titleElement.Value));
                Console.WriteLine(string.Format(@"Заголовок {0}", priceElement.Value));

                Console.WriteLine(Environment.NewLine);
            }

            Console.WriteLine(new string('-',30));

            // Сочетая операторы Linq и LINQ to XML можно довольно просто извлечь из документа данные 
            // и затем обработать их. 
            // Создадим на основании данных в xml объекты этого класса:
            IEnumerable<Book> bookList = from row in document.Element("ListOfBooks").Elements("Book")
                                      select new Book
                                      {
                                          Title = row.Element("Title").Value,
                                          Price = row.Element("Price").Value
                                      };

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("В коллекции всего {0} элементов", bookList.Count());
            Console.WriteLine(new string('-', 30));
            Console.WriteLine(Environment.NewLine);

            //Перебор элементов коллекции 
            foreach (Book book in bookList)
            {
                Console.WriteLine("Книга {0} - цена {1}", book.Title, book.Price);
            }

            //задержка
            Console.ReadKey();
        }
    }

    /// <summary>
    /// Класс для представления книги
    /// </summary>
    class Book
    {
        /// <summary>
        /// Заголовок
        /// </summary>
        public string Title { get; set; }
        
        /// <summary>
        /// Стоимость
        /// </summary>
        public string Price { get; set; }
    }
}
