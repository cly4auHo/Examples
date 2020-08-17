using System;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    /// <summary>
    /// Класс для проверка надежности пароля
    /// </summary>
    public class PasswordStrengthCheker
    {
        /// <summary>
        /// Возвращает значение определяющее сложность пароля пользователя.
        /// Максимальное количество балов = 5.
        /// </summary>
        public static int GetPasswordStrength(string password)
        {
            // Проверка пароля на null
            if (string.IsNullOrEmpty(password))
            {
                return 0;
            }

            // Переменная для хранения результата
            int result = 0;

            // +1 балл за длину.
            // Длина пароля более 7 символов, +1 бал
            if (Math.Max(password.Length, 7) > 7)
            {
                result++;
            }

            //+1 балл за наличие символа в нижнем регистре
            if (Regex.Match(password, "[a-z]").Success)
            {
                result++;
            }

            //+1 балл за наличие символа в верхнем регистре
            if (Regex.Match(password, "[A-Z]").Success)
            {
                result++;
            }

            // +1 балл за наличие числа.
            if (Regex.Match(password, "[0-9]").Success)
            {
                result++;
            }

            // +1 балл за наличие специального символа.
            if (Regex.Match(password,
                   "[\\!\\@\\#\\$\\%\\^\\&\\*\\(\\)\\{\\}\\[\\]\\:\\'\\;\\\"\\/\\?\\.\\>\\,\\<\\~\\`\\-\\\\_\\=\\+\\|]").Success)
            {
                result++;
            }

            return result;
        }
    }
}
