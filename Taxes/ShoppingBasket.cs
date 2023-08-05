using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp3.Goods;

namespace ConsoleApp3.Taxes
{
    public class ShoppingBasket
    {
        private List<SalesTaxExemptGoods> goods = new List<SalesTaxExemptGoods>();
        public void addItemInBasket(List<SalesTaxExemptGoods> shoppingItems)
        {

            goods = shoppingItems;
        }
        public void printReceipt()
        {
            AddTax t1= new AddTax();
            double total = 0, salesTax = 0;
            foreach (SalesTaxExemptGoods item in goods)
            {
                //totalCost= item.addTaxes();
                t1.printItemWithTax(item);
                salesTax += t1.getTotalPricwwithTax(item) - item.Price;
                total += t1.getTotalPricwwithTax(item);
            }
            Console.WriteLine("sales Tax:" + Math.Round(salesTax, 2));
            Console.WriteLine("Total: " + Math.Round(total, 2) + "\n");

        }
    }
}
