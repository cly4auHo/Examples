using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace AssertSamples_.Tests
{
    [TestClass]
    public class CollectionAssertMethods
    {
        static List<string> employees;

        /// <summary>
        /// [ClassInitialize] - Атрибут инициализации класса.
        /// Инициализыция коллекции 
        /// </summary>
        [ClassInitialize]
        public static void InitializeCurrentTest(TestContext testContext)
        {
            employees = new List<string>();

            employees.Add("Ivan");
            employees.Add("Sergey");
            employees.Add("Anton");
            employees.Add("Roman");
        }

        /// <summary>
        /// Проверка, что все элементы коллекции созданы
        /// </summary>
        [TestMethod]
        public void AllItemsAreNotNull()
        {
            // Проверка, что все элементы коллекции созданы
            // 1- й аргумент - Коллекция, в которой выполняется поиск элементов, 
            // имеющих значение NULL.
            // 2-й аргумент - сообщение которое отображается в результатах теста.
            CollectionAssert.AllItemsAreNotNull(employees, "Not null failed");
        }

        /// <summary>
        /// Проверка значений коллекции на уникальность
        /// </summary>
        [TestMethod]
        public void AllItemsAreUnique()
        {
            // Проверка значений коллекции на уникальность
            // 1- й аргумент - Коллекция, в которой выполняется поиск дубликатов элементов.
            // 2-й аргумент - сообщение которое отображается в результатах теста.
            CollectionAssert.AllItemsAreUnique(employees, "Uniqueness failed");
        }

        /// <summary>
        /// Проверка значений указанной коллекции на на равенство
        /// </summary>
        [TestMethod]
        public void AreEqual()
        {
            List<string> employeesTest = new List<string>();

            employeesTest.Add("Sergey");
            employeesTest.Add("Ivan");
            employeesTest.Add("Anton");
            employeesTest.Add("Roman");

            // Проверка каждого элемента на равенство,
            // в данном примере первый элемент из коллекции emploees
            // не совпадает с первым элементом из коллекции emploeesTest. 
            // Тест не пройдет.
            CollectionAssert.AreEqual(employees, employeesTest);
        }

        /// <summary>
        /// Проверяет, содержат ли две коллекции одинаковые элементы, 
        /// и создает исключение,
        /// если в любой из коллекций есть непарные элементы.
        /// </summary>
        [TestMethod]
        public void AreEquivalent()
        {
            List<string> employeesTest = new List<string>();

            employeesTest.Add("Sergey");
            employeesTest.Add("Ivan");
            employeesTest.Add("Anton");
            employeesTest.Add("Roman");

            // Проверка коллекций на наличие одинаковых элементов, порядок которых не важен.
            CollectionAssert.AreEquivalent(employees, employeesTest);
        }

        /// <summary>
        /// Проверяет, является ли коллекция подмножеством другой коллекции, 
        /// и создает исключение,
        /// если любой элемент подмножества не является также элементом 
        /// супермножества.
        /// </summary>
        [TestMethod]
        public void employees_Subset()
        {
            List<string> employees_Subset = new List<string>();

            employees_Subset.Add(employees[2]);

            // Если убрать комментарий - тест не пройдет
            //employees_Subset.Add("Alexander"); 

            // Проверка того, что элементы employees_Subset входят в коллекцию employees.
            CollectionAssert.IsSubsetOf(employees_Subset, employees, "failed!");
        }


    }
}
