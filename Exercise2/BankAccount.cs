namespace Exercise2
{
    internal class BankAccount
    {
        private string accountNumber;
        private decimal balance;

        internal BankAccount(string accountNumber)
        {
            this.accountNumber = accountNumber;
            this.balance = 0;
        }

        internal void Deposit(decimal amount)
        {
            this.balance += amount;
        }

        internal void Withdraw(decimal amount) 
        {
            this.balance -= amount;
        }
        static void Main(string[] args)
        {
            BankAccount ba = new("A12345");
            ba.Deposit(1000);
            ba.Withdraw(500);
            Console.WriteLine("Final Balance of account number "+ba.accountNumber+" is "+ba.balance);
        }
    }
}