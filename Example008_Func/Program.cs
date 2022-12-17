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

int a1 = 10;
int b1 = 20;
int c1 = 40;
int a2 =  2;
int b2 = 15;
int c2 = 4;
int a3 = 250;
int b3 = 1;
int c3 = 100;

int max1 = Max(a1, b1, c1);
int max2 = Max(a2, b2, c2);
int max3 = Max(a3, b3, c3);

Console.WriteLine(Max(max1, max2, max3));
