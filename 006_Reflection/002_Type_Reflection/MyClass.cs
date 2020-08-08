using System;

namespace _002_Type_Reflection
{
    /// <summary>
    /// Класс MyClass
    /// </summary>
    public class MyClass: Interface1, Interface2
    {
        // Поля.         
        public int myint;
        private string mystring = "Hello";

        // Конструкторы.
        public MyClass() { }
        public MyClass(int i)
        {
            this.myint = i;
        }

        // Свойства.
        public int myProp
        {
            get { return myint; }
            set { myint = value; }
        }

        public string MyString
        {
            get { return mystring; }
        }

        // Методы.
        public void MethodA() { }
        public void MethodB() { }

        private void MethodC(string str, string str2)
        {
            Console.WriteLine(str + str2);
        }

        public void myMethod(int p1, string p2)
        {
        }
    }
}
