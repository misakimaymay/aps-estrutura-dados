using System;
using System.Collections.Generic;

namespace SearchAlgorithmsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            int option;

            do
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1 - Insert element");
                Console.WriteLine("2 - Remove element");
                Console.WriteLine("3 - Display elements");
                Console.WriteLine("4 - Search element");
                Console.WriteLine("0 - Exit");
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.Write("Enter the value to insert: ");
                        int insertValue = int.Parse(Console.ReadLine());
                        list.Add(insertValue);
                        break;
                    case 2:
                        Console.Write("Enter the value to remove: ");
                        int removeValue = int.Parse(Console.ReadLine());
                        if (list.Contains(removeValue))
                        {
                            list.Remove(removeValue);
                            Console.WriteLine("Element removed.");
                        }
                        else
                        {
                            Console.WriteLine("Element not found.");
                        }
                        break;
                    case 3:
                        if (list.Count == 0)
                        {
                            Console.WriteLine("List is empty.");
                        }
                        else
                        {
                            Console.WriteLine("Elements in the list:");
                            foreach (var item in list)
                            {
                                Console.Write(item + " ");
                            }
                            Console.WriteLine();
                        }
                        break;
                    case 4:
                        Console.Write("Enter the value to search: ");
                        int searchValue = int.Parse(Console.ReadLine());
                        int index = list.IndexOf(searchValue);
                        if (index != -1)
                        {
                            Console.WriteLine("Element found at position: " + index);
                        }
                        else
                        {
                            Console.WriteLine("Element not found.");
                        }
                        break;
                    case 0:
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }

                Console.WriteLine();

            } while (option != 0);
        }
    }
}
