using System;

class Program
{
    static void Main()
    {
        int[] numbers = new int[10] { 3, 2, 1, 4, 6, 5, 8, 7, 9, 0 };
        Console.WriteLine("Initial array:");
        PrintArray(numbers);

        BubbleSort(numbers);

        Console.WriteLine("\nSorted array:");
        PrintArray(numbers);
    }

    static void BubbleSort(int[] numbers)
    {
        int n = numbers.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (numbers[j] > numbers[j + 1])
                {
                    int temp = numbers[j];
                    numbers[j] = numbers[j + 1];
                    numbers[j + 1] = temp;
                }
            }
        }
    }

    static void PrintArray(int[] arr)
    {
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}
