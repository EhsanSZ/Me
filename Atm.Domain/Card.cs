using System;

namespace Atm.Domain
{
    public class Card
    {
        public bool Enabled { get; set; }
        public int AccountBalance { get; set; }

        public Card(int accountBalance)
        {
            AccountBalance = accountBalance;
        }

        public void IsValid()
        {
            Enabled = true;
        }

        public void IsInvalid()
        {
            Enabled = false;
        }
    }
}
