using System;

namespace MatrixSubmenuApp
{
    class Matrix
    {
        private int[,] elements;
        private int rows;
        private int cols;

        public Matrix(int rows, int cols)
        {
            this.rows = rows;
            this.cols = cols;
            elements = new int[rows, cols];

            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    elements[i, j] = int.MinValue;
        }

        public void Insert(int row, int col, int value)
        {
            if (IsValidPosition(row, col))
            {
                elements[row, col] = value;
                Console.WriteLine("Element inserted successfully.");
            }
            else
            {
                Console.WriteLine("Invalid position.");
            }
        }

        public void Remove(int row, int col)
        {
            if (IsValidPosition(row, col))
            {
                elements[row, col] = int.MinValue;
                Console.WriteLine("Element removed successfully.");
            }
            else
            {
                Console.WriteLine("Invalid position.");
            }
        }

        public void Display()
        {
            Console.WriteLine("Matrix:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (elements[i, j] == int.MinValue)
                        Console.Write("[ ] ");
                    else
                        Console.Write($"[{elements[i, j]}] ");
                }
                Console.WriteLine();
            }
        }

        public void Search(int value)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (elements[i, j] == value)
                    {
                        Console.WriteLine($"Element {value} found at position ({i}, {j}).");
                        return;
                    }
                }
            }
            Console.WriteLine("Element not found.");
        }

        private bool IsValidPosition(int row, int col)
        {
            return row >= 0 && row < rows && col >= 0 && col < cols;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of rows: ");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("Enter number of columns: ");
            int cols = int.Parse(Console.ReadLine());

            Matrix matrix = new Matrix(rows, cols);

            while (true)
            {
                Console.WriteLine("\n--- Matrix Submenu ---");
                Console.WriteLine("1. Insert element");
                Console.WriteLine("2. Remove element");
                Console.WriteLine("3. Display all elements");
                Console.WriteLine("4. Search for an element");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter row index: ");
                        int insertRow = int.Parse(Console.ReadLine());

                        Console.Write("Enter column index: ");
                        int insertCol = int.Parse(Console.ReadLine());

                        Console.Write("Enter value: ");
                        int value = int.Parse(Console.ReadLine());

                        matrix.Insert(insertRow, insertCol, value);
                        break;

                    case "2":
                        Console.Write("Enter row index to remove: ");
                        int removeRow = int.Parse(Console.ReadLine());

                        Console.Write("Enter column index to remove: ");
                        int removeCol = int.Parse(Console.ReadLine());

                        matrix.Remove(removeRow, removeCol);
                        break;

                    case "3":
                        matrix.Display();
                        break;

                    case "4":
                        Console.Write("Enter value to search: ");
                        int searchValue = int.Parse(Console.ReadLine());

                        matrix.Search(searchValue);
                        break;

                    case "5":
                        Console.WriteLine("Exiting program...");
                        return;

                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }
    }
}
