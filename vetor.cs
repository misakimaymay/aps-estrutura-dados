using System;

namespace Vetor
{
    class Vector
    {
        private int[] elements;
        private int size;
        private int capacity;

        public Vector(int capacity)
        {
            this.capacity = capacity;
            elements = new int[capacity];
            size = 0;
        }

        public void Insert(int value)
        {
            if (size >= capacity)
            {
                Console.WriteLine("Vector is full. Cannot insert more elements.");
                return;
            }
            elements[size] = value;
            size++;
            Console.WriteLine("Element inserted successfully.");
        }

        public void Remove(int value)
        {
            int index = Search(value);
            if (index == -1)
            {
                Console.WriteLine("Element not found. Cannot remove.");
                return;
            }

            for (int i = index; i < size - 1; i++)
            {
                elements[i] = elements[i + 1];
            }

            size--;
            Console.WriteLine("Element removed successfully.");
        }

        public void Display()
        {
            if (size == 0)
            {
                Console.WriteLine("Vector is empty.");
                return;
            }

            Console.Write("Elements in the vector: ");
            for (int i = 0; i < size; i++)
            {
                Console.Write(elements[i] + " ");
            }
            Console.WriteLine();
        }

        public int Search(int value)
        {
            for (int i = 0; i < size; i++)
            {
                if (elements[i] == value)
                    return i;
            }
            return -1;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the capacity of the vector: ");
            int capacity = int.Parse(Console.ReadLine());

            Vector vector = new Vector(capacity);

            while (true)
            {
                Console.WriteLine("\n--- Submenu ---");
                Console.WriteLine("1. Insert element");
                Console.WriteLine("2. Remove element");
                Console.WriteLine("3. Display all elements");
                Console.WriteLine("4. Search for element");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter value to insert: ");
                        int insertValue = int.Parse(Console.ReadLine());
                        vector.Insert(insertValue);
                        break;

                    case "2":
                        Console.Write("Enter value to remove: ");
                        int removeValue = int.Parse(Console.ReadLine());
                        vector.Remove(removeValue);
                        break;

                    case "3":
                        vector.Display();
                        break;

                    case "4":
                        Console.Write("Enter value to search: ");
                        int searchValue = int.Parse(Console.ReadLine());
                        int position = vector.Search(searchValue);
                        if (position != -1)
                            Console.WriteLine($"Element {searchValue} found at position {position}.");
                        else
                            Console.WriteLine("Element not found.");
                        break;

                    case "5":
                        Console.WriteLine("Exiting program...");
                        return;

                    default:
                        Console.WriteLine("Invalid option. Try again.");
                        break;
                }
            }
        }
    }
}