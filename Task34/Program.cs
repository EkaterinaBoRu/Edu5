// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int getUserData(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine(message);
    Console.ResetColor();
    int userData = int.Parse (Console.ReadLine()!);
    return userData;
}

int[] generateArray(int lenght, int start, int end)
{
    int[] result = new int[lenght];
    for (int i=0; i< lenght; i++)
    {
        result[i]= new Random().Next(start, end+1);
    }
    return result;
}

int countEvenNumber (int[] arr)
{
    int count=0;
    for (int i=0; i< arr.Length; i++)
    {
        if (arr[i]%2==0) count= count +1;
    }
    return count;
}

void showArray(int[] array)
{
    Console.Write($"[");
    for (int i=0; i<array.Length; i++)
    {
        if (i !=array.Length -1)
        {
            Console.Write($"{array[i]}, ");
        }
        else
        {
            Console.Write($"{array[i]}]");
        }
    }
}

int lenght = getUserData("Введите длину массива");
int[] array = generateArray(lenght, 100, 999);
int result = countEvenNumber (array);

showArray(array);
Console.WriteLine($"  -> четных {result}");
