using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace StaticList
{
    public class List
    {
        private char[] elements;
        private int size;
        private int capacity;

        public List(int capacity)
        {
            this.capacity = capacity;
            elements = new char[capacity];
            size = 0;
        }

        public void Insert(char value)
        {
            if (size == capacity)
            {
                Console.WriteLine("List is full");
                return;
            }
            elements[size] = value;
            size++;
        }

        public void InsertAtPosition(int position, char value)
        {
            if (size == capacity)
            {
                Console.WriteLine("List is full");
                return;
            }
            if (position < 0 || position > size)
            {
                Console.WriteLine("Invalid position");
                return;
            }

            for (int i = size; i > position; i--)
            {
                elements[i] = elements[i - 1];
            }
            elements[position] = value;
            size++;
        }

        public void Remove(int position)
        {
            if (position < 0 || position >= size)
            {
                Console.WriteLine("Invalid position");
                return;
            }
            for (int i = position; i < size - 1; i++)
            {
                elements[i] = elements[i + 1];
            }
            size--;
        }

        public void Display()
        {
            if (size == 0)
            {
                Console.WriteLine("Empty");
                return;
            }
            Console.Write("List: ");
            for (int i = 0; i < size; i++)
            {
                Console.Write(elements[i] + " ");
            }
            Console.WriteLine();
        }

        public int Size()
        {
            return size;
        }

        public bool Empty()
        {
            return size == 0;
        }

        public char ElementAtPosition(int position)
        {
            if (position < 0 || position >= size)
            {
                Console.WriteLine("Invalid position");
                return '\0';
            }
            return elements[position];
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List list = new List(10);
            int option;
            char value;
            int position;

            do
            {
                Console.WriteLine("Static Linear List");
                Console.WriteLine("0 - Exit");
                Console.WriteLine("1 - Insert");
                Console.WriteLine("2 - Insert at specific position");
                Console.WriteLine("3 - Remove by position");
                Console.WriteLine("4 - Size");
                Console.WriteLine("5 - Display list");
                Console.WriteLine("6 - Show item at specific position");
                Console.WriteLine("Choose an option:");
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 0:
                        Console.WriteLine("Exiting");
                        break;
                    case 1:
                        Console.WriteLine("Enter the value:");
                        value = Console.ReadKey().KeyChar;
                        Console.WriteLine();
                        list.Insert(value);
                        break;
                    case 2:
                        Console.WriteLine("Enter position:");
                        position = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the value:");
                        value = Console.ReadKey().KeyChar;
                        Console.WriteLine();
                        list.InsertAtPosition(position, value);
                        break;
                    case 3:
                        Console.WriteLine("Enter position to remove:");
                        position = int.Parse(Console.ReadLine());
                        list.Remove(position);
                        break;
                    case 4:
                        Console.WriteLine("Current size: " + list.Size());
                        break;
                    case 5:
                        list.Display();
                        break;
                    case 6:
                        Console.WriteLine("Enter position:");
                        position = int.Parse(Console.ReadLine());
                        value = list.ElementAtPosition(position);
                        Console.WriteLine("Element: " + value);
                        break;
                    default:
                        break;
                }
            }
            while (option != 0);
        }
    }
}
