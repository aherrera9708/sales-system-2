using Programming_III.Sales_2;
using Sales;

namespace Sales_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store();

            Seller sel1 = new Seller();
            sel1.Name = "Juan Carlos";
            sel1.Age = 45;
            store.AddSeller(sel1);

            Seller sel2 = new Seller();
            sel2.Name = "Maria Gomez";
            sel2.Age = 36;
            store.AddSeller(sel2);

            Seller sel3 = new Seller();
            sel3.Name = "Juanita";
            sel3.Age = 27;
            store.AddSeller(sel3);

            Product prod1 = new Product();
            prod1.Name = "Coffee";
            prod1.Price = 4000;
            store.AddProduct(prod1);

            Product prod2 = new Product();
            prod2.Name = "Shirt";
            prod2.Price = 20000;
            store.AddProduct(prod2);

            Product prod3 = new Product();
            prod3.Name = "UTP Cable";
            prod3.Price = 8000;
            store.AddProduct(prod3);

            Sale sale1 = new Sale();
            sale1.Product = prod2;
            sale1.Seller = sel1;
            sale1.Comments = "Men's t-shirt";
            store.AddSale(sale1);

            Sale sale2 = new Sale();
            sale2.Product = prod3;
            sale2.Seller = sel2;
            sale2.Comments = "2 meters";
            store.AddSale(sale2);

            Sale sale3 = new Sale();
            sale3.Product = prod1;
            sale3.Seller = sel3;
            sale3.Comments = "Coffee from Colombia";
            store.AddSale(sale3);


            int countUnitProduct = store.CountUnitProduct();
            System.Console.WriteLine("Total Units of Product :" + countUnitProduct);

        }
    }
}
