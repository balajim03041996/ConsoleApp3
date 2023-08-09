using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.AllGoods
{
    public class SalesTaxLiableGoods : Goods
    {
        private string item = "";
        private double price;
        public bool isexempt = false;
        private bool isimportTax = false;

        public string Item { get { return item; } }
        public double Price { get { return price; } }
        public bool IsimportTax { get { return isimportTax; } }
        public bool Isexempt { get { return isexempt; } }

        public SalesTaxLiableGoods(string item, double price)
        {
            this.item = item;
            this.price = price;
            if(item.Contains("imported"))
                isimportTax = true;
        }
    }
}
