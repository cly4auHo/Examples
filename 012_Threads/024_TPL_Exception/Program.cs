using System;
using System.Threading.Tasks;

/// <summary>
/// // Возбуждение исключений в задачах. 
/// (Пример выполнять через CTRL+F5)
/// </summary>
namespace _024_TPL_Exception
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Основной поток запущен.");

            Task task = new Task(MyTask);

            try
            {
                // Start - Запускает задачу System.Threading.Tasks.Task, 
                // планируя ее выполнение в текущем
                task.Start();
                // Wait - Ожидает завершения выполнения задачи System.Threading.Tasks.Task.
                task.Wait(); // Для обработки исключения обязательно вызвать Wait!
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception       : " + ex.GetType());
                Console.WriteLine("Message         : " + ex.Message);

                // InnerException- Возвращает экземпляр класса System.Exception, 
                // который вызвал текущее исключение.
                if (ex.InnerException != null)
                { 
                    Console.WriteLine("Inner Exception : " + ex.InnerException.GetType()); 
                }
            }
            finally
            {
                Console.WriteLine("Статус задачи   : " + task.Status);
            }

            Console.WriteLine("Основной поток завершен.");

            // Задержка
            Console.ReadKey();
        }

        /// <summary>
        /// Метод в котором будет возбуждаться исключение.
        /// </summary>
        static void MyTask()
        {
            Console.WriteLine("Задача запущена.");

            throw new Exception();

            Console.WriteLine("Задача завершена.");
        }
    }
}
