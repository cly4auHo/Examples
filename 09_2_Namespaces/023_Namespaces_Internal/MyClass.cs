using System;
using LibraryA;

namespace Internal
{
    /// <summary>
    /// Возможность обращения к internal protected методу базового класса из другой сборки.
    /// </summary>
    public class MyClass : MyPublicClass
    {
        public void MyMethod()
        {
            this.InternalProtectedMethod();
        }
    }
}
