//zadanie36

Console.Clear();


void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(0, 100);
}

int sum = 0;
void sumnechet(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 1 || i % 2 == 1) sum = sum + array[i];
    }
}

Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine("[" + string.Join(", ", array) + "]");

sumnechet(array);
Console.WriteLine($"summa chisel na nechetnyh posiciyah v massive: {sum}");
