// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
/*
int MathPow(int num, int pow)
{
    int result = num;
    int current = 1;
    while (current < pow)
    {
        result = result * num;
        current++;
    }
    return result;

}
Console.Write("Input A: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Input B: ");
int stp = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{number}, {stp} -> {MathPow(number, stp)}");
*/
// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

/*
int DigitSum(int number)
{ 
    int sum = 0;
    while (number > 0)
    {   
    int ost = number % 10;
    number = number / 10;
    sum = sum + ost;
    }
    return sum;
}
Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{num} -> {DigitSum(num)}");


/*
Console.WriteLine("введите число");
int i = Convert.ToInt32(Console.ReadLine());
int sum = 0;

while (i > 0)
{
int num = i % 10;
i = i / 10;
sum = sum + num;
}
Console.WriteLine("сумма всех цифр в числе равна: " + sum);
*/

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
/*
int[] NewArray(int size, int minValue, int maxValue) // Генерирует любой рандомный массив. 
{
    int[] newArray = new int[size];

    for(int i = 0; i < size; i++) //i = i + 2
        newArray[i] = new Random().Next(minValue, maxValue + 1);

    return newArray;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i ++)
        Console.Write(array[i] + " ");

    Console.WriteLine();    
}

// ShowArray(CreateRandomArray(8, 0, 1));
ShowArray(NewArray(4, 0, 10));
*/
/*
int[] NewArray(int size) 
{
    int[] newArray = new int[size];

    for(int i = 0; i < size; i++) 
    {
        Console.Write("введите элементы массива: ");
        int J = Convert.ToInt32(Console.ReadLine());
        newArray[i] = Convert.ToInt32(J);
    }

    return newArray;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i ++)
        Console.Write(array[i] + " ");

    Console.WriteLine();    
}

ShowArray(NewArray(8));
*/
