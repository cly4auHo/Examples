using _009_ICar;
using System;
using System.IO;
using System.Reflection;

namespace _011_Activator_Interface
{
    class Program
    {
        static void Main()
        {
            Assembly assembly = null;

            try
            {
                assembly = Assembly.Load("CarLibrary");

                Type type = assembly.GetType("_010_CarLibrary.MiniVan");

                Console.WriteLine("Полное Имя:             {0}", type.FullName);
                Console.WriteLine("Базовый класс:          {0}", type.BaseType);

                //Информаия про интерфейсы
                Type[] typesInterfaces = type.GetInterfaces();

                foreach (var typeInterfaces in typesInterfaces)
                {
                    Console.WriteLine(typeInterfaces);
                }
                
                ICar carInstance = Activator.CreateInstance(type) as ICar;

                if (carInstance != null)
                {
                    carInstance.Acceleration();
                    carInstance.Driver("Shumaher", 26);
                }
                else
                    Console.WriteLine("carInstance = null");
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }

            // Задержка.
            Console.ReadKey();
        }
    }
}
