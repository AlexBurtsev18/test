void PrintArray(string[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("Введите количество элементов вашего массива: ");
int size = Convert.ToInt32(Console.ReadLine());
string[] array = new string[size];
string[] resultArray = new string[size];

for(int i = 0; i < size; i++)
{
    Console.WriteLine($"Введите {i + 1}-й элемент: ");
    string elem = Convert.ToString(Console.ReadLine());
    array[i] = elem;
}

void ResArray(string[] array)
{
    int len = 3;
    int pos = 0;
    for(int i = 0; i<size; i++)
    {
        if(array[i].Length <= len)
        {
            resultArray[pos] = array[i];
            pos++;
        }
    }
}

PrintArray(array);
ResArray(array);
PrintArray(resultArray);
