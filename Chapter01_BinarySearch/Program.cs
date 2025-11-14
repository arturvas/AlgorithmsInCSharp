Console.WriteLine("--- Binary Search ---");
return;

int BinarySearch(int[] array, int value)
{
    var baixo = 0;
    var alto = array.Length - 1;

    while (baixo <= alto)
    {
        var meio = (baixo + alto) / 2;
        var chute = array[meio];

        if (chute == value)
        {
            return meio;
        }
        if (chute > value)
        {
            alto = meio - 1;
        }
        else
        {
            baixo = meio + 1;
        }
    }

    return 0;
}