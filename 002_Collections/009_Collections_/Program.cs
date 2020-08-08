using System;

/// <summary>
/// Оператор is проверяет совместимость объекта с данным типом, 
/// а в качестве результата выдает значение булева типа, либо правду, либо ложь. 
/// Оператор is никогда не генерирует исключение, он работает со всеми типами.
/// </summary>
namespace _009_Collections_
{
    class Program
    {
        static void Main()
        {
            Person person = new Person("Tom");
            
            bool result = person is Employee;

            Console.WriteLine(result);

            // 1) Проверка на допустимость преобразования 
            if (person is Employee)
            {
                // 2) Преобразование
                Employee emp = (Employee)person;
                Console.WriteLine(emp.Company);
            }
            else
                Console.WriteLine("Преобразование не допустимо");

            /***********************************************************************/
            // Оттеняем вывод
            Console.WriteLine(new string('-', 10));

            Employee employee = new Employee("Alexs", "ITEA");

            bool result2 = employee is Person;
            Console.WriteLine(result2);

            if (employee is Person)
            {
                Person person1 = (Person)employee;
                Console.WriteLine(person1.Name);
            }
            else
                Console.WriteLine("Преобразование не допустимо");

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
