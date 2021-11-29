using System;

namespace Lektion2
{
    public class Wallet
    {
        // Mängden pengar i plånboken, får aldrig vara negativt
        private Kronor amount;

        public Kronor Amount { get { return amount; } set { amount = value; } }

        // Skapar en tom plånbok
        public Wallet()
        {

        }

        // Skapar en plånbok med pengar i
        public Wallet(Kronor money)
        {
            Amount = new Kronor(money);
            //Add(money);
        }

        /* 
         * Lägger till pengar till plånboken.
         */
        public void Add(Kronor money)
        {
            Amount = Amount.Add(money);
        }

        /*
         * Tar pengar ur plånboken
         * Det ska inte gå att ta ut mer pengar än vad som finns i plånboken
         */
        public void Remove(Kronor money)
        {
            Amount = Amount.Subtract(money);
        }

        /*
         * Tar bort alla pengar ur plånboken
         */
        public void RemoveAll()
        {
            amount = new Kronor();
        }
    }
}
