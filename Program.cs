/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
*/

/*
int ReadInt (string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int size = ReadInt("введите массив");
int [] number = new int [size];

ArrayRandomNumber(number);
PrintArray(number);
int result = 0;

for (int i = 0; i < number.Length; i++)
{
    if (number[i] % 2 == 0)
    {
        result++;
    }
}

if (result %10 == 1)
{
    Console.WriteLine($"в массиве {result} четное число");
}

if (result % 10 == 2 || result % 10 == 3 || result % 10 == 4)
{
    Console.WriteLine($"в массиве {result} четных чисел");
}
else
{
    Console.WriteLine($"в массиве {result} четных чисел");
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "" );
    }
    Console.WriteLine();
}

void ArrayRandomNumber(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(99,1000);
    }
}
*/

/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
*/

/*
int ReadInt (string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int size = ReadInt("введите размер массива");
int min = ReadInt("введите минимальное число массива");
int max = ReadInt("введите максимально число массива");
int [] number = new int[size];

ArrayRandomNumber(number);
PrintArray(number);

int maxArray = number[0];
int minArray = number[0];

for (int i = 0; i < number.Length; i++)
{
    if (number[i] > maxArray)
    {
        maxArray = number[i];
    }
    if (number[i] < minArray)
    {
        minArray = number[i];
    }
}
Console.WriteLine($"разница = {maxArray - minArray}");


void ArrayRandomNumber(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max);
    }
}

void PrintArray (int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
*/

/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
*/

int ReadInt (string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int size = ReadInt("введите размер массива");
int min = ReadInt("введите минимальное число массива");
int max = ReadInt("введите максимально число массива");
int [] number = new int[size];

ArrayRandomNumber(number);
PrintArray(number);
int result = 0;

for (int i = 0; i < number.Length; i++)
{
    if (i % 2 != 0)
    {
        result += number[i];
    }
}
Console.WriteLine($"нечетные позиции {result} ");


void ArrayRandomNumber(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max);
    }
}

void PrintArray (int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}


