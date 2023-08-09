using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp3.AllGoods;

namespace ConsoleApp3.Taxes
{
    public class Tax
    {
        int importTaxPercent = 5;
        int liableTaxPercent = 10;
        public int ImportTaxPercent { get { return importTaxPercent; } }
        public int LiableTaxPercent { get { return liableTaxPercent; } }

        /// <summary>
        /// To add resepctive taxes on product
        /// </summary>
        /// <param name="goods"></param>
        /// <returns></returns>
        public double addTaxes(Goods goods)
        {
            double TaxWithPercent = totalTax(goods);
            return roundUpTo0_05(TaxWithPercent, goods.Price);
        }
        /// <summary>
        /// to round price of product with tax with given round off
        /// </summary>
        /// <param name="IncludeTax"></param>
        /// <param name="GoodsPrice"></param>
        /// <returns></returns>
        public double roundUpTo0_05(double IncludeTax, double GoodsPrice)
        {
            double ceiling = Math.Ceiling(IncludeTax * 20);
            double roundUpTo0_05 = ceiling / 20;
            return Math.Round(roundUpTo0_05 + GoodsPrice, 2);
        }
        public double totalTax(Goods goods)
        {
            int importPercent = goods.IsimportTax? importTaxPercent : 0;
            int isexemptpercent = goods.Isexempt? 0 : liableTaxPercent;
            return (goods.Price / 100 )* (importPercent + isexemptpercent);
        }

        public void printItemWithTax(Goods goods)
        {
            Console.WriteLine(goods.Item + ":" + addTaxes(goods));
            double value = addTaxes(goods);
        }
        public double getTotalPricewithTax(Goods goods)
        {
            return addTaxes(goods);
        }
    }
}
