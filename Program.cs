// See https://aka.ms/new-console-template for more information
using ConsoleApp3.Goods;
using ConsoleApp3.Taxes;

ShoppingBasket sh1= new ShoppingBasket();
SalesTaxExemptGoods g1= new SalesTaxExemptGoods ("book",12.49);
SalesTaxExemptGoods g2 = new SalesTaxLiableGoods("music CD",14.99);
SalesTaxExemptGoods g3 = new SalesTaxExemptGoods("chocolate bar", 0.85);
List<SalesTaxExemptGoods> list = new List<SalesTaxExemptGoods> { g1 ,g2,g3};
sh1.addItemInBasket(list);
sh1.printReceipt();

//input 2
ShoppingBasket sh2 = new ShoppingBasket();
SalesTaxExemptGoods g4 = new SalesTaxExemptGoods("imported bar",10.00);
SalesTaxExemptGoods g5 = new SalesTaxLiableGoods("imported bottle",47.50);
List<SalesTaxExemptGoods> list2 = new List<SalesTaxExemptGoods> { g4, g5 };
sh2.addItemInBasket(list2);
sh2.printReceipt();

ShoppingBasket sh3 = new ShoppingBasket();
SalesTaxExemptGoods g6 = new SalesTaxLiableGoods("imported bottle",27.99);
SalesTaxExemptGoods g7 = new SalesTaxLiableGoods("perfume",18.99);
SalesTaxExemptGoods g8 = new SalesTaxExemptGoods("headache pills", 9.75);
SalesTaxExemptGoods g9 = new SalesTaxExemptGoods("imported chocolates",11.25);
List<SalesTaxExemptGoods> list3 = new List<SalesTaxExemptGoods> { g6, g7, g8,g9 };
sh3.addItemInBasket(list3);
sh3.printReceipt();

