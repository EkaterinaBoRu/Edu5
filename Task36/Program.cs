// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

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

int SumNumber (int[] arr)
{
    int summ = 0;
    {
        for (int i=0; i< arr.Length; i++)
        {
            if (i%2==1) summ= summ + arr[i];
        }
    }
    return summ;
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
int result  = SumNumber (array);

showArray(array);
Console.WriteLine($"  -> сумма элементов на нечетных позициях {result}");