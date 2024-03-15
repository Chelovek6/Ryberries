using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ryberries.Model
{
    internal class WarehouseCells
    {
        public int CellsArticle;
        public int GoodsArticle;
        public int TotalQuantity;
        public int DealArticle;

        public WarehouseCells(int cellsArticle, int goodsArticle, int totalQuantity, int dealArticle)
        {
            CellsArticle = cellsArticle;
            GoodsArticle = goodsArticle;
            TotalQuantity = totalQuantity;
            DealArticle = dealArticle;
        }
    }

}
