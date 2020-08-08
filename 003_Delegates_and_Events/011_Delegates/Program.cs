using System;

/// <summary>
/// Делегат
/// </summary>
namespace _011_Delegates
{
    /// <summary>
    /// 1) Класс-делегата с именем Delegate1,
    /// метод, который будет сообщен с экземпляром данного класса-делегата, 
    /// не будет ничего принимать и не будет возвращать тип Delegate2.
    /// </summary>
    delegate Delegate2 Delegate1();

    /// <summary>
    /// 2) Класс-делегата с именем Delegate2,
    /// метод, который будет сообщен с экземпляром данного класса-делегата, 
    /// не будет ничего принимать и не будет ничего возвращать.
    /// </summary>
    delegate void Delegate2();
    class Program
    {
        static void Main()
        {
            // Создаем экземпляр делегата delegate1 типа Delegate1 и сообщаем с ним Method1
            Delegate1 delegate1 = new Delegate1(Method1);

            // Создаем экземпляр делегата delegate1 типа Delegate1 и сообщаем с ним Method1
            Delegate2 delegate2 = delegate1.Invoke();

            // Вызываем метод сообщенный с делегатом.
            delegate2.Invoke();

            // Задержка.
            Console.ReadKey();
        }

        /// <summary>
        /// 1) Создаем статический метод, который планируем сообщить с делегатом,
        /// возвращаемое значение метода делаегат типа Delegate2;
        /// </summary>
        /// <returns></returns>
        public static Delegate2 Method1()
        {
            return new Delegate2(Method2);
        }

        /// <summary>
        /// 2)Создаем статический метод, который планируем сообщить с делегатом,
        /// данный метод ничего не принимает и не возвращает.
        /// </summary>
        public static void Method2()
        {
            Console.WriteLine("Hello world!");
        }
    }
}
