int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

//Console.WriteLine("Введите 1е число: ");
//int num1 = int.Parse(Console.ReadLine());
 
//Console.WriteLine("Введите 2е число: ");
//int num2 = int.Parse(Console.ReadLine());

//Console.WriteLine("Введите 3е число: ");
//int num3 = int.Parse(Console.ReadLine());

int [] array = {98,2,3,774,5,66,7,8,109};

int result = Max (  Max(array[0], array[1], array[2]),
                Max(array[3], array[4], array[5]),
                Max(array[6], array[7], array[8])
);

Console.WriteLine(result);
