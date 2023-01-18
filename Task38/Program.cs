// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

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

int getDifferenceMaxMin (int[] arr)
{
    int max = arr[0];
    int min = arr[0];
    int difference = -1;

    for (int i=0; i< arr.Length; i++)
    {
        if (arr[i]>max) max = arr[i];
        else if (arr[i]<min) min = arr[i];
    }
    difference = max - min;
    return difference;
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
int[] array = generateArray(lenght, -10, 10);
int result = getDifferenceMaxMin(array);

showArray(array);
Console.WriteLine($"  -> разница между max и min элементами массива: {result}");