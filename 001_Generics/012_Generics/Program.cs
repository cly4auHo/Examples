using System;

/// <summary>
///  Контравариантность обобщений.
/// </summary>
namespace _012_Generics
{
    class Program
    {
        static void Main()
        {
            ITransaction<Account> accountTransaction = new Transaction<Account>();
            accountTransaction.DoOperation(new Account(), 400);

            //Интерфейс ITransaction использует универсальный параметр с ключевым словом in, 
            //поетому он является контравариантным => объект Transaction<Account> можно 
            //привести к типу ITransaction<DepositAccount>:

            ITransaction<DepositAccount> depositTransaction = new Transaction<Account>();
            depositTransaction.DoOperation(new DepositAccount(), 450);

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
    /// Интерфейс ITransaction - представляет условную банковскую операцию.
    /// in в определении интерфейса указывает, что этот интерфейс - контравариантный. 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    interface ITransaction<in T>
    {
        /// <summary>
        /// Метод DoOperation принимает некоторый счет и выполняет с ним операцию.
        /// </summary>
        void DoOperation(T account, int sum);
    }

    /// <summary>
    /// Класс Transaction параметризированный указателем Места Заполнения Типом - T 
    /// и реализует интерфейс ITransaction и его метод DoOperation.
    /// </summary>
    class Transaction<T> : ITransaction<T> where T : Account
    {
        /// <summary>
        /// Реализация метода DoOperation из интерфейса ITransaction
        /// </summary>
        public void DoOperation(T account, int sum)
        {
            account.DoTransfer(sum);
        }
    }
}
