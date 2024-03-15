using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ryberries.Model
{
    internal class Order
    {
        public int OrderArticle;
        public int GoodsArticle;
        public int CellArticle;
        public int Quantity;
        public int SaleArticle;

        public Order(int orderArticle, int goodsArticle, int cellArticle, int quantity, int saleArticle)
        {
            OrderArticle = orderArticle;
            GoodsArticle = goodsArticle;
            CellArticle = cellArticle;
            Quantity = quantity;
            SaleArticle = saleArticle;
        }
    }
}
