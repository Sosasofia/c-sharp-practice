using System;

int[] BubbleSortOnce(int[] input)
{
    // Code the Bubblesort Algorithm here :D
    int[] sortedArray = new int[input.Length];
    Array.Copy(input, sortedArray, input.Length);

    for (int i = 0; i < sortedArray.Length - 1; i++)
    {
        if (sortedArray[i] > sortedArray[i + 1])
        {
            int aux = sortedArray[i];
            sortedArray[i] = sortedArray[i + 1];
            sortedArray[i + 1] = aux;
        }
    }

    return sortedArray;
}

int[] testArray = [9, 7, 5, 3, 1, 2, 4, 6, 8];

foreach (int num in testArray)
{
    Console.Write(num);
    Console.Write(" ");
}

int[] arrayOrdenado = BubbleSortOnce(testArray);
Console.WriteLine();

foreach (int num in arrayOrdenado)
{
    Console.Write(num);
    Console.Write(" ");
}