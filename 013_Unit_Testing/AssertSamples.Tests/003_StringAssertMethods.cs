using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.RegularExpressions;

namespace AssertSamples_.Tests
{
    [TestClass]
    public class StringAssertMethods
    {
        /// <summary>
        /// Проверяет, содержит ли указанная строка заданную подстроку
        /// </summary>
        [TestMethod]
        public void StringContainsTest()
        {
            // Проверка на вхождение в строку подстроки
            StringAssert.Contains("Assert samples", "sam");
        }

        /// <summary>
        /// Проверяет, соответствует ли указанная строка регулярному выражению, и создает
        /// исключение, если строка не соответствует регулярному выражению.
        /// </summary>
        [TestMethod]
        public void StringMatchesTest()
        {
            // Проверка с использованием регулярного выражения
            StringAssert.Matches("123", new Regex(@"\d{3}"));
        }

        /// <summary>
        /// Проверяет, начинается ли указанная строка с указанной подстроки, и создает исключение,
        /// если тестовая строка не начинается с подстроки.
        /// </summary>
        [TestMethod]
        public void StringStartsWithTest()
        {
            // Проверка того, что строка начинается с определенного слова
            StringAssert.StartsWith("Hello world", "Hello");
        }

        /// <summary>
        /// Проверяет, заканчивается ли указанная строка заданной подстрокой, и создает исключение,
        /// если тестовая строка не заканчивается заданной подстрокой.
        /// </summary>
        [TestMethod]
        public void StringEndsWithTest()
        {
            // Проверка того, что строка заканчивается определенным словом
            StringAssert.EndsWith("Hello world", "world");
        }
    }
}
