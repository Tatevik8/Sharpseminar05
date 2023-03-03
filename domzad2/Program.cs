// **Задача 36:** Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] GenerateArray(int size, int leftRange, int rightRange)
{
    int[] array = new int[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rand.Next(leftRange, rightRange + 1); 
    }
    return array;
}

void PrintArray(int[] array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}

void SumOfNumbersOnEvenPosition(int[] array, out int SumEven)
{
    SumEven = 0;
    for (int i = 1; i < array.Length; i=i+2)
    SumEven += array[i];
}

const int SIZE = 9;
const int LEFT_RANGE = -101;
const int RIGHT_RANGE = 99;
var myArray = GenerateArray(SIZE, LEFT_RANGE, RIGHT_RANGE);
PrintArray(myArray);
SumOfNumbersOnEvenPosition(myArray, out int sumE);
System.Console.WriteLine($"Сумма элементов, стоящих на чётной позиции': {sumE}");