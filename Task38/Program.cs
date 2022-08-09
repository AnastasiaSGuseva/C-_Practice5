// Задача 38
// Задайте массив вещественных чисел. Найдите разницу между максимальным
//  и минимальным элементов массива.

// [3 7 22 2 78] -> 76

Console.WriteLine("Задайте количество элементов массива: ");
int N = Convert.ToInt32(Console.ReadLine());

double [] array = new double [N];

for (int i = 0; i < N; i++)
    array [i] = Math.Round(new Random().NextDouble () * 100, 2);

Console.WriteLine("[" + string.Join(", ", array) + "]");

int j = 0;
double max = array[j];
double min = array[j];

while (j < N)
{
    if (array [j] > max) 
         max = array[j];
    if (array [j] < min)
         min = array [j];
    j++;
}

Console.WriteLine("Max = " + max);
Console.WriteLine("Min = " + min);

double diff = max - min;
Console.WriteLine("Разница между максимальным и минимальным элементами: " + diff);