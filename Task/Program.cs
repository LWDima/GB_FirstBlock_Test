using static System.Console;
Clear();
WriteLine("Введите значения массива через пробел' ' ");
string[] readArray = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
string[] finalArray = new string[readArray.Length];
SearchThreeChar(readArray, finalArray);
PrintArray(finalArray);



void SearchThreeChar(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[count] = array1[i];
            count++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
