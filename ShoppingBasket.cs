using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class ShoppingBasket
    {
        private List<Goods> goods= new List<Goods>();
        public  void addItemInBasket(List<Goods> shoppingItems)
        {
            
            goods = shoppingItems;
        }
        public void printReceipt()
        {
            double total=0, salesTax=0;
            foreach(Goods item in goods)
            {
                //totalCost= item.addTaxes();
                item.printItemWithTax();
                salesTax+= item.getTotalPricwwithTax() - item.Price;
                total += item.getTotalPricwwithTax();
            }
            Console.WriteLine("sales Tax:"+ Math.Round(salesTax,2));
            Console.WriteLine("Total: "+ Math.Round(total,2)+"\n");

        }
    }
}
