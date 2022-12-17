int [] array = {1, 2, 3, 100, 324, 343, 44, 6, 33, 100};

int n = array.Length;
int find = 100;
int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }

    index += 1;
}