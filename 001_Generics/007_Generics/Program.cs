using System;

/// <summary>
/// Обобщение
/// Обобщение в методах
/// </summary>
namespace _007_Generics
{
    class Program
    {
        static void Main()
        {
            //Cоздаем екземпляр класс с именем  myClass, параметризированный 
            //двумя Указателями Места Заполнения Типом - Т и R,
            MyClass<string, int> myClass = new MyClass<string, int>(10);

            //Переменной присваеваем значение взвращаемое методом SomeMethod
            int x = myClass.SomeMethod("Method");

            //Выводим на консоль значение переменной x
            Console.WriteLine("Возвращаемое методом значение = {0}", x);
            
            //Задержка
            Console.ReadKey();
        }
    }

    /// <summary>
    /// Класс MyClass
    /// </summary>
    class MyClass<T, R>
    {
        //Объявление переменной типа R
        R field;

        /// <summary>
        /// Конструктор класса, у этого конструктора имеется параметр типа R
        /// </summary>
        public MyClass(R fieldValue)
        {
            //Инициализация поля типа R
            this.field = fieldValue;
        }

        /// <summary>
        /// Метод который возвращает значение типа R
        /// </summary>
        public R SomeMethod(T argument)
        {
            Console.WriteLine("Значение передаваемое аргументом в метод = {0}", argument);
            Console.WriteLine(argument.GetType());

            Console.WriteLine(new string('-',10));

            Console.WriteLine(field.GetType());
            
            return field;
        }
    }
}
