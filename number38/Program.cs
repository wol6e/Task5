// Задайте массив целых чисел. Найдите разницу
// между максимальным и минимальным элементами массива
// [3.22,4.2,1.15,77.15,65.2] => 77.15 - 1.15 = 76

double[] Begarray = GetArray(5); 
Console.WriteLine(string.Join("  ", Begarray));
Console.WriteLine($"Разница = {GetDifference(Begarray)}");

double[] GetArray(int size)
{
    double[] res = new double[size];
    for(int i = 0; i < size; i++)
    {
        res[i] = new Random().NextDouble() * 10 + new Random().Next(-100,100);
        res[i] = Math.Round(res[i], 3);
    }
    return res;
}

double GetDifference(double[] array)
{
    double max = array[0];
    double min = array[0];
    foreach(double el in array)
    {
        if (max < el) max = el;
        if (min > el) min = el; 
    }
    return max - min;
} 