using System;
using System.Collections.Generic;
using System.IO;
using System.Security.AccessControl;

namespace Тумаков
{
    public enum BankAccType
    {
        Текущий,
        Сберегательный
    }
    internal class BankAccount
    {
        private static int counter = 45567456;
        private readonly string number;
        private decimal balance;
        private readonly BankAccType accType;
        private Queue<BankTransaction> ttransactions = new Queue<BankTransaction>();
        
        public BankAccount(decimal balanceData, BankAccType accountType)
        {
            counter++;
            this.number = Generate_number();
            this.balance = balanceData;
            this.accType = accountType;
        }
        public BankAccount()
        {
            number = Generate_number();
            balance = 0;
            accType = BankAccType.Текущий;
        }

        public BankAccount(decimal initialBalance)
        {
            number = Generate_number();
            balance = initialBalance;
            accType = BankAccType.Сберегательный;
        }

        public BankAccount(BankAccType accountType)
        {
            number = Generate_number();
            balance = 0;
            accType = accountType;
        }
        public void Info()
        {
            Console.WriteLine("Информация о счете:");
            Console.WriteLine($"Номер счета: {number}");
            Console.WriteLine($"Баланс: {balance}");
            Console.WriteLine($"Тип счета: {accType}");
            PrintTransactions();

        }
        private string Generate_number()
        {
            return counter.ToString("D11");
        }

        public void Deposit(decimal sum)
        {
            if (sum > 0)
            {
                balance += sum;
                Console.WriteLine($"\nВы пополнили на {sum}. Ваш новый баланс {balance}");
            }
            else
            {
                Console.WriteLine("Сумма не может быть отрицательной!");
            }
            ttransactions.Enqueue(new BankTransaction(sum));
        }

        public void Withdraw(decimal sum)
        {
            if (sum <= 0)
            {
                Console.WriteLine("Сумма вывода должна быть положительной");
                return;
            }
            else if (sum > balance)
            {
                Console.WriteLine("У вас недостаточно средств");
            }
            else
            {
                balance -= sum;
                Console.WriteLine($"Вы сняли {sum}. Ваш новый баланс {balance}");
            }
            ttransactions.Enqueue(new BankTransaction(sum));
        }

        public void Transfer(BankAccount payee, decimal summa)
        {

            if (balance < summa)
            {
                Console.WriteLine("Недостаточно средств на счете");
                return;
            }

            if (summa <= 0)
            {
                Console.WriteLine("Сумма перевода должна быть положительной");
                return;
            }

            if (this == payee)
            {
                Console.WriteLine("Нельзя переводить деньги на тот же счет");
                return;
            }

            balance -= summa;
            payee.balance += summa;

            ttransactions.Enqueue(new BankTransaction(summa));

            Console.WriteLine($"\nВы перевели {summa}");
            Console.WriteLine($"Сумма на счете - отправителе: {balance}");
            Console.WriteLine($"Сумма на счете - получателе: {payee.balance}");
        }
        private void PrintTransactions()
        {
            Console.WriteLine("Транзакции:");
            if (ttransactions.Count > 0)
            {
                foreach (var transaction in ttransactions)
                {
                    Console.WriteLine($"- {transaction}");
                }
            }
            else
            {
                Console.WriteLine("Нет транзакций");
            }
        }
        private void WriteTransactionsToFile()
        {
            string fileName = $"{number}.txt";
            try
            {
                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    foreach (var transaction in ttransactions)
                    {
                        writer.WriteLine(transaction);
                    }
                }
                Console.WriteLine($"Данные о транзакциях записаны в файл: {fileName}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при записи в файл: {ex.Message}");
            }
        }
        public void Dispose()
        {
            WriteTransactionsToFile();
            GC.SuppressFinalize(this);
            Console.WriteLine("Объект BankAccount освобожден");
        }

    }
}
