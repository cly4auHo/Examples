using System;
using System.IO;
using System.Reflection;

namespace _011_Activator_Dynamic
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

                dynamic carInstance = Activator.CreateInstance(type);

                carInstance.Acceleration();
                carInstance.Driver("Shumaher", 26);
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
