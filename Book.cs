using System;
using System.Collections.Generic;
using System.Text;

namespace Prov___modellering
{
    class Book
    {
        Random generator = new Random();

        string[] BookNames = { "Book1", "Book2", "Book3", "Book4" };
        string[] BookCategories = { "Architecture", "Cartography", "Relics", "History" };

        public int price;
        private string name;
        private int rarity;
        private string category;
        private int actualValue;
        private bool cursed;

        public Book()
        {
            int nameIndex = generator.Next(0, BookNames.Length);
            int categoryIndex = generator.Next(0, BookCategories.Length);
            int curseIndex = generator.Next(0, 2);
            string id = "#" + generator.Next(0, 2000).ToString();

            name = BookNames[nameIndex] + id;
            category = BookCategories[categoryIndex];
            
            actualValue = generator.Next(1, 101);
            rarity = generator.Next(1, 101);

            if (curseIndex > 0)
            {
                cursed = true;
            }
            else
            {
                cursed = false;
            }
        }

        public void PrintInfo()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Rarity: " + rarity);
            Console.WriteLine("Category: " + category);
            Console.WriteLine("Price: " + price);
        }

        public int Evaluate()
        {
            //Multiplicerar actualValue och rarity i variablen actualPrice
            int actualPrice = actualValue * rarity;
            //skapar en double array som innhåller 50%, 100% 0ch 100% av actualPrice
            double[] random = { (actualPrice * 0.5), (actualPrice * 1), (actualPrice * 1.5) };
            int index = generator.Next(0, random.Length);

            // Converterar doublen till en inte och returnerar den
            return Convert.ToInt32(random[index]);
        }

        public string GetCategory()
        {
            return category;
        }

        public string GetName()
        {
            return name;
        }

        public bool IsCursed()
        {
            int r = generator.Next(1, 101);

            if (r <= 80)
            {
                return cursed;
            }
            else
            {
                return !cursed;
            }
        }
        
    }
}
