//Практическая задача.
string[] firstArray = {"Russia", "Denmark", "Kazan"};
string[] secondArray = new string[firstArray.Length];
void NewArray(string[] firstArray, string[] secondArray)
{
    int j = 0;
    for (int i = 0; i < firstArray.Length; i++)
    {
    if(firstArray[i].Length <= 3)
        {
        secondArray[j] = firstArray[i];
        j++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < array.Length - 1) Console.Write(array[i] + " ");
        else Console.Write(array[i] + "]");
    }
    Console.WriteLine();
}
NewArray(firstArray, secondArray);
Console.Write($"Исходный массив: ");
PrintArray(firstArray);
Console.Write($"Итоговый массив: ");
PrintArray(secondArray);
