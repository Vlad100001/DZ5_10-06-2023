void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-1000, 1000); 
}
void Summ(int[] array)
{  int sum = 0;
    for (int i = 0; i < array.Length; i++)
        {if (i % 2 == 1)
        sum=sum+array[i];
        }
Console.WriteLine($" сумма элементов cтоящих на нечётных позициях = {sum}");
}
    


Console.Clear();
Console.Write("Введите кол-во элементов массива: ");

int k = int.Parse(Console.ReadLine()!);
int[] array = new int[k];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
Summ(array);
