using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoppingCartLibrary;
using System.Diagnostics;

namespace ShopingCartLibrary.Tests
{
    [TestClass]
    public class ClassInitAndCleanup
    {
        private static ShoppingCart cart;

        /// <summary>
        /// [ClassInitialize] - Запускается перед стартом первого тестирующего метода 
        /// (один раз для класса) Метод должен быть открытым, статическим и принимать 
        /// параметр типа TestContext
        /// </summary>
        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            Debug.WriteLine("Class Initialize");
            Item item = new Item();
            item.Name = "Unit Test Video Lessons";
            item.Quantity = 10;

            cart = new ShoppingCart();
            cart.Add(item);
        }

        /// <summary>
        /// [ClassCleanup] - Запускается после завершения последнего тестирующего 
        /// метода (один раз для класса) Метод должен быть открытым статическим и 
        /// возвращать void
        /// </summary>
        [ClassCleanup]
        public static void TestCleanUp()
        {
            Debug.WriteLine("Class CleanUp");
            // Очистки ресурсов
            cart.Dispose();
        }

        /// <summary>
        /// Метод для проверки добавления элементов в коллекцию
        /// </summary>
        [TestMethod]
        public void ShopingCart_AddToCart()
        {
            // Ожыдаемое значение
            int expected = cart.Items.Count + 1;

            // Добавляем элемент 
            cart.Add(new Item() { Name = "Test", Quantity = 1 });

            // Сверка
            Assert.AreEqual(expected, cart.Count);
        }

        /// <summary>
        /// Метод для проверки удаления элементов из коллекциии
        /// </summary>
        [TestMethod]
        public void ShopingCart_RemoveFromCart()
        {
            // Ожыдаемое значение
            int expected = cart.Items.Count - 1;

            // Удаляем знчение 
            cart.Remove(0);

            // Сверка
            Assert.AreEqual(expected, cart.Count);
        }
    }
}
