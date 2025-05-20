using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSearchStatic
{
    public class StaticList<T> where T : IComparable<T>
    {
        private T[] elements;
        private int size;
        private int capacity;

        public StaticList(int capacity)
        {
            this.capacity = capacity;
            elements = new T[capacity];
            size = 0;
        }

        public void Insert(T value)
        {
            if (size == capacity)
            {
                Console.WriteLine("List is full! >:(");
                return;
            }
            elements[size] = value;
            size++;
        }

        public void Display()
        {
            if (size == 0)
            {
                Console.WriteLine("List is empty. :(");
                return;
            }
            Console.Write("List: ");
            for (int i = 0; i < size; i++)
            {
                Console.Write(elements[i] + " ");
            }
            Console.WriteLine();
        }

        public int SequentialSearch(T value)
        {
            for (int i = 0; i < size; i++)
            {
                if (elements[i].CompareTo(value) == 0)
                    return i;
            }
            return -1;
        }

        public int BinarySearch(T value)
        {
            int start = 0;
            int end = size - 1;

            while (start <= end)
            {
                int middle = (start + end) / 2;

                if (elements[middle].CompareTo(value) == 0)
                    return middle;

                if (elements[middle].CompareTo(value) > 0)
                    end = middle - 1;
                else
                    start = middle + 1;
            }
            return -1;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of elements in the list: ");
            int n = int.Parse(Console.ReadLine());

            StaticList<int> list = new StaticList<int>(n);

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter the {i + 1}th element: ");
                int value = int.Parse(Console.ReadLine());
                list.Insert(value);
            }

            list.Display();

            Console.WriteLine("Enter the value to search for:");
            int searchedElement = int.Parse(Console.ReadLine());

            int sequentialResult = list.SequentialSearch(searchedElement);
            if (sequentialResult != -1)
                Console.WriteLine($"Element {searchedElement} found at position {sequentialResult} - (Sequential Search)");
            else
                Console.WriteLine($"Element {searchedElement} not found - (Sequential Search)");

            int binaryResult = list.BinarySearch(searchedElement);
            if (binaryResult != -1)
                Console.WriteLine($"Element {searchedElement} found at position {binaryResult} - (Binary Search)");
            else
                Console.WriteLine($"Element {searchedElement} not found - (Binary Search)");
        }
    }
}
