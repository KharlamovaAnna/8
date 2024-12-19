using System;

namespace Тумаков
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
        }
        public static void Task1()
        {
            /*В классе банковский счет, созданном в предыдущих упражнениях, удалить
            методы заполнения полей. Вместо этих методов создать конструкторы. Переопределить
            конструктор по умолчанию, создать конструктор для заполнения поля баланс, конструктор
            для заполнения поля тип банковского счета, конструктор для заполнения баланса и типа
            банковского счета. Каждый конструктор должен вызывать метод, генерирующий номер
            счета.*/
            Console.WriteLine("Упражнение 9.1");

            BankAccount account1 = new BankAccount(); 
            account1.Deposit(100);
            account1.Withdraw(50);
            account1.Info();

            BankAccount account2 = new BankAccount(1000);
            account2.Deposit(500);
            account2.Info();

            BankAccount account3 = new BankAccount(BankAccType.Сберегательный); 
            account3.Deposit(200);
            account3.Info();

            BankAccount account4 = new BankAccount(2000, BankAccType.Сберегательный); 
            account4.Withdraw(300);
            account4.Info();

            Console.ReadLine();
        }
        public static void Task2()
        {
            //Создать новый класс BankTransaction
            Console.WriteLine("Упражнение 9.2");

            BankAccount account = new BankAccount();
            account.Deposit(10);
            account.Withdraw(20);
            account.Withdraw(30);
            account.Deposit(40);
            account.Info();

            Console.ReadLine();
        }
        public static void Task3()
        {
            //В классе банковский счет создать метод Dispose
            Console.WriteLine("Упражнение 9.3");

            BankAccount account2 = new BankAccount();
            account2.Deposit(500);
            account2.Withdraw(200);

            try
            {
                account2.Info();
            }
            finally
            {
                account2.Dispose();
            }
            Console.ReadLine();
        }
    }
}
