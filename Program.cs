void PrintArray(string[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(i + ", ");
    }
}

Console.WriteLine("Введите количество элементов вашего массива: ");
int size = Convert.ToInt32(Console.ReadLine());
string[] array = new string[size];

for(int i = 0; i < size; i++)
{
    Console.WriteLine($"Введите {i + 1}-й элемент: ");
    string elem = Convert.ToString(Console.ReadLine());
    array[i] = elem;
}

PrintArray(array);