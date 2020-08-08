using System;
using System.IO;
using System.Reflection;

namespace _011_Activator
{
    class Program
    {
        static void Main()
        {
            Assembly assembly = null;

            try
            {
                assembly = Assembly.Load("CarLibrary");
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }

            // Создание экземпляра класса MiniVan "на лету"
            // При помощи класса Activator производится позднее связывание.
            // Метод CreateInstance() - предназначен для создания экземпляра типа во время выполнения.
            Type type = assembly.GetType("_010_CarLibrary.MiniVan");

            Console.WriteLine(new string('_', 30) + " Cвойства класса MyClass" + "\n");
            Console.WriteLine("Полное Имя:             {0}", type.FullName);
            Console.WriteLine("Базовый класс:          {0}", type.BaseType);
            Console.WriteLine("Абстрактный:            {0}", type.IsAbstract);
            Console.WriteLine("Это COM объект:         {0}", type.IsCOMObject);
            Console.WriteLine("Запрещено наследование: {0}", type.IsSealed);
            Console.WriteLine("Это class:              {0}", type.IsClass);

            Console.WriteLine(new string('_', 30));

            // MiniVan instance = new MiniVan(); Эквивалентно
            object instance = Activator.CreateInstance(type);

            // Получаем экземпляр класса MethodInfo для метода Acceleration(). 
            MethodInfo methodAcceleration = type.GetMethod("Acceleration");

            // Вызов метода Acceleration().
            // Первый параметр - ссылка на экземпляр для которого будет вызван метод Acceleration
            // Второй параметр - массив аргументов метода Acceleration (в данном случае без параметров - null)
            methodAcceleration.Invoke(instance, null);

            // Получаем экземпляр класса MethodInfo для метода Driver(). 
            MethodInfo methodDriver = type.GetMethod("Driver");

            // Массив параметров для метода Driver("Shumaher", 36). 
            object[] parameters = { "Shumaher", 36 };

            // Вызов метода Driver().
            // Первый параметр - ссылка на экземпляр для которого будет вызван метод Acceleration
            // Второй параметр - массив аргументов метода Acceleration (в данном случае - name:"Shumaher", age:36 )
            methodDriver.Invoke(instance, parameters);

            // Задержка.
            Console.ReadKey();

            //Задержка
            Console.ReadKey();
        }
    }
}
