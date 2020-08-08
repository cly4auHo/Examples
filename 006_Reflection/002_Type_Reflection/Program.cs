using System;
using System.Reflection;

namespace _002_Type_Reflection
{
    class Program
    {
        static void Main()
        {
            MyClass myClass = new MyClass();
            
            Type myType = myClass.GetType();

            // Получение информации о MyClass.
            Console.WriteLine("Полное Имя:             {0}", myType.FullName);
            Console.WriteLine("Базовый класс:          {0}", myType.BaseType);
            Console.WriteLine("Абстрактный:            {0}", myType.IsAbstract);
            Console.WriteLine("Это COM объект:         {0}", myType.IsCOMObject);
            Console.WriteLine("Запрещено наследование: {0}", myType.IsSealed);
            Console.WriteLine("Это class:              {0}", myType.IsClass);

            Console.WriteLine(new string('-', 10));

            //Информация о всех Именах методов класса 
            GetInfoAboutMethod(myClass);

            //Информация о всех Именах полей класса 
            GetInfoAboutFields(myClass);

            //Информация о всех Свойствах полей класса 
            GetInfoAboutProps(myClass);

            //Информация о всех Интерфейсах класса 
            GetInfoAboutInterfaces(myClass);

            // Информация о всех Конструкторах  класса 
            GetInfoAboutConstructors(myClass);

            //Задержка
            Console.ReadKey();
        }

        #region GetInfoAboutMethod - Информация о всех Именах методов класса 
        /// <summary>
        /// Информация о всех Именах методов класса 
        /// </summary>
        static void GetInfoAboutMethod(MyClass myClass)
        {
            Console.WriteLine(new string('_', 30) + " Методы класса MyClass" + "\n");

            Type myType = myClass.GetType();

            MethodInfo[] methodInfo = myType.GetMethods(
                      BindingFlags.Instance
                    | BindingFlags.Static
                    | BindingFlags.Public
                    | BindingFlags.NonPublic 
                    | BindingFlags.DeclaredOnly);

            foreach (MethodInfo method in methodInfo)
            {
                Console.WriteLine("Method: {0}", method.Name);
            }
        }
        #endregion

        #region GetInfoAboutFields - Информация о всех Именах полей класса 
        /// <summary>
        /// Информация о всех Именах полей класса 
        /// </summary>
        static void GetInfoAboutFields(MyClass myClass)
        {
            Console.WriteLine(new string('_', 30) + " Поля класса MyClass" + "\n");

            Type myType = myClass.GetType();

            FieldInfo[] fieldsInfo =
              myType.GetFields(
                    BindingFlags.Instance
                  | BindingFlags.Static
                  | BindingFlags.Public
                  | BindingFlags.NonPublic);

            foreach (FieldInfo fieldInfo in fieldsInfo)
            {
                Console.WriteLine("Field: {0}", fieldInfo.Name);
            }
        }
        #endregion

        #region GetInfoAboutProps -  Информация о всех Свойствах полей класса 
        /// <summary>
        /// Информация о всех Свойствах полей класса 
        /// </summary>
        public static void GetInfoAboutProps(MyClass myClass)
        {
            Console.WriteLine(new string('_', 30) + " Свойства класса MyClass" + "\n");

            Type myType = myClass.GetType();

            PropertyInfo[] propertysInfo = myType.GetProperties();

            foreach (PropertyInfo propertyInfo in propertysInfo)
            {
                Console.WriteLine("Свойство: {0}", propertyInfo.Name);
            }
        }
        #endregion

        #region GetInfoAboutInterfaces - Информация о всех Интерфейсах полей класса 
        /// <summary>
        /// Информация о всех Интерфейсах класса 
        /// </summary>
        public static void GetInfoAboutInterfaces(MyClass myClass)
        {
            Console.WriteLine(new string('_', 30) + " Интерфейсы класса MyClass" + "\n");
            
            Type myType = myClass.GetType();

            Type[] interfacesTypes = myType.GetInterfaces();

            foreach (Type interfaceType in interfacesTypes)
            {
                Console.WriteLine("Интерфейс: {0}", interfaceType);
            }
        }
        #endregion

        #region GetInfoAboutConstructors -  Информация о всех Конструкторах  класса 
        /// <summary>
        ///  Информация о всех Конструкторах  класса 
        /// </summary>
        public static void GetInfoAboutConstructors(MyClass myClass)
        {
            Console.WriteLine(new string('_', 30) + " Конструкторы класса Class1" + "\n");

            Type myType = myClass.GetType();

            ConstructorInfo[] constructorsInfo = myType.GetConstructors();

            foreach (var constructorInfo in constructorsInfo)
            {
                Console.WriteLine("Constructor: {0}", constructorInfo.Name);
            }
        }
        #endregion

    }
}
