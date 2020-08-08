using MyNamespace.NamespaceA;
using MyNamespace.NamespaceB;

/// <summary>
/// Пространства имен.
/// Два пространства имен одного уровня вложенности, 
/// не предоставляют доступа одно другому, к своим стереотипам, без импорта.
/// </summary>
namespace _014_Namespaces
{
    class Program
    {
        static void Main()
        {
            BaseClass instance1 = new BaseClass();
            DerivedClass instance2 = new DerivedClass();
        }
    }
}
namespace MyNamespace
{
    namespace NamespaceA
    {
        public class BaseClass
        {
            public virtual void Method(){}
        }
    }

    namespace NamespaceB
    {
        class DerivedClass : NamespaceA.BaseClass
        {
            public override void Method()
            {
                base.Method();
            }
        }
    }
}
