using System;

/// <summary>
///  Проблема которая возникла до появления обобщенных типов.
/// </summary>
namespace _002_Generics
{
    class Program
    {
        static void Main()
        {
            //Создание экземпляров класса Employee
            Employee employee1 = new Employee() { PersonnelNumber = "   1а", Surname = "Petvor" };
            Employee employee2 = new Employee() { PersonnelNumber = 2, Surname = "Ivanov" };

            //Вывод инфоррмации о типе PersonnelNumber
            Console.WriteLine(employee1.PersonnelNumber.GetType()); //System.String
            Console.WriteLine(employee2.PersonnelNumber.GetType()); //System.Int32

            //Решение является не очень оптимальным, так как в данном случае мы сталкиваемся 
            //с такими явлениями как упаковка (boxing) и распаковка (unboxing).

            //Упаковка в значения int в тип Object.
            employee2.PersonnelNumber = 1;

            //Чтобы обратно получить данные в переменную типов int, необходимо выполнить распаковку.
            int personnelNumber1 = (int)employee2.PersonnelNumber;
            Console.WriteLine(personnelNumber1);

            //Также существует другая проблема - проблема безопасности типов. 
            //Так, мы получим ошибку во время выполнения программы, если напишем следующим образом:
            //int personnelNumber2 = (int)employee1.PersonnelNumber;
            //Console.WriteLine(personnelNumber2);

            //Задержка
            Console.ReadKey();
        }
    }

    /// <summary>
    /// Класс сотрудник 
    /// </summary>
    class Employee
    {
        /// <summary>
        /// Табельный номер 
        /// (Вопрос какого типа может быть  Табельный номер, символьный или числовой,
        /// Напириме  на момент написания класса мы можем точно не знать, какой тип лучше 
        /// выбрать для хранения Табельного номера - строку или число.)
        /// 1-й варинт 
        /// Можно определить свойство PersonnelNumber как свойство типа object.
        /// </summary>
        public object PersonnelNumber { get; set; }

        /// <summary>
        /// Фамилия 
        /// </summary>
        public string Surname { get; set; }
    }
}
