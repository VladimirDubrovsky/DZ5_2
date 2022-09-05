// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

void FillArray(int[] collection)
{ 
    for (int i = 0; i < collection.Length; i++)
    {
        collection[i]=new Random().Next(1, 999);
    }
}

void PrintArray(int[] col)
{
    for (int i = 0; i < col.Length; i++)
    {
        Console.WriteLine(col[i]);
    }
}

int s=0;
void Summ(int[] summa)
{
    for (int i = 0; i < summa.Length; i++)
    {
        if (i%2 != 0)
        {
            s = s + summa[i];
            i++;
        }
    }
}

int count = new Random().Next(1, 99);
int[] array = new int[count];

FillArray(array);
PrintArray(array);
Summ(array);



Console.WriteLine($"Колличество элементов в массиве: {count} , сумма {s}");