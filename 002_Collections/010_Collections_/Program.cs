using System;

/// <summary>
/// Ключевое слово as служит для перевода объекта к указанному типу, 
/// но в отличие от is, в случае невозможности привести объект к указанному 
/// типу мы вместо исключения получим null. 
/// /// </summary>
namespace _010_Collections_
{
    class Program
    {
        static void Main()
        {
            Person person = new Person("Tom");

            Employee emp =  person as Employee;

            // emp - будет содержать в себе null
            try
            {
                Console.WriteLine(emp.Name);
                Console.WriteLine(emp.Company);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }

            Employee employee = new Employee("Alexs", "ITEA");
            Person person1 = employee as Person;

            Console.WriteLine(person1.Name);

            // Задержка.
            Console.ReadKey();
        }
    }

    #region Person - Класс Person
    /// <summary>
    /// Класс Person
    /// </summary>
    class Person
    {
        /// <summary>
        /// Имя 
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Конструктор класса
        /// </summary>
        public Person(string name)
        {
            this.Name = name;
        }

        /// <summary>
        /// Метод для отображения
        /// </summary>
        public void Display()
        {
            Console.WriteLine(string.Format(@"Person {0}", Name));
        }
    }
    #endregion

    #region Employee -  Класс Employee, наследуется от класса Person
    /// <summary>
    /// Класс Employee, наследуется от класса Person
    /// </summary>
    class Employee : Person
    {
        /// <summary>
        /// Имя компании
        /// </summary>
        public string Company { get; set; }

        /// <summary>
        /// Конструктор класса
        /// </summary>
        public Employee(string name, string company) : base(name)
        {
            Company = company;
        }
    }
    #endregion
}
