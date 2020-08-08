using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// Для каждого года рождения из Consumer (Потребителя) определить страну, в которой было 
/// произведено максимальное количество товаров, приобретенных потребителями этого года рождения 
/// (вначале выводится год, затем название страны, затем максимальное количество покупок). 
/// Если для некоторой пары «год–страна» отсутствует информация о проданных товарах, 
/// то эта пара не обрабатывается (в частности, если потребители некоторого года рождения не 
/// сделали ни одной покупки, то информация об этом годе не выводится). Если для какого-либо 
/// года рождения имеется несколько стран с наибольшим числом приобретенных товаров, 
/// о выводятся данные о первой из таких стран (в алфавитном порядке). Сведения о каждом годе
/// выводить на новой строке и упорядочивать по убыванию номера года.
/// </summary>
namespace _006_PracticeSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Consumer> consumersList = new List<Consumer>()
            {
                new Consumer(){ BirthYear = 1992, CodeConsumer = 1,  Street = "Flower street"},
                new Consumer(){ BirthYear = 1993, CodeConsumer = 2,  Street = "Garden street"},
                new Consumer(){ BirthYear = 1992, CodeConsumer = 3,  Street = "Science street "}
            };

            List<Product> productsList = new List<Product>()
            {
                new Product(){Category = "Products", ManufactureCountry = "China", ProductArticle = 1}
            };

            List<Store> storesList = new List<Store>()
            {
                new Store(){CodeConsumer =1, ProductArticle =1, StoreName = "Silpo"},
                new Store(){CodeConsumer =1, ProductArticle =1, StoreName = "Silpo"}
            };

            var result = from storesRow in storesList
                         join consumersRow in consumersList on storesRow.CodeConsumer equals consumersRow.CodeConsumer
                         join productsrow in productsList on storesRow.ProductArticle equals productsrow.ProductArticle
                         select new { BirthYear = consumersRow.BirthYear};

            
            var resultGroup = from row in result
                              group row by row.BirthYear;
            
            Console.ReadLine();
        }
    }

    /// <summary>
    /// Потребитель
    /// </summary>
    class Consumer
    {
        /// <summary>
        /// Код потребителя 
        /// </summary>
        public int CodeConsumer { get; set; }

        /// <summary>
        /// Улица проживания
        /// </summary>
        public string Street { get; set; }

        /// <summary>
        /// Год рождения 
        /// </summary>
        public int BirthYear { get; set; }
    }

    /// <summary>
    /// Товар 
    /// </summary>
    class Product
    {
        /// <summary>
        /// Страна-производитель
        /// </summary>
        public string ManufactureCountry { get; set; }

        /// <summary>
        /// Категория
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// <Артикул товара
        /// </summary>
        public int ProductArticle { get; set; }
    }

    /// <summary>
    /// Магазин
    /// </summary>
    class Store
    {
        /// <summary>
        /// <Артикул товара
        /// </summary>
        public int ProductArticle { get; set; }

        /// <summary>
        /// Код потрибителя 
        /// </summary>
        public int CodeConsumer { get; set; }

        /// <summary>
        /// Назавание магазина 
        /// </summary>
        public string StoreName { get; set; }
    }


}
