using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace PointerList
{
    class Node
    {
        public char Value;
        public Node Next;

        public Node(char value)
        {
            Value = value;
            Next = null;
        }
    }

    class DynamicList
    {
        private Node start;
        public DynamicList()
        {
            start = null;
        }

        public void Insert(char value)
        {
            Node newNode = new Node(value);
            if (start == null)
            {
                start = newNode;
            }
            else
            {
                Node current = start;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
        }

        public void InsertAtPosition(int position, char value)
        {
            Node newNode = new Node(value);
            if (position == 0)
            {
                newNode.Next = start;
                start = newNode;
                return;
            }

            Node current = start;
            for (int i = 0; i < position - 1; i++)
            {
                if (current == null)
                {
                    Console.WriteLine("Invalid position!");
                    return;
                }
                current = current.Next;
            }
            if (current == null)
            {
                Console.WriteLine("Invalid position!");
                return;
            }
            newNode.Next = current.Next;
            current.Next = newNode;
        }

        public void Remove(int position)
        {
            if (start == null)
            {
                Console.WriteLine("List is empty!");
                return;
            }
            if (position == 0)
            {
                start = start.Next;
                return;
            }
            Node current = start;
            for (int i = 0; i < position - 1; i++)
            {
                if (current.Next == null)
                {
                    Console.WriteLine("Invalid position!");
                    return;
                }
                current = current.Next;
            }
            if (current.Next == null)
            {
                Console.WriteLine("Invalid position!");
                return;
            }
            current.Next = current.Next.Next;
        }

        public void Display()
        {
            if (start == null)
            {
                Console.WriteLine("List is empty!");
                return;
            }

            Console.Write("List: ");
            Node current = start;
            while (current != null)
            {
                Console.Write(current.Value + " ");
                current = current.Next;
            }
            Console.WriteLine();
        }

        public char ElementAtPosition(int position)
        {
            Node current = start;
            int count = 0;

            while (current != null)
            {
                if (count == position)
                {
                    return current.Value;
                }
                current = current.Next;
                count++;
            }
            Console.WriteLine("Invalid position!");
            return '\0';
        }

        public int Size()
        {
            int count = 0;
            Node current = start;
            while (current != null)
            {
                count++;
                current = current.Next;
            }
            return count;
        }

        public bool Empty()
        {
            return start == null;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            DynamicList list = new DynamicList();
            int option;
            char value;
            int position;

            do
            {
                Console.WriteLine("Dynamic Linked List");
                Console.WriteLine("0 Exit");
                Console.WriteLine("1 Insert");
                Console.WriteLine("2 Insert at specific position");
                Console.WriteLine("3 Remove by position");
                Console.WriteLine("4 Size");
                Console.WriteLine("5 Display list");
                Console.WriteLine("6 Display item at specific position");
                Console.WriteLine("Choose an option");
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 0:
                        Console.WriteLine("Exiting...");
                        break;
                    case 1:
                        Console.WriteLine("Enter value");
                        value = Console.ReadKey().KeyChar;
                        Console.WriteLine();
                        list.Insert(value);
                        break;
                    case 2:
                        Console.WriteLine("Enter position");
                        position = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter value");
                        value = Console.ReadKey().KeyChar;
                        Console.WriteLine();
                        list.InsertAtPosition(position, value);
                        break;
                    case 3:
                        Console.WriteLine("Enter position to remove");
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
                        Console.WriteLine("Enter position");
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
