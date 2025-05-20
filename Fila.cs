using System;

namespace QueueApp
{
    class Queue
    {
        private char[] elements;
        private int start;
        private int end;
        private int size;
        private int capacity;

        public Queue(int capacity)
        {
            this.capacity = capacity;
            elements = new char[capacity];
            start = 0;
            end = -1;
            size = 0;
        }

        public void Enqueue(char character)
        {
            if (size == capacity)
            {
                Console.WriteLine("Error: the queue is full! ( ｡ •`ᴖ´• ｡)");
                return;
            }
            end = (end + 1) % capacity;
            elements[end] = character;
            size++;
        }

        public char Dequeue()
        {
            if (Empty())
            {
                Console.WriteLine("The queue is empty! ૮₍⇀‸↼‶₎ა");
                return '\0';
            }
            char value = elements[start];
            start = (start + 1) % capacity;
            size--;
            return value;
        }

        public bool Empty()
        {
            return size == 0;
        }

        public void Display()
        {
            if (Empty())
            {
                Console.WriteLine("The queue is empty! ૮₍⇀‸↼‶₎ა");
                return;
            }
            Console.Write("Queue: ");
            for (int i = 0; i < size; i++)
            {
                int index = (start + i) % capacity;
                Console.Write(elements[index] + " ");
            }
            Console.WriteLine();
        }

        public int Size()
        {
            return size;
        }

        public char Head()
        {
            return elements[start];
        }
    }

    internal class Program
    {
        static void Main()
        {
            Queue queue = new Queue(10);
            int option;
            char value;

            do
            {
                Console.WriteLine("Choose an option: ");
                Console.WriteLine("0 . Exit");
                Console.WriteLine("1 . Enqueue");
                Console.WriteLine("2 . Head");
                Console.WriteLine("3 . Dequeue");
                Console.WriteLine("4 . Queue size");
                Console.WriteLine("5 . Display queue");
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 0:
                        Console.WriteLine(" ");
                        break;
                    case 1:
                        Console.WriteLine("Enter a value to enqueue: ");
                        value = Console.ReadKey().KeyChar;
                        Console.WriteLine();
                        queue.Enqueue(value);
                        break;
                    case 2:
                        value = queue.Head();
                        Console.WriteLine("Front of queue: " + value);
                        break;
                    case 3:
                        value = queue.Dequeue();
                        Console.WriteLine("Dequeued element: " + value);
                        break;
                    case 4:
                        Console.WriteLine("Number of elements in queue: " + queue.Size());
                        break;
                    case 5:
                        queue.Display();
                        break;
                    default:
                        Console.WriteLine("Invalid option! >:(");
                        break;
                }

            } while (option != 0);
        }
    }
}
