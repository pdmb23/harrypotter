using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter
{
    public class DiscountHelper
    {
        public decimal this[int key]
        {
            get 
            {
                return _discountsByQuantity[key]; 
            }
        }
        private Dictionary<int, decimal> _discountsByQuantity =
           new Dictionary<int, decimal>()
            {
                { 1, 0m },
                { 2, 0.05m },
                { 3, 0.1m },
                { 4, 0.2m },
                { 5, 0.25m }
            };
    }
}
