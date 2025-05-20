using System;
using System.Collections.Generic;

namespace StackApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<char> stack = new Stack<char>();
            char option;

            do
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1 - Push element");
                Console.WriteLine("2 - Pop element");
                Console.WriteLine("3 - Display elements");
                Console.WriteLine("4 - Show top element");
                Console.WriteLine("5 - Show size");
                Console.WriteLine("0 - Exit");
                option = Console.ReadKey().KeyChar;
                Console.WriteLine();

                switch (option)
                {
                    case '1':
                        Console.WriteLine("Enter a character to push: ");
                        char character = Console.ReadKey().KeyChar;
                        Console.WriteLine();
                        stack.Push(character);
                        break;
                    case '2':
                        if (stack.Count > 0)
                        {
                            Console.WriteLine("Popped element: " + stack.Pop());
                        }
                        else
                        {
                            Console.WriteLine("Stack is empty! >:(");
                        }
                        break;
                    case '3':
                        if (stack.Count == 0)
                        {
                            Console.WriteLine("Stack is empty! >:(");
                        }
                        else
                        {
                            Console.WriteLine("Stack:");
                            foreach (var item in stack)
                            {
                                Console.WriteLine(" " + item);
                            }
                        }
                        break;
                    case '4':
                        if (stack.Count > 0)
                        {
                            Console.WriteLine("Top of the stack: " + stack.Peek());
                        }
                        else
                        {
                            Console.WriteLine("Stack is empty! >:(");
                        }
                        break;
                    case '5':
                        Console.WriteLine("Stack size: " + stack.Count);
                        break;
                    case '0':
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.WriteLine("Invalid option! >:(");
                        break;
                }

                Console.WriteLine();

            } while (option != '0');
        }
    }
}
