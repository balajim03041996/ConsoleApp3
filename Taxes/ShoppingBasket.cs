using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp3.AllGoods;

namespace ConsoleApp3.Taxes
{
    public class ShoppingBasket
    {
        private List<Goods> goods = new List<Goods>();
        public void addItemInBasket(List<Goods> shoppingItems)
        {
            goods = shoppingItems;
        }
        /// <summary>
        /// To print final price with taxes as detailed list
        /// </summary>
        public void printReceipt()
        {
            Tax t1= new Tax();
            double total = 0, salesTax = 0;
            foreach (Goods item in goods)
            {
                t1.printItemWithTax(item);
                salesTax += isolateSalesTax(t1.getTotalPricewithTax(item), item.Price);
                total += t1.getTotalPricewithTax(item);
            }
            Console.WriteLine("sales Tax:" + Math.Round(salesTax, 2));
            Console.WriteLine("Total: " + Math.Round(total, 2) + "\n");

        }
        /// <summary>
        /// To get imported and liable tax alone exclude pricr of good
        /// </summary>
        /// <param name="TotalPricwwithTax"></param>
        /// <param name="ItemActualPrice"></param>
        /// <returns></returns>
        public double isolateSalesTax(double TotalPricwwithTax, double ItemActualPrice)
        {
            return TotalPricwwithTax - ItemActualPrice;
        }

    }
}
