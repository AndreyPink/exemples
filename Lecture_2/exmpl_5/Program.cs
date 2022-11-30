//нахождение индекса элемента массива равного заданному в pos
//с использованием 3-х методов:
//1.метод генерации массива FillArray
//2.метод печати массива PrintArray
//3.метод поиска индекса в сгенеренном массиве IndexOf

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;

    while (index<count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine("===========");

int pos = IndexOf(array, 4);
Console.WriteLine(pos);
