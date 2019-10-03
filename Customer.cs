using System;
using System.Collections.Generic;
using System.Text;

namespace Prov___modellering
{
    class Customer
    {
        Random generator = new Random();

        string[] CustomerNames = { "John", "Anna", "Eric", "Claire" };
        string[] CustomerCategories = { "Architecture", "Cartography", "Relics", "History" };

        string name;
        int money;
        string favoriteCategory;

        public Customer()
        {
            // Genererar ett nummer mellan 0 och längden på arrayen
            int nameIndex = generator.Next(0, CustomerNames.Length);
            int categoryIndex = generator.Next(0, CustomerCategories.Length);

            //ett id nummer som jag använder för att skilja på instanserna eftersom att jag har få namn i arrayen och flera instanser kan få samma namn
            string id = "#" + generator.Next(0, 2000).ToString();

            name = CustomerNames[nameIndex] + id;
            favoriteCategory = CustomerCategories[categoryIndex];

            money = generator.Next(1, 101);
        }

        public void PrintInfo()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Money: " + money);
            Console.WriteLine("Favorite Category: " + favoriteCategory);
        }

        //Returnerar värdena av variabler som är privata
        public string GetFavoriteCategory()
        {
            return favoriteCategory;
        }

        public int GetFunds()
        {
            return money;
        }

        public string GetName()
        {
            return name;
        }
    }
}
