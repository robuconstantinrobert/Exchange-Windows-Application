using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiectPAW3
{
    [Serializable]
    public class Transaction
    {
        //Transaction transaction = new Transaction();
        //public List<Transaction> transaction = new List<Transaction>();
        public string CardHolder;
        public string CardNumber;
        public string Card3Digit;
        public string Wallet;
        public long id;

        public Transaction() 
        {
            this.id = 0;
            this.CardHolder = "";
            this.CardNumber = "";
            this.Card3Digit = "";
            this.Wallet = "";
        }

        public Transaction( string CardHolder, string CardNumber, string Card3Digit, string Wallet)
        {
            this.CardHolder = CardHolder;
            this.Card3Digit = Card3Digit;
            this.CardNumber = CardNumber;
            this.Wallet = Wallet;
        }

        public Transaction(long id, string CardHolder, string CardNumber, string Card3Digit, string Wallet) 
        {
            this.id = id;
            this.CardHolder = CardHolder;
            this.Card3Digit = Card3Digit;
            this.CardNumber = CardNumber;
            this.Wallet = Wallet;
        }

    
    }
}
