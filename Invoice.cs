using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace hw9
{
    internal class Invoice
    {
        string account;
        string customer;
        string provider;
        public Invoice(string account, string customer, string provider)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
        }
        

        public string Article { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        public decimal CostCalculation(bool needEdv)
        {
            
            if(needEdv)
            {
                decimal edv = Price * Quantity * 0.18M;
                return (Price  * Quantity) + edv; 
            }
            else
            {
                return Price * Quantity;
            }

        }
        
        


        
        
    }
}
