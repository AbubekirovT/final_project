string[] LengthLessThan3 (string[] array)
{
    int count = default;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length < 4) count++;
    }
    string[] result = new string[count];
    int k = default;
    for (int j = 0; j < array.Length; j++)
    {
        if(array[j].Length < 4) 
        {
        result[k] = array[j];
        k++;
        }
    }
    return result;
}

void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} " );
    }
}

string[] arr = {"hello", "2", "world", ":-)", "123", "54321", "qwe"};
string[] res = LengthLessThan3(arr);
PrintArray(res);