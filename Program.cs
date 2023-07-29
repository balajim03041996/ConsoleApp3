// See https://aka.ms/new-console-template for more information
using ConsoleApp2;


ShoppingBasket sh1= new ShoppingBasket();
Goods g1= new Goods ("book",12.49,isexempt: true);
Goods g2 = new Goods("music CD",14.99, false);
Goods g3 = new Goods("chocolate bar", 0.85, true);
List<Goods> list = new List<Goods> { g1 ,g2,g3};
sh1.addItemInBasket(list);
sh1.printReceipt();

//input 2
ShoppingBasket sh2 = new ShoppingBasket();
Goods g4 = new Goods("imported bar",10.00, true);
Goods g5 = new Goods("imported bottle",47.50, false);
List<Goods> list2 = new List<Goods> { g4, g5 };
sh2.addItemInBasket(list2);
sh2.printReceipt();

ShoppingBasket sh3 = new ShoppingBasket();
Goods g6 = new Goods("imported bottle",27.99,false);
Goods g7 = new Goods("perfume",18.99, false);
Goods g8 = new Goods("headache pills",9.75, true);
Goods g9 = new Goods("imported chocolates",11.25,true);
List<Goods> list3 = new List<Goods> { g6, g7, g8,g9 };
sh3.addItemInBasket(list3);
sh3.printReceipt();

