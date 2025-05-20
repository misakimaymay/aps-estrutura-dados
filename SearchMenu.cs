using System;
using System.Collections.Generic;

namespace SearchMenuApp
{
    internal class Program
    {
        static List<int> elements = new List<int>();

        static void Main(string[] args)
        {
            int mainOption;

            do
            {
                Console.WriteLine("Main Menu:");
                Console.WriteLine("1 - Manage Elements");
                Console.WriteLine("0 - Exit Program");
                Console.Write("Choose an option: ");
                mainOption = int.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (mainOption)
                {
                    case 1:
                        ManageElements();
                        break;
                    case 0:
                        Console.WriteLine("Program ended.");
                        break;
                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }

                Console.WriteLine();

            } while (mainOption != 0);
        }

        static void ManageElements()
        {
            int option;

            do
            {
                Console.WriteLine("Element Menu:");
                Console.WriteLine("1 - Insert Element");
                Console.WriteLine("2 - Remove Element");
                Console.WriteLine("3 - Display All Elements");
                Console.WriteLine("4 - Search Element");
                Console.WriteLine("9 - Return to Main Menu");
                Console.Write("Choose an option: ");
                option = int.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (option)
                {
                    case 1:
                        Console.Write("Enter a value to insert: ");
                        int value = int.Parse(Console.ReadLine());
                        elements.Add(value);
                        Console.WriteLine("Element inserted.");
                        break;
                    case 2:
                        Console.Write("Enter a value to remove: ");
                        int remove = int.Parse(Console.ReadLine());
                        if (elements.Remove(remove))
                            Console.WriteLine("Element removed.");
                        else
                            Console.WriteLine("Element not found.");
                        break;
                    case 3:
                        if (elements.Count == 0)
                            Console.WriteLine("No elements in the list.");
                        else
                        {
                            Console.WriteLine("Elements:");
                            foreach (int el in elements)
                                Console.Write(el + " ");
                            Console.WriteLine();
                        }
                        break;
                    case 4:
                        Console.Write("Enter a value to search: ");
                        int search = int.Parse(Console.ReadLine());
                        int index = elements.IndexOf(search);
                        if (index != -1)
                            Console.WriteLine($"Element found at position {index}.");
                        else
                            Console.WriteLine("Element not found.");
                        break;
                    case 9:
                        Console.WriteLine("Returning to Main Menu...");
                        break;
                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }

                Console.WriteLine();

            } while (option != 9);
        }
    }
}
