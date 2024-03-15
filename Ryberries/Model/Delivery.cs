using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ryberries.Model
{
    internal class Delivery
    {
        public int DeliveryArticle;
        public int StaffArticle;
        public int SaleArticle;
        public int PickupPointArticle;

        public Delivery(int deliveryArticle, int staffArticle, int saleArticle, int pickupPointArticle)
        {
            DeliveryArticle = deliveryArticle;
            StaffArticle = staffArticle;
            SaleArticle = saleArticle;
            PickupPointArticle = pickupPointArticle;
        }
    }
}
