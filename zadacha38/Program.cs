// Задайте массив вещественных чисел.
//Найдите разницу между максимальным и минимальным элементов массива;
void setArray(double [] currentArray, int start, int end)
{
    Random rand = new Random();
    for (int i = 0; i < currentArray.Length; i++)
    {
        currentArray[i] = rand.Next(start, end);
    }
}
void Print (double [] currentArray)
{
    Console.WriteLine();
    Console.WriteLine("Вывод массива на печать:");
    for (int i = 0; i < currentArray.Length; i++)
    {
        Console.Write(currentArray[i] + "\t");
    }
    Console.WriteLine();
}
void diff (double [] currentArray)
{
    double min = currentArray[0];
    double max = currentArray[0];
    for (int i = 1; i < currentArray.Length; i++)
    {
    if (currentArray[i] > max) max = currentArray[i];
    else if (currentArray[i] < min) min = currentArray[i];
    }
    Console.WriteLine($"Разница между максимальным и минимальным элементом массива равна {max-min}");
}
Console.WriteLine("Введите количество элементов массива");
int size = Convert.ToInt32(Console.ReadLine());
double [] array = new double [size];
setArray(array, 1, 100);
Print(array);
diff(array);