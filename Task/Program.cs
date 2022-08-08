//Практическая задача.
string[] array1 = {"Russia", "Denmark", "Kazan"};
string[] array2 = new string[array1.Length];
void NewArray(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
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
        if (i == 0) Console.Write("[");
        if (i < array.Length - 1) Console.Write(array[i] + " ");
        else Console.Write(array[i] + "]");
    }
    Console.WriteLine();
}
NewArray(array1, array2);
Console.Write($"Исходный массив: ");
PrintArray(array1);
Console.Write($"Итоговый массив: ");
PrintArray(array2);

