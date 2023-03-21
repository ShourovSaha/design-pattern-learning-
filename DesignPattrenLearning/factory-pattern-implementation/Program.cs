namespace factory_pattern_implementation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello,");

            IBankAccount bankAccount = BankAccountFactory.GetBankAccountObject((int)EnumCollection.BankAccountType.SavingsAccount);
            bankAccount.Diposite(100);

            Console.ReadKey();  
        }
    }
}