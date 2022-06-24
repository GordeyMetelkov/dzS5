// Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.;
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
void summa (int [] currentArray)
{
    int sum = 0;
    for (int i = 0; i < currentArray.Length; i++)
    {
    if (currentArray[i] %2 == 1) sum+=currentArray[i];
    }
    Console.WriteLine("Сумма всех нечетных элементов в массиве равна " + sum);
}
Console.WriteLine("Введите количество элементов массива");
int size = Convert.ToInt32(Console.ReadLine());
int [] array = new int[size];
setArray(array, 1, 100);
Print(array);
summa(array);