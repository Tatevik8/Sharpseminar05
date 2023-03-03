//**Задача 34**: Задайте массив заполненный 
//случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

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

void NumberOfEvenNumbers(int[] array, out int NumberOfEvenNumbers)
{
    NumberOfEvenNumbers = 0;
    for (int i = 0; i < array.Length; i++)
    if (array[i]%2==0)
    NumberOfEvenNumbers=NumberOfEvenNumbers+1;
}

const int SIZE = 10;
const int LEFT_RANGE = 100;
const int RIGHT_RANGE = 999;
var myArray = GenerateArray(SIZE, LEFT_RANGE, RIGHT_RANGE);
PrintArray(myArray);
NumberOfEvenNumbers(myArray, out int Evennumbers);
System.Console.WriteLine($"Количество чётных чисел в массиве: {Evennumbers}");