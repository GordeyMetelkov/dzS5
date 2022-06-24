//Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
void setArray(int[] currentArray, int start, int end)
{
    Random rand = new Random();
    for (int i = 0; i < currentArray.Length; i++)
    {
        currentArray[i] = rand.Next(start, end);
    }
}
void Print (int [] currentArray)
{
    Console.WriteLine();
    Console.WriteLine("Вывод массива на печать:");
    for (int i = 0; i < currentArray.Length; i++)
    {
        Console.Write(currentArray[i] + "\t");
    }
    Console.WriteLine();
}
Console.WriteLine("Введите количество элементов массива");
int size = Convert.ToInt32(Console.ReadLine());
int [] array = new int[size];
setArray(array, 100, 1000);
Print(array);
int count = 0;
for (int i = 0; i < array.Length; i++)
{
   if (array[i] %2 == 0) count++;
}
Console.WriteLine("Количество четных чисел в массиве равно " + count);