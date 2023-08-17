using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//the base class is exchange rate

namespace proiectPAW3
{

    [Serializable]
    public class Currency:ExchangeRate
    {


        public long ID { get; set; }
        public string Name;
        public string TypeOfCurrency;
        public double ValueOfBanknote;
        public float Change;
        //public DateTime Date;
        public string Date;

        public Currency() 
        {
            
            this.Name = "";
            this.TypeOfCurrency = "";
            this.ValueOfBanknote = 0.0;
            this.Change = 0.0f;
            this.Date = ""; 
        }

        public Currency(string Name,string TypeOfCurrency, double ValueOfBanknote, float Change, string Date) 
        {
           
            this.Name = Name;
            this.TypeOfCurrency = TypeOfCurrency;
            this.ValueOfBanknote = ValueOfBanknote;
            this.Change = Change;
            this.Date = Date;
        }

        public Currency(long ID, string Name, string TypeOfCurrency, double ValueOfBanknote, float Change, string Date)
        {
            this.ID = ID;
            this.Name = Name;
            this.TypeOfCurrency = TypeOfCurrency;
            this.ValueOfBanknote = ValueOfBanknote;
            this.Change = Change;
            this.Date = Date;
        }

    }
}
