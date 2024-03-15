using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ryberries.Model
{
    internal class Sale
    {
        public int SaleArticle;
        public int UserArticle;
        public int PickupPointsArticle;
        public decimal TotalCost;

        public Sale(int saleArticle, int userArticle, int pickupPointsArticle, decimal totalCost)
        {
            SaleArticle = saleArticle;
            UserArticle = userArticle;
            PickupPointsArticle = pickupPointsArticle;
            TotalCost = totalCost;
        }
    }
}
