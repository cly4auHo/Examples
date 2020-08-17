using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calc_Library;

/// <summary>
/// Тестирование класс Calc
/// </summary>
namespace Calc_LibraryTest
{
    /// <summary>
    /// TestClass - Атрибут тестового класса.
    /// </summary>
    [TestClass]
    public class CalcTests
    {
        /// <summary>
        /// TestMethod - Атрибут метода теста.
        /// </summary>
        [TestMethod]
        public void Sum_10plus20_30returned()
        {
            // Блок переменных
            // arrange
            double x = 10;
            double y = 20;
            double expected = 30;

            // Блок действий
            // act
            double actual = Calc.Sum(x, y);

            // Проверка результата
            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
