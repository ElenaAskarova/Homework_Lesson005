// Задать массив, заполненный случайными положительными трёхзначными числами. 
//Написать программу, которая покажет количество чётных чисел в массиве

//метод, заполняющий массив
void FillArrRandom(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(99, 999);
    }
}

//метод, печатающий массив
void PrintArr(int[] array)
{
    Console.Write("[");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}

Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrRandom(numbers);
Console.WriteLine("Массив: ");
PrintArr(numbers);
int result = 0;

for(int j = 0; j < numbers.Length; j++)
{
    if(numbers[j] % 2 == 0)
    {
        result++;
    }
}

Console.WriteLine($"Всего {numbers.Length} чисел, {result} из них четные");

