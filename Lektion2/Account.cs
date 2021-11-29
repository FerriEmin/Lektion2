using System;

namespace Lektion2
{
    public class Account
    {
        /*
         * Mängden pengar i kontot.
         * Får vara negativt, men aldrig minska när det redan är negativt
         * Exempel:
         * 5 - 10 är tillåtet
         * -10 + 5 är tillåtet
         * -1 + 7 är tillåtet
         * -10 -5 är inte tillåtet
         */
        private Kronor amount;

        public Kronor Amount { get { return amount; } set { amount = value; } }


        // Skapar ett tomt konto
        public Account()
        {

        }

        // Skapar ett konto med pengar i
        public Account(Kronor money)
        {
            Amount = new Kronor(money);
        }

        /* 
         * Sätter in pengar på kontot.
         */
        public void Deposit(Kronor money)
        {
            Amount = Amount.Add(money);
        }

        /*
         * Tar ut pengar ur kontot
         * Minst 90% av pengarna måste finnas på kontot för att uttaget ska godkännas
         */
        public void Withdraw(Kronor money)
        {
            Amount = Amount.Subtract(money);
        }

        /*
         * Tar bort alla pengar ur plånboken
         */
        public void RemoveAll()
        {
            Amount = new Kronor();
        }

        /*
         * Överför pengar mellan två konton
         * Pengarna ska tas bort från from-kontot och läggas till till to-kontot
         * Övriga regler ska också upprätthållas
         */
        public static void Transfer(Account from, Account to, Kronor amount)
        {
            from.amount = amount;
            to.amount = amount;
        }
    }
}
