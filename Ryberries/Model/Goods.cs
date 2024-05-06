using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ryberries.Model
{
    internal class Goods
    {
        public int GoodsArticle { get; set; }
        public string Name { get; set; }
        public int DealerArticle { get; set; }
        public int Cost { get; set; }
        public float Rating { get; set; }

        public Goods(int goodsArticle, string name, int dealerArticle, int cost, float rating)
        {
            GoodsArticle = goodsArticle;
            Name = name;
            DealerArticle = dealerArticle;
            Cost = cost;
            Rating = rating;
        }
    }


}
