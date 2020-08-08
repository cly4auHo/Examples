
/// <summary>
/// Ситуация:
/// Совпадение имен двух пространств имен в разных сборках и совпадение имен стереотипов в этих пространствах имен.

/// Для подключения алиаса выполните следующие действия:
/// 1. Добавьте в References необходимые сборки Library1 и Library2.
/// 2. Откройте папку References.
/// 3. Правой кнопкой мыши кликните по сборке Library1, откроется контекстное меню, в котором выберите пункт Properties.
/// 4. В открывшемся окне свойств, в свойстве Aliases, замените значение global на L1.
/// Те-же действия выполните для сборки Library2.
/// </summary>
namespace _020_Namespaces_
{
    //Здесь создаются внешние псевдонимы L1 и L2.
    //Чтобы использовать эти псевдонимы в программе, 
    //создайте на них ссылку с помощью ключевого слова extern. 
    extern alias L1;
    extern alias L2;
    class Program
    {
        static void Main()
        {
            L1.Library.MyClass my1 = new L1.Library.MyClass();
            L2.Library.MyClass my2 = new L2.Library.MyClass();

            my1.Method();
            my2.Method();

            // Задержка.
            System.Console.ReadKey();
        }
    }
}
