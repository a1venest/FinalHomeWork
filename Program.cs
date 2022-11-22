string[] GetString()
{
    Console.WriteLine("Введите значения через запятую, по окончании ввода, нажмите Enter: ");
    return Console.ReadLine().Split(",");

}

int GetLength(string[] arr, int n)
{
    int length = 0;
    for (int k = 0; k < arr.Length; k++)
    {
        if (arr[k].Length <= n)
            length++;
    }
    return length;
}

string[] FindLes(string[] inputArray, int n)
{
    string[] result = new string[GetLength(inputArray, n)];
    for (int i = 0, j = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i].Length <= n)
        {
            result[j] = inputArray[i];
            j++;
        }
    }
    return result;
}

string[] FindLesOther(string[] inputArray, int n)
{
    string[] result = new string[GetLength(inputArray, n)];
    for (int i = 0, j = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i].Length > n)
        {
            result[j] = inputArray[i];
            j++;
        }
    }
    return result;
}

string[] input = GetString();
string[] output1 = FindLes(input, 3);
string[] output2 = FindLesOther(input, 3);

Console.WriteLine($"В данном массиве: {string.Join(", ", input)} - значения меньше или равно 3 символа: {string.Join(", ", output1)}; значения больше 3 символов: {string.Join(", ", output2)}");