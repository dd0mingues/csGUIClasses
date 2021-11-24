using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("loading");
            List<Item> itemList = Item.addItems("Tea bags 2.50; Milk 1.99; Eggs 1.60; Potatoes 5.50; Carrots 1.00; Fish 6.50; Beef  4.50; Chicken 4.99");
            Console.ReadLine();
        }
    }
}
