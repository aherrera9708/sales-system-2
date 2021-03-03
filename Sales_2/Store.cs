using System;
using Sales;

namespace Programming_III.Sales_2
{
    public class Store
    {
        Seller[] Sellers = new Seller[10];
        int sellerCount = 0;

        Product[] Products = new Product[10];
        int productCount = 0;

        Sale[] Sale = new Sale[10];
        int saleCount = 0;

        public void AddSeller(Seller newSeller)
        {
            Sellers[sellerCount] = newSeller;
            sellerCount++;
        }

        public void AddProduct(Product newProduct)
        {
            Products[productCount] = newProduct;
            productCount++;
        }

        public void AddSale(Sale newSale)
        {
            Sale[saleCount] = newSale;
            saleCount++;
        }

        public int CountUnitProduct()
        {
            int count = 0;

            for (int i=0; i < productCount; i++)
            {
                if(Sale[i].Product.GetPrice() != 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}