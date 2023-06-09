void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(99, 1000); 
}
void FindEven(int[] array)
{  int even = 0;
    for (int i = 0; i < array.Length; i++)
        {if (array[i] % 2 == 0)
        even++;
        }
    
    Console.WriteLine($"Количество четных чисел равно=]: {even}");
}

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");

int k = int.Parse(Console.ReadLine()!);
int[] array = new int[k];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
FindEven(array);
