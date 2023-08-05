using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Goods
{
    public class SalesTaxExemptGoods
    {
        private string item = "";
        private double price;
        public bool isexempt = true;
        private bool isimportTax = false;

        public string Item { get { return item; } }
        public double Price { get { return price; } }
        public bool Isexempt { get { return isexempt; } }
        public bool IsimportTax { get { return isimportTax; } }

        public SalesTaxExemptGoods(string item, double price)
        {
            this.item = item;
            this.price = price;
            isimportTax = item.Contains("imported") ? true : false;

        }

    }
}
