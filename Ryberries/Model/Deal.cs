using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ryberries.Model
{
    internal class Deal
    {
        public int DealArticle;
        public int DealerArticle;
        public int GoodsArticle;
        public int UnitsCount;

        public Deal(int dealArticle, int dealerArticle, int goodsArticle, int unitsCount)
        {
            DealArticle = dealArticle;
            DealerArticle = dealerArticle;
            GoodsArticle = goodsArticle;
            UnitsCount = unitsCount;
        }
    }
}
