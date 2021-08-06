using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    class DiscountCalculator<Tproduct> where Tproduct : Products
    {

        public float CalculateDiscount(Tproduct Products)
        {

            return Products.Price;
        }
    }
}