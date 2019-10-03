using System;
using System.Collections.Generic;

namespace Prov___modellering
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Customer> Customers = new List<Customer>();
            List<Book> Books = new List<Book>();

            string input;
            int amount;

            Console.WriteLine("How many customers do you want to generate?\n");
            Console.Write("> ");
            input = Console.ReadLine();
            while(!int.TryParse(input, out amount))
            {
                Console.Write("> ");
                input = Console.ReadLine();
            }

            for (int i = 0; i < amount; i++)
            {
                Customer customer = new Customer();
                Customers.Add(customer);
            }

            Console.Clear();
            Console.WriteLine("How many books do you want to sell?\n");
            Console.Write("> ");
            input = Console.ReadLine();
            while (!int.TryParse(input, out amount))
            {
                Console.Write("> ");
                input = Console.ReadLine();
            }

            for (int i = 0; i < amount; i++)
            {
                Book book = new Book();
                Books.Add(book);
            }

            Console.Clear();

            while(Books.Count > 0)
            {
                Console.Clear();

                Console.WriteLine("Store\n");

                Console.WriteLine("- Check inventory");
                Console.WriteLine("- Show customers");
                Console.WriteLine("- Check books\n");

                Console.Write("> ");
                input = Console.ReadLine();
                Console.Clear();
                if (input.ToLower().Contains("inventory") || input.ToLower().Contains("check"))
                {
                    Console.Clear();
                    Console.WriteLine("Inventory\n");
                    Console.WriteLine("Books in stock: " + Books.Count);
                }
                else if (input.ToLower().Contains("customers") || input.ToLower().Contains("show"))
                {
                    input = CheckCustomers(Customers);
                }
                else if (input.ToLower().Contains("books"))
                {
                    input = CheckBooks(Books);
                }

                Console.ReadLine();
            }
        }

        private static string CheckCustomers(List<Customer> Customers)
        {
            string input;
            Console.Clear();
            foreach (Customer c in Customers)
            {
                Console.WriteLine(c.GetName());
            }
            Console.WriteLine();
            Console.Write("> ");
            input = Console.ReadLine();
            Console.Clear();
            foreach (Customer c in Customers)
            {
                if (c.GetName().ToLower() == input.ToLower())
                {
                    c.PrintInfo();
                }
            }

            return input;
        }

        private static string CheckBooks(List<Book> Books)
        {
            string input;
            Console.Clear();
            foreach (Book b in Books)
            {
                Console.WriteLine(b.GetName());
            }
            Console.WriteLine();
            Console.Write("> ");
            input = Console.ReadLine();
            Console.Clear();
            foreach (Book b in Books)
            {
                if (b.GetName().ToLower() == input.ToLower())
                {
                    b.PrintInfo();
                }
            }

            return input;
        }
    }
}
