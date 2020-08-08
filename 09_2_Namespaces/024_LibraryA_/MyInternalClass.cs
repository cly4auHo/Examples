using System;

/// <summary>
/// internal - Доступ к типу или члену возможен из любого кода в той же сборке, но не из другой сборки.
/// </summary>
namespace LibraryA
{
    internal class MyInternalClass
    {
        public MyInternalClass()
        {
            Console.WriteLine("Constructor - MyInternalClassA");
        }
    }
}
