string[] startArray = new string[5] {"fff", "oooooo", "dd", "ccccc", "vv"};
string[] resultArray = new string[startArray.Length];

void ResultArrayWithIf(string[] array1, string[] array2)
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
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
ResultArrayWithIf(startArray, resultArray);
PrintArray(resultArray);