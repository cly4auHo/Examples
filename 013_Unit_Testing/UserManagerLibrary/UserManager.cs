using System;

namespace UserManagerLibrary
{
    public class UserManager
    {
        /// <summary>
        /// Метод для добавления нового пользователя
        /// </summary>
        public bool Add(string userId, string phone, string email)
        {
            //Проверка на длину userId
            if (userId.Length < 4)
            {
                throw new Exception("UserId должен быть больше 4 символов");
            }

            //Проверка телефона
            if (phone.Contains("a"))
            {
                throw new Exception("Телефон должен содержать только цифры");
            }

            //Проверка email
            if (!email.Contains("@"))
            {
                throw new Exception("Ошибка в email адресе");
            }

            // Логика сохранения данных 

            return true;
        }
    }
}
