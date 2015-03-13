using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter
{
    public class Cart
    {
        #region Fields
        private List<string> _bookTitles = new List<string>();
        private const decimal unitPrice = 8m;
        #endregion

        #region Constructor
        public Cart()
        {

        }
        #endregion

        #region Public Methods
        public decimal GetTotal()
        {
            if (_bookTitles.Count > 0)
            {
                var distinctList = _bookTitles.Distinct();
                var quantityOfDistinct = distinctList.Count();

                DiscountHelper discountHelper = new DiscountHelper();
                var discount = discountHelper[quantityOfDistinct];
                var subtotal = _bookTitles.Count * unitPrice;

                var total = subtotal - (subtotal * discount);

                return total;
            }
            else
            {
                return 0m;
            }
        }
       
        public void AddToCart(string title)
        {
            _bookTitles.Add(title);
        }
        #endregion
    }
}
