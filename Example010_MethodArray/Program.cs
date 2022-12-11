int[] array = {11, 28, 18, 64, 55, 46, 47, 18};

int n = array.Length;
int find = 18;

int index = 0;

while (index < n)
{

    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}