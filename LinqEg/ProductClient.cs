using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqEg
{
    public class ProductClient
    {
        public static List<Product> products = Product.GetProductDetails();

        public static void DisplayPrd()
        {
            foreach(var item in products)
            {
                Console.WriteLine(item.ToString());
            }
        }
        public static void DisplayPartPrd()
        {
            Console.WriteLine("Enter the Product ID");
            int id = Convert.ToInt32(Console.ReadLine());
            Product p = Product.GetProductById(id);
            Console.WriteLine(p.ToString());    
        }
        //public static void AddNewPrd()
        //{
        //    Console.WriteLine("Enter Pid, Pname and Pqty");
        //    Product p = new Product();
        //    p.Pid = Convert.ToInt32(Console.ReadLine());
        //    p.Pname = Console.ReadLine();
        //    p.Pqty = Convert.ToInt32(Console.ReadLine());
        //    Product.AddProduct(p);
        //}
        static void Main()
        {
            DisplayPrd();
            DisplayPartPrd();
        }
        
    }
}
