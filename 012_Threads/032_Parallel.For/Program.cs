using System;
using System.Threading;
using System.Threading.Tasks;

/// <summary>
/// Использование типов ParallelLoopResult и ParallelLoopState и
/// метода Break() для параллельного выполнения цикла.
/// ParallelLoopState - позволяет управлять итерациями параллельных циклов,
/// экземпляр этого класса предоставляется каждому циклу автоматически.
/// Метод parallelLoopState.Break() - прерывает выполнение цикла.
/// ParallelLoopResult - предоставляет состояние выполнения цикла Parallel.
/// Свойство parallelLoopResult.IsCompleted == true, если цикл доработал до конца,
/// иначе, если цикл был прерван, то IsCompleted == false.
/// </summary>

namespace _032_Parallel.For
{
    class Program
    {
        static void Main()
        {
            int[] data = new int[100000000];

            // Инициализация массива начальными значениями.
            Parallel.For(0, data.Length, i => data[i] = i);

            // Помещение отрицательного значения в массив.
            data[300] = -1; 

            Action<int, ParallelLoopState> transform = (int i, ParallelLoopState state) =>
            {
                // ЕСЛИ: Отрицательное значение
                if (data[i] < 0)
                { 
                    state.Break(); // ТО:   Прервать цикл
                }

                Thread.Sleep(1);

                data[i] = i * i * i / 123;
            };

            // ParallelLoopResult - На выходе метод возвращает структуру ParallelLoopResult, 
            // которая содержит информацию о выполнении цикла.
            ParallelLoopResult loopResult = Parallel.For(0, data.Length, transform);

            // IsCompleted - Получает значение, указывающее цикл был завершен, таким образом, что выполнены
            if (!loopResult.IsCompleted)
            {
                Console.WriteLine("\nЦикл завершился преждевременно." +
                    " Элемент {0} имеет отрицательное значение.\n",
                    loopResult.LowestBreakIteration);
            }

            Console.WriteLine("Основной поток завершен.");

            // Задержка
            Console.ReadKey();
        }
    }
}
