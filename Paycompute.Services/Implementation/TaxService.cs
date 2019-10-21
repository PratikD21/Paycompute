﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Paycompute.Services.Implementation
{
    public class TaxService : ITaxService
    {
        private decimal taxRate;
        private decimal tax;
        public decimal TaxAmount(decimal totalAmount)
        {
            
            if (totalAmount <= 1042)
            {
                //Tax Fee Rate
                taxRate = .0m;
                tax = totalAmount * taxRate;
            }
            else if (totalAmount > 1042 && totalAmount <= 3125)
            {
                //Basic Tax Rate
                taxRate = .20m;
                //Income Tax
                tax = (1042 * .0m) + ((totalAmount - 1042) * taxRate);
            }
            else if(totalAmount > 3125 && totalAmount <= 12500)
            {
                //Higher Tax Rate
                taxRate = .40m;
                //Income Tax
                tax = (1042 * .0m) + ((3125 - 1042) * 0.20m) + ((totalAmount - 3125) * taxRate);
            }
            else if (totalAmount > 12500)
            {
                //Addtional Tax Rate
                taxRate = .45m;
                //Income Tax
                tax = (1042 * .0m) + ((3125 - 1042) * .20m) + ((12500 - 3125) * .40m) + ((totalAmount - 12500) * taxRate);
            }
            return tax;
        }
    }
}
