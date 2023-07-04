// Задайте массив, заполненный случайными положительными трёхзначными
// числами. Напишите программу, которая покажет количество положительных
// чисел в массиве
// [345,897,568,234] -> 2

int size = Prompt("Введите размерность массива: ");
 int minValue = Prompt("Введите минимальное число из диапазона [100,999]");
int maxValue = Prompt("Введите максимальное число из диапазона [100,999]");
int[] array = GetArray(size,minValue,maxValue); 
PrintArray(array); 
GetSum(array);



int Prompt(string message)  
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine()!); 
    return number; 
}

int[] GetArray(int size,int minValue,int maxValue) 
{
    int[] result = new int[size];
    for(int i = 0;i<result.Length;i++)
    {
        result[i] = new Random().Next(minValue,maxValue + 1);
    }
    return result;
}

void PrintArray(int[] arr) 
{
    Console.Write("[");
    for(int i=0;i<arr.Length-1;i++)
    {
        Console.Write($"{arr[i]},");
    }
    Console.Write($"{arr[arr.Length-1]}");
    Console.Write("]");
}

void GetSum(int[] array)
{
int count=0;    
foreach(int el in array) 
{
    if (el%2==0)
    count ++;
} 
Console.Write($" -> {count}");
}


