// Задайте массив целых чисел. Найдите разницу
// между максимальным и минимальным элементами массива
// [3.22,4.2,1.15,77.15,65.2] => 77.15 - 1.15 = 76

int size = Prompt("Введите размерность массива: ");
int minValue = Prompt("Введите минимальное число диапазона массива: ");
int maxValue = Prompt("Введите максимальное число диапазона массива: ");
int[] array = GetArray(size,minValue,maxValue); 
PrintArray(array); 
int max = array[0];
int min = array[0];
GetMax(max);
GetMin(min);
Console.Write($"{max} - {min} = {max-min}");

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
        result[i] = new Random().Next(minValue,maxValue+1);
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
    Console.Write($"] ->");
}

int GetMax(int max)
{
    max = array[0];
    for(int i=0;i<array.Length;i++)
    {
        while(i>0 && i<array.Length)
        {
            if(max<array[i])
            {
                 max=array[i];
            }
        }
    }
    return max;
}

int GetMin(int min)
{
    min = array[0];
   for(int j=0;j<array.Length;j++)
   {
       while(j>0 && j<array.Length)
       {
          if(min>array.Length)
          {
            min = array[j];
          } 
       }
    }
    return min;
}




