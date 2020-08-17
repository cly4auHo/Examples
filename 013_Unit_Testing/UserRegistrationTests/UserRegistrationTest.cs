using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistration;

namespace UserRegistrationTests
{
    [TestClass]
    public class PasswordStrengthChekerTests
    {
        /// <summary>
        /// Первый тестовый метод 
        /// Проверяем максимальное количество баллов за пароль
        /// </summary>
        [TestMethod]
        public void TestMethod1()
        {
            // Блок переменных (arrange)
            // Тестовый пароль
            string password = "P2ssw0rd#";
            // Максимальная оценка
            int expected = 5;

            // Блок действий (act)
            // Получаем, к-лво балов за пароль
            int actual = PasswordStrengthCheker.GetPasswordStrength(password);

            // Проверка результата (assert)
            // Проверяет указанные значения на равенство
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Проверка на верхний регистр, длину строки и на нижний регистр
        /// </summary>
        [TestMethod]
        public void GetPasswordStrength_UpperCase_3Points()
        {
            // Блок переменных (arrange)
            string password = "Password";
            
            // Ожыдаемое значение 3, так как, 
            // верхний регистр 1, за длину строки 1, за нижний регистр 1
            int expected = 3;

            // Блок действий (act)
            // Получаем, к-лво балов за пароль
            int actual = PasswordStrengthCheker.GetPasswordStrength(password);

            // Проверка результата (assert)
            // Проверяет указанные значения на равенство
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Проверка на верхний регистр, длину строки, 
        /// на нижний регистр и на число
        /// </summary>
        [TestMethod]
        public void GetPasswordStrength_ConteinsNumber_0_4Points()
        {
            // Блок переменных (arrange)
            string password = "Passw0rd";

            // Ожыдаемое значение 3, так как, 
            // верхний регистр 1, за длину строки 1, за нижний регистр 1
            // число 1
            int expected = 4;

            // Блок действий (act)
            int actual = PasswordStrengthCheker.GetPasswordStrength(password);

            // Проверка результата(assert)
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Проверка на верхний регистр, на длину строки, за нижний регистр 1
        /// </summary>
        [TestMethod]
        public void GetPasswordStrength_ConteinsNumber_1_4Points()
        {
            // Блок переменных (arrange)
            string password = "Passw1rd";

            // Ожыдаемое значение 4, 
            // верхний регистр 1, за длину строки 1, за нижний регистр 1
            // число 1
            int expected = 4;

            // Блок действий (act)
            int actual = PasswordStrengthCheker.GetPasswordStrength(password);

            // Проверка результата(assert)
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Тесты на специальные символы (Tests for special chars)
        /// Символ @
        /// </summary>
        [TestMethod]
        public void GetPasswordStrength_ContainsSpecialChar_at_5Points()
        {
            // Блок переменных (arrange)
            string password = "Passw0rd@";

            // Ожыдаемое значение 5, 
            // верхний регистр 1, за длину строки 1, за нижний регистр 1
            // число 1, специальный символ 1
            int expected = 5;

            // Act
            int actual = PasswordStrengthCheker.GetPasswordStrength(password);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Тесты на специальные символы (Tests for special chars)
        /// Символ #
        /// </summary>
        [TestMethod]
        public void GetPasswordStrength_ContainsSpecialChar_Hash_5Points()
        {
            // Arrange
            string password = "Passw0rd#";

            // верхний регистр 1, за длину строки 1, за нижний регистр 1
            // число 1, специальный символ 1
            int expected = 5;

            // Act
            int actual = PasswordStrengthCheker.GetPasswordStrength(password);

            // Assert

            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Тесты на специальные символы (Tests for special chars)
        /// Символ !
        /// </summary>
        [TestMethod]
        public void GetPasswordStrength_ContainsSpecialChar_Excl_5Points()
        {
            // Arrange
            string password = "Passw0rd!";

            // верхний регистр 1, за длину строки 1, за нижний регистр 1
            // число 1, специальный символ 1
            int expected = 5;

            // Act
            int actual = PasswordStrengthCheker.GetPasswordStrength(password);

            // Assert

            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Тесты на специальные символы (Tests for special chars)
        /// Символ $
        /// </summary>
        [TestMethod]
        public void GetPasswordStrength_ContainsSpecialChar_Doll_5Points()
        {
            // Arrange
            string password = "Passw0rd$";

            // верхний регистр 1, за длину строки 1, за нижний регистр 1
            // число 1, специальный символ 1
            int expected = 5;

            // Act
            int actual = PasswordStrengthCheker.GetPasswordStrength(password);

            // Assert

            Assert.AreEqual(expected, actual);
        }
    }
}
