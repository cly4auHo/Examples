/// <summary>
/// Пространства имен.
/// Сокрытие имен стереотипов.
/// В случае наличия одноименных стереотипов во вложенном и во внешнем пространствах имен, 
/// происходит сокрытие имени стереотипа внешнего пространства имен. 
/// Обращение к одноименному стереотипу внешнего пространства имен, потребует полной квалификации имени стереотипа.
/// </summary>

namespace _015_Namespaces
{
    using NamespaceA;
    using NamespaceA.NamespaceB;
    class Program
    {
        static void Main()
        {
        }
    }
}

namespace NamespaceA
{
    namespace NamespaceB
    {
        /// <summary>
        /// Одноименный класс.
        /// </summary>
        class MyClass { }  

        class MyClassB
        {
            MyClass my1;
            NamespaceA.MyClass my2; // Прямая видимость отсутствует.
            MyClassA my3;           // Прямая видимость имеется.
        }
    }

    /// <summary>
    /// Одноименный стереотип.
    /// </summary>
    class MyClass { }
    class MyClassA { }
}
