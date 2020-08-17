using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AssertSamples;

namespace AssertSamples_.Tests
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Проверка на квадратный корень с Сообщением
        /// </summary>
        [TestMethod]
        public void IsSqrtTest()
        {
            // Блок переменных (arrange)
            const double input = 4;
            const double expected = 2;

            // Блок действий (act)
            double actual = MyClass.GetSqrt(input);

            // Проверка результата (assert)
            // Перегрузка AreEqual
            // Первый аргумент - Это — ожидаемое тестом значение.
            // Второй аргумент - Это — значение, созданное тестируемым кодом.
            // Третий аргумент -  Сообщение отображается в результатах тестирования
            Assert.AreEqual(expected, actual, "Sqrt of {0} should have been {1}!", input, expected);
        }

        /// <summary>
        /// Проверка значений на равенство с учетом погрешности delta
        /// </summary>
        [TestMethod]
        public void DeltaTest()
        {
            const double expected = 3.1;
            const double delta = 0.07;

            // 3.1622776601683795
            // 0.062..
            double actual = MyClass.GetSqrt(10);

            // Проверка результата (assert)
            // Перегрузка AreEqual
            // Первый аргумент - Это — ожидаемое тестом значение.
            // Второй аргумент - Это — значение, созданное тестируемым кодом.
            // Третий аргумент -  Сообщение отображается в результатах тестирования
            Assert.AreEqual(expected, actual, delta, "fail message!!!"); 
        }

        /// <summary>
        /// Проверка с учетом игнорировая ргистра 
        /// </summary>
        [TestMethod]
        public void StringAreEqualTest()
        {
            // arrange
            const string input = "HELLO";
            const string expected = "hello";

            // act and assert
            // третий параметр - игнорирование регистра
            Assert.AreEqual(expected, input, true);
        }

        /// <summary>
        /// Проверака равенства ссылок
        /// </summary>
        [TestMethod]
        public void StringSameTest()
        {
            string a = "Hello";
            string b = "Hello";

            // проверка равенства ссылок
            Assert.AreSame(a, b);
        }

        /// <summary>
        /// Проверка равенства ссылок
        /// </summary>
        [TestMethod]
        public void IntegersSameTest()
        {
            //Значиміе типы
            int i = 10;
            int j = 10;

            // проверка равенства ссылок
            Assert.AreSame(i, j);
        }
    }
}
