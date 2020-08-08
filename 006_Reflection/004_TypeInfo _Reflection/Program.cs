using System;
using System.Collections.Generic;
using System.Reflection;

/// <summary>
/// Объект TypeInfo представляет само определение типа, а Type объект представляет ссылку на определение типа. 
/// Получение объекта TypeInfo вызывает принудительную загрузку сборки, содержащей этот тип. 
/// Для сравнения можно управлять объектами, не требуя обязательной загрузки средой 
/// выполнения сборки, на которую они ссылаются.
/// </summary>
namespace _004_TypeInfo__Reflection
{
    class Program
    {
        static void Main()
        {
            Type type = typeof(Employee);

            // TypeInfo - Представляет объявления типов для классов, интерфейсов, массивов, значений, перечислений,
            // параметров, определений универсальных типов и открытых или закрытых сконструированных
            // универсальных типов.
            TypeInfo typeInfo = type.GetTypeInfo();

            /*****************************************************************************/
            //DeclaredProperties - возвращает коллекцию свойств, 
            IEnumerable<PropertyInfo> properties = typeInfo.DeclaredProperties;

            Console.WriteLine(new string('_', 10) + " Свойства класса Employee" + "\n");
            foreach (PropertyInfo propertyInfo in properties)
            {
                Console.WriteLine(propertyInfo);
            }

            /*****************************************************************************/
            //DeclaredMethods - возвращает коллекцию методов
            IEnumerable<MethodInfo> methods = typeInfo.DeclaredMethods;

            Console.WriteLine(new string('_', 10) + " Методы класса Employee" + "\n");
            foreach (MethodInfo methodInfo in methods)
            {
                Console.WriteLine(methodInfo);
            }
            /*****************************************************************************/

            // DeclaredEvents - возвращает коллекцию событий
            IEnumerable<EventInfo> events = typeInfo.DeclaredEvents;

            Console.WriteLine(new string('_', 10) + " События класса Employee" + "\n");

            foreach (EventInfo eventInfo in events)
            {
                Console.WriteLine(eventInfo);
            }
            /*****************************************************************************/

            //Задержка
            Console.ReadKey();
        }
    }

    /// <summary>
    /// Класс Employee
    /// </summary>
    public sealed class Employee
    {
        /// <summary>
        /// Автосвойство FirstName
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Автосвойство LastName
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Событие Modified
        /// </summary>
        public event EventHandler Modified;

        /// <summary>
        /// Метода который вызивает событие 
        /// </summary>
        private void OnModified()
        {
            EventHandler handler = Modified;

            if (handler != null)
            {
                handler.Invoke(this, EventArgs.Empty);
            }
        }

        /// <summary>
        /// Метод для вывода строки 
        /// </summary>
        public void SomeMethod() 
        {
            Console.WriteLine("SomeMethod");
        }
    }
}
