using System;

/// <summary>
/// Ключевое слово internal является модификатором доступа для типов и членов типов. 
/// Внутренние (internal) типы или члены доступны только внутри этой сборки. 
/// </summary>
namespace LibraryA
{
    public class MyPublicClass
    {
        public void PublicMethod()
        {
            Console.WriteLine("PublicMethod");
        }

        /// <summary>
        /// internal - Доступ к типу или члену возможен из любого кода в этой сборке, но не из другой сборки.
        /// </summary>
        internal void InternalMethod()
        {
            Console.WriteLine("InternalMethod");
        }

        /// <summary>
        /// internal protected - Доступ к типу или члену возможен 
        /// из любого кода в этой сборке, или из производного класса в другой сборке.
        /// </summary>
        internal protected void InternalProtectedMethod()
        {
            Console.WriteLine("InternalProtectedMethod");
        }
    }
}
