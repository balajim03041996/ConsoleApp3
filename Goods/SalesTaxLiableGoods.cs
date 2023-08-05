using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Goods
{
    public class SalesTaxLiableGoods : SalesTaxExemptGoods
    {
        public SalesTaxLiableGoods(string item, double price) : base(item, price)
        {
            isexempt = false;
        }
    }
}
