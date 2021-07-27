using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;

namespace Lab3_2Replacement
{
    class Program
    {
        //public void Add(TKey key, TValue value);
        static bool KeepGoing()
        {
            
            while (true)
            {
                
                Console.WriteLine("Would you like make a further change to the menu?");
                
                string response = Console.ReadLine();
                response = response.ToLower();
                if (response == "y" || response == "yes")
                {
                    return true;
                }
                else if (response == "n" || response == "no")
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("Please enter y or n");
                }
            }
        }
        // static string ConvertStringToTitleCase(string text)
        // {
        //     CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture;
        //     TextInfo textInfo = cultureInfo.TextInfo;
        //     return textInfo.ToTitleCase(text);
        // }
        static void Main(string[] args)
        {
            Dictionary<string, string> items = new Dictionary<string, string>();
            items["Reuben"] = "$12.95";
            items["Lobster"] = "$27.95";
            items["Orange Julius"] = "$3.95";
            items["Creme Brulee"] = "$6.95";
            Console.WriteLine("Welcome to the Devbuild Deli Counter!");

            Console.WriteLine("Here is the menu and prices!");
            Console.WriteLine("");
            foreach (var pair in items)
            {
                Console.WriteLine($"{pair.Key} {pair.Value}");
                Console.WriteLine();
            }
            Console.WriteLine("You have the option to update the menu!  You can add remove and even change the price of items! Please let me know what you want to do!");
            do
            {                
                Console.Write("Please press A to add an item, R to remove an item, C to change and item or Q to quit: ");
                bool categoryOK = false;             
                while (categoryOK == false)
                {

                    
                    string choice = Console.ReadLine();

                    if (choice.ToLower() == "a")
                    {
                        Console.Write("Which item would you like to add? ");
                        string food = Console.ReadLine();
                        categoryOK = true;
                        if (items.ContainsKey(food))
                        {
                            Console.Write("That item already exists! Please enter a different item.");
                            Console.WriteLine("");
                        }
                        else
                        {
                            Console.Write("What is this items price? ");
                            string price = Console.ReadLine();
                            Console.WriteLine("");
                            items[food] = $"${price}";
                        }


                    }
                    else if (choice.ToLower() == "r")
                    {

                        Console.WriteLine("Which item would you like to remove?");
                        Console.Write("Please enter the name of the item. ");
                        items.Remove(Console.ReadLine());
                        Console.WriteLine("");
                        categoryOK = true;
                    }
                    else if (choice.ToLower() == "c")
                    {
                        categoryOK = true;
                        Console.Write("Which item would you like to change the price of? ");
                        string food = Console.ReadLine();
                        // ConvertStringToTitleCase(food);
                        Console.Write("What is this items new price?" );
                        string price = Console.ReadLine();
                        items[food] = $"${price}";
                    }
                    else if (choice.ToLower() == "q")
                    {
                        categoryOK = true;
                        Console.WriteLine("Thank you for viewing the menu!");
                    }
                    else
                    {
                        categoryOK = false;
                        Console.WriteLine("Please press A to add an item, R to remove an item, C to change and item or Q to quit:");
                    }


                }
                Console.WriteLine("Here is the updated menu and prices!");
                Console.WriteLine("**********************");
                foreach (var pair in items)
                {
                    Console.WriteLine($"{pair.Key} {pair.Value}");
                    Console.WriteLine();
                }
                Console.WriteLine("**********************");
            }
            while(KeepGoing());

        }
    }
}
