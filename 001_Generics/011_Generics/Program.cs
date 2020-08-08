using System;

/// <summary>
/// Ковариантность обобщений.
/// </summary>
namespace _011_Generics
{
    class Program
    {
        static void Main()
        {
            //Класс Bank, который представляет условный банк, реализует этот интерфейс 
            //и возвращает из метода CreateAccount объект, который представляет либо 
            //класс Account, либо один из его наследников.

            //Екземпляр класса Bank 
            IBank<DepositAccount> depositBank = new Bank<DepositAccount>();
            Account account1 = depositBank.CreateAccount(34);

            //Мы можем присвоить более общему типу IBank<Account> объект более конкретного 
            //типа IBank<DepositAccount> или Bank< DepositAccount >.
            IBank <Account> ordinaryBank = new Bank<DepositAccount>();
            Account account2 = ordinaryBank.CreateAccount(45);

            //Задержка
            Console.ReadKey();
        }
    }

    /// <summary>
    /// Класс  Account - обычный счет.
    /// </summary>
    class Account
    {
        /// <summary>
        /// Метод DoTransfer()выполняет условную операцию с счетом,
        /// virtual - указывает на возможность переопределения данного метода.
        /// </summary>
        public virtual void DoTransfer(int sum)
        {
            Console.WriteLine($"Клиент положил на счет {0} долларов", sum);
        }
    }

    /// <summary>
    ///  Класс DepositAccount, унаследованный от класс DepositAccount.
    /// </summary>
    class DepositAccount : Account
    {
        /// <summary>
        /// Метод DoTransfer - переопределенный метод из базового класса Account.
        /// </summary>
        public override void DoTransfer(int sum)
        {
            Console.WriteLine($"Клиент положил на депозитный счет {sum} долларов");
        }
    }

    /// <summary>
    /// Интерфейс IBank
    /// параметризированный указателем Места Заполнения Типом - T
    /// out - указывает на коваринтность интерфейса
    /// </summary>
    interface IBank<out T>
    {
        /// <summary>
        /// Метод CreateAccount -  для создания счета.
        /// На момент определения интерфейса мы не знаем, какой тип будет представлять счет.
        /// </summary>
        T CreateAccount(int sum);
    }

    /// <summary>
    /// Класс Bank  параметризированный указателем Места Заполнения Типом - T
    /// </summary>
    class Bank<T> : IBank<T> where T : Account, new()
    {
        /// <summary>
        /// Метод для для создания счета.
        /// </summary>
       public T CreateAccount(int sum)
        {
            T instance = new T();  // создаем счет
            instance.DoTransfer(sum);

            return instance;
        }
    }
}
