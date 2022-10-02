//zadanie38
Console.Clear();


void InputArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(0, 100) * 10;
}

double sum = 0;
void poporyadku(double[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int max = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[max]) max = j;
        }
        double temp = array[i];
        array[i] = array[max];
        array[max] = temp;
    }
}

Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
double[] array = new double[n];
InputArray(array);
Console.WriteLine("[" + string.Join(", ", array) + "]");
poporyadku(array);
Console.WriteLine("[" + string.Join(", ", array) + "]");
double raz = array[0] - array[array.Length - 1];
Console.WriteLine($"raznost max-min =  {raz}");