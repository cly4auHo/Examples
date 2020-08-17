using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoppingCartLibrary;

namespace ShopingCartLibrary.Tests
{
    [TestClass]
    public class UnitTest1
    {
        private ShoppingCart cart;
        private Item item;

        /// <summary>
        /// Запускается перед стартом каждого тестирующего метода
        /// TestInitialize - Атрибут инициализации теста.
        /// </summary>
        [TestInitialize]
        public void TestInitialize()
        {
            // Debug - Записывает сообщение, заканчивающееся ограничителем строки
            Debug.WriteLine("Test Initialize");
            item = new Item();
            item.Name = "Unit Test Video Lessons";
            item.Quantity = 10;

            cart = new ShoppingCart();
            cart.Add(item);
        }

        /// <summary>
        /// Запускается после завершения каждого тестирующего метода
        /// TestCleanup - Атрибут очистки теста.
        /// </summary>
        [TestCleanup]
        public void TestCleanUp()
        {
            Debug.WriteLine("Test CleanUp");
            cart.Dispose();
        }

        /// <summary>
        /// Проверяет наличие элемента в коллекции
        /// </summary>
        [TestMethod]
        public void ShopingCart_CheckOut_ContainsItem()
        {
            // Contains - Проверяет, содержит ли заданная коллекция указанный 
            // элемент, и создает исключение, если элемент не входит в коллекцию.
            CollectionAssert.Contains(cart.Items, item);
        }

        /// <summary>
        /// Метод для проверки на удаление элемнтов 
        /// </summary>
        [TestMethod]
        public void ShopingCart_RemoveItem_Empty()
        {
            //Ожидаемое значение 
            int expected = 0;

            // Удалаяем элемент
            cart.Remove(0);

            // Проверка
            Assert.AreEqual(expected, cart.Count);
        }
    }
}
