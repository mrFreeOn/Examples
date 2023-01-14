//

int[] arr = { 1, 2, 3, 2, 7, 8, 4, 2, 1 };

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int MaxPosition = i;
        for (int j = i + 1; j < array.Length; j++)
            if (array[j] > array[MaxPosition])
            {
                MaxPosition = j;
            }

        int temporary = array[i];
        array[i] = array[MaxPosition];
        array[MaxPosition] = temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);