using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newShoppingList
{
    class Item
    {
        string name;
        double price;

        public Item(string name, double price)
        {
            this.name = name;
            this.price = price;
        }

        public string Name { get => name; set => name = value; }
        public double Price { get => price; set => price = value; }

        public static List<Item> addItems(string itemString)
        {
            string name = "";
            string price = "";
            List<Item> itemList = new List<Item> { };


            for (int i = 0; i < itemString.Length; i++)
            {
                char c = itemString[i];

                name += c;//this will save all the chars into the name, ultil the 1st number

                if (Char.IsDigit(c))
                {
                    name = name.Remove(name.Length - 1);//this will remove the first number from the name
                    try
                    {
                        while (!(c.Equals(';')))
                        {
                            price += c;
                            i++;
                            c = itemString[i];
                        }
                    }
                    catch { 
                        itemList.Add(new Item(name.Trim(), Double.Parse(price)));
                        return itemList;
                    }

                    itemList.Add(new Item(name.Trim(),Double.Parse(price)));
                    name = "";
                    price = "";

                }
            }

            return itemList;
        }
    }

}
