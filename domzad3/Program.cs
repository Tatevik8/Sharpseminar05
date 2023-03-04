// **Задача 38:** Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

void GenerateArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
        {
            array[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
}

void PrintArray(double[] arr)
{
    System.Console.WriteLine("[" + string.Join("; ", arr) + "]");
}

Console.Write("Введите размер массива:  ");
int size = Convert.ToInt32(Console.ReadLine());
double[] myArray = new double[size];
GenerateArray(myArray);
PrintArray(myArray);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int i = 0; i < myArray.Length; i++)
{
    if (myArray[i] > max)
        {
            max = myArray[i];
        }
    if (myArray[i] < min)
        {
            min = myArray[i];
        }
}

Console.WriteLine($"Максимальное число = {max}. Минимальное число = {min}");
Console.WriteLine($"Разница между максимальным и минимальным элементов массива = {max - min}");