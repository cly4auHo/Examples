using System;
using System.Threading;
using System.Threading.Tasks;

/// <summary>
/// Класс TaskFactory
/// Создание экземпляра задачи с использованием фабрики задач
/// [применение класса TaskFactory для создания и запуска задачи].
/// </summary>
namespace _020_TPL_Factory
{
    class Program
    {
        static void Main()
        {
            // Вариант 1.
            // Task.Factory - Предоставляет доступ к методам фабрики для создания и настройки экземпляров
            // StartNew - Создает и запускает задачу.
            //Task task = Task.Factory.StartNew(MyTask);
            // При запуске задачи через TaskFactory, вызов метода Start() не требуется.
            //task.Start();

            // Вариант 2.
            
            //TaskFactory - Предоставляет поддержку создания и планирования объектов System.Threading.Tasks.Task.
            TaskFactory factory = new TaskFactory();
            Task task = factory.StartNew(MyTask);
            

            // Задержка
            Console.ReadKey();
        }

        /// <summary>
        /// Метод который будет выполнен асинхронно.
        /// </summary>
        static void MyTask()
        {
            for (int i = 0; i < 80; i++)
            {
                Thread.Sleep(20);
                Console.Write(".");
            }
        }
    }
}
