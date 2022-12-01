// Задать одномерный массив, заполненный случайными числами.
// Найти сумму элементов, стоящих на нечётных позициях
// Так как в условиях задачи не указано, какие именно числа в массиве
// Я приняла решение, дать пользователю право самому заполнить минимальное и максимальное числа

Console.WriteLine("Введите размер массива ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное число массива ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное число массива ");
int max = Convert.ToInt32(Console.ReadLine());

// Метод, заполняющий массив

void FillArrRandom(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max);
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


int[] array = new int[size];

FillArrRandom(array);
PrintArr(array);
int result = 0;
for(int i = 0; i < array.Length; i++)
{
    if(i % 2 != 0)
    {
        result += array[i];
    }
}

Console.WriteLine($"Сумма элементов нечетных позиций = {result}");