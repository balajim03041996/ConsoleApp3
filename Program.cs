// See https://aka.ms/new-console-template for more information
using ConsoleApp3.AllGoods;
using ConsoleApp3.Taxes;
try
{

    Console.WriteLine("Enter the number of Goods on the list");
    int count = int.Parse(Console.ReadLine());
    List<Goods> ListOfProducts = new List<Goods>();
    for (int i = 0; i < count; i++)
    {
        Console.WriteLine($"Enter {i + 1} Product Name, and please mention imported with the product name if the product was imported.");
        string name = Console.ReadLine();
        if (name != null)
        {
            Console.WriteLine("Enter Price of Product");
            double price = double.Parse(Console.ReadLine());
            Console.WriteLine("If the product is a book, food, or medical product. reply 1 for YES or press any other key for no.");
            string isExempt = Console.ReadLine();
            bool isExemptProduct = isExempt.Equals("1");

            if (isExemptProduct)
            {
                SalesTaxExemptGoods g1 = new SalesTaxExemptGoods(name, price);
                //g1.IsimportTax = name.ToLower().Contains("imported");
                ListOfProducts.Add(g1);
            }
            else
            {
                SalesTaxLiableGoods g1 = new SalesTaxLiableGoods(name, price);
                ListOfProducts.Add(g1);
            }
        }
    }
    if (ListOfProducts.Count > 0)
    {
        ShoppingBasket sh1 = new ShoppingBasket();
        sh1.addItemInBasket(ListOfProducts);
        sh1.printReceipt();

    }
}
catch (Exception e)
{
    Console.WriteLine("Input was not in correct format");
}


