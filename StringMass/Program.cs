string[] array1 = new string[] {"123", "22", "hello", "world", "yes", "no", "long string"};
string[] array2 = new string[array1.Length];
void FilterForThree(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length < 4)
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
FilterForThree(array1, array2);
PrintArray(array2);