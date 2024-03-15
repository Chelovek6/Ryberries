using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ryberries.Model
{
    internal class PickupPoints
    {
        public int PickupPointsArticle;
        public int StaffArticle;
        public string Address;
        public float Rating;

        public PickupPoints(int pickupPointsArticle, int staffArticle, string address, float rating)
        {
            PickupPointsArticle = pickupPointsArticle;
            StaffArticle = staffArticle;
            Address = address;
            Rating = rating;
        }
    }
}
