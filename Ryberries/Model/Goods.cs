using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ryberries.Model
{
    internal class Goods
    {
        public int Article;
        public string Name;
        public int DealerArticle;

        public int Cost;
        public float Rating;
        

        public Goods(int article, string name, int dealerArticle, int cost, float rating)
        {
            Article = article;
            Name = name;
            DealerArticle = dealerArticle;
            Cost = cost;
            Rating = rating;
        }
    }
}
