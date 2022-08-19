using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace LinqEg
{
    public class Product
    {
        public int Pid { get; set; }
        public string Pname { get; set; }
        public int Pqty { get; set; }
        public Product(int pid, string pname, int pqty)
        {
            Pid = pid;
            Pname = pname;
            Pqty = pqty;
        }

        public static List<Product> pd = new List<Product>();
        
        public static List<Product> GetProductDetails()
        {
            pd.Add(new Product(1, "Pen", 30));
            pd.Add(new Product(2, "Pencil", 50));
            return pd;
        }

        public static Product GetProductById(int id)
        {
            Product p = (from i in pd
                         where i.Pid == id
                         select i).SingleOrDefault();
            return p;
            
        }

        public override string ToString()
        {
            return String.Format(Pid + " " + Pname + " " + Pqty);
        }

    }
}
