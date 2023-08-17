using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiectPAW3
{
    [Serializable]
    public class ExchangeRate
    {
        
        public List<Currency> currencies = new List<Currency>();
        public string CurrencyCode { get; set; }
        public string ApplicableTax { get; set; } 
        public string Change24;
        public long id;

        public ExchangeRate() 
        {
           
       
        }

        public ExchangeRate(string CurrencyCode, string ApplicableTax) 
        {
            this.CurrencyCode = CurrencyCode;
            this.ApplicableTax = ApplicableTax;
        }

        public ExchangeRate( string CurrencyCode, string ApplicableTax, string Change24)
        {
        
            this.CurrencyCode = CurrencyCode;
            this.ApplicableTax = ApplicableTax;
            this.Change24 = Change24;

        }

        public ExchangeRate(long id, string CurrencyCode, string ApplicableTax,string Change24) 
        {
            this.id = id;
            this.CurrencyCode = CurrencyCode;
            this.ApplicableTax = ApplicableTax;
            this.Change24 = Change24;
       
        }
    }
}
