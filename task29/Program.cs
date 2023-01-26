// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]


int[] array()
{
    int[] Arr = new int[8];
    for (int i = 0; i < Arr.Length; i++)
    {
         Arr[i] = int.Parse(Console.ReadLine()!);
    }
    return Arr;
}

void printArray(int[] array)
{
    string outArrey = "";
    for (int i = 0; i < array.Length; i++)
    {
        outArrey += array[i];
        if (i < array.Length -1) outArrey += ", ";
    }
    Console.WriteLine(outArrey);
}

Console.Clear();
int[] eight = array();
printArray(eight);
