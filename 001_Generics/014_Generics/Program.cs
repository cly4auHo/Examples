using System;

/// <summary>
/// Обобщение
/// Обход ограничения использования операции сложания, так делать не надо:)
/// Не повторять в домашних условиях!!!
/// </summary>
namespace _014_Generics
{
    class Program
    {
        static void Main()
        {
            MyClass<int> my = new MyClass<int>();
            int sum = my.Add(2, 3);

            Console.WriteLine(sum);

            //Задержка
            Console.ReadKey();
        }
    }

    /// <summary>
    /// Класс MyClass
    /// параметризированный указателем Места Заполнения Типом - T 
    /// </summary>
    class MyClass<T>
    {
        /// <summary>
        /// Метод Add для сложения.
        /// </summary>
        public T Add(T operand1, T operand2)
        {
            if (typeof(T) == typeof(int))
                return (T)(Object)((int)(object)operand1 + (int)(object)operand2);

            if (typeof(T) == typeof(double))
                return (T)(Object)((double)(object)operand1 + (double)(object)operand2);

            return (T)(object)0;
        }
    }
}
