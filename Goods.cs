using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Goods
    {
        private string item = "";
        private double price;
        private bool isexempt = false;
        private bool isimportTax = false;

        public double Price { get { return price; } }

        public Goods(string item,double price,  bool isexempt=false)
        {
            this.item = item;
            this.price = price;
            this.isexempt = isexempt;
            this.isimportTax = item.Contains("imported")? true:false;

        }
        private double addTaxes()
        {
            int importPercent = isimportTax ? 5 : 0;
            int isexemptpercent = isexempt ? 0 : 10;

            double totalTax = (price / 100) * (importPercent + isexemptpercent);
            double ceiling = Math.Ceiling(totalTax * 20);
            double roundUpTo0_05 = (ceiling / 20);
            return Math.Round(roundUpTo0_05 + price, 2);
        }
        public void printItemWithTax()
        {
           Console.WriteLine(item+":"+ addTaxes());
        }
        public  double getTotalPricwwithTax ()
        {
            return addTaxes(); 
        }
    }
}
