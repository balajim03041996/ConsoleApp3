using ConsoleApp3.Goods;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Taxes
{
    public class AddTax
    {
        private double addTaxes(SalesTaxExemptGoods goods)
        {
            int importPercent = goods.IsimportTax ? 5 : 0;
            int isexemptpercent = goods.Isexempt ? 0 : 10;

            double totalTax = goods.Price / 100 * (importPercent + isexemptpercent);
            double ceiling = Math.Ceiling(totalTax * 20);
            double roundUpTo0_05 = ceiling / 20;
            return Math.Round(roundUpTo0_05 + goods.Price, 2);
        }
        public void printItemWithTax(SalesTaxExemptGoods goods)
        {
            Console.WriteLine(goods.Item + ":" + addTaxes(goods));
        }
        public double getTotalPricwwithTax(SalesTaxExemptGoods goods)
        {
            return addTaxes(goods);
        }
    }
}
