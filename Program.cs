/*Задача 36: Задайте одномерный массив, заполненный случайными числами.
 Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0*/
int[] generateArray(int length, int start, int end)
{
    int[] result = new int[length];
    for (int i = 0; i < length; i++)
    {
        result[i] = new Random().Next(start, end + 1);
    }
    return result;
}

int SumOfNechet(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            result = result + array[i];
        }

    }
    return result;
}
void printArray(int[] array)
{
    string result = "[";
    for (int i = 0; i < array.Length; i++)
    {
        result = result + array[i] + ",";
    }
    result = result[..^1] + "]";
    Console.WriteLine(result);
}
int getUserDate(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine(message);
    Console.ResetColor();
    int UserData = int.Parse(Console.ReadLine()!);
    return UserData;
}

int length = getUserDate("Введите число элементов массива");
int start = getUserDate("Введите начало диапазона");
int end = getUserDate("Введите конец диапазона");
int[] array = generateArray(length, start, end);
printArray(array);
int num = SumOfNechet(array);
Console.Write(num);


