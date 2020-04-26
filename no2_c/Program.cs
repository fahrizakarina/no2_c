using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace no2_c
{
    class Program
    {
        static void Main(string[] args)
        {
            RetailItem item1 = new RetailItem("Jacket", 17, 59.95);
            RetailItem item2 = new RetailItem("Designer Jeans", 17, 59.95);
            RetailItem item3 = new RetailItem("Shirt", 17, 59.95);

            //item1.setDescription("Watch");

            Console.WriteLine("\t\tDescription\tUnitsOnHand\tPrice");
            Console.WriteLine("item #1\t\t" + item1.getDescription() + "\t\t" + item1.getUnitsOnHand() + "\t\t" + item1.getPrice());
            Console.WriteLine("item #2\t\t" + item2.getDescription() + "\t" + item2.getUnitsOnHand() + "\t\t" + item2.getPrice());
            Console.WriteLine("item #3\t\t" + item3.getDescription() + "\t\t" + item3.getUnitsOnHand() + "\t\t" + item3.getPrice());
            Console.ReadLine();
        }
    }
}
