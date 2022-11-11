string[] array1 = new string[] {"123", "22", "hello", "world", "yes", "no", "long string"};
string[] array2 = new string[array1.Length];
void FilterForThree(string[] array1, string[] array2)
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
FilterForThree(array1, array2);