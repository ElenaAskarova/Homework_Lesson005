// Задать масиив вещественных чисел. 
// Найти разницу между максимальным и минимальным элементов массива

Console.WriteLine("Введите размер массива ");
int size = Convert.ToInt32(Console.ReadLine());


// Метод, заполняющий массив

void FillArrRandom(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 100);
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

int maxValue = array[0];
int minValue = array[0];

for(int i= 0; i < array.Length; i++)
{
    if(array[i] > maxValue) maxValue = array[i];
    if(array[i] < minValue) minValue = array[i];
}

Console.WriteLine($"Разница между максимальным и минимальным значением = {maxValue - minValue}");