string[] array = {"q", "a", "w", "dgs"};

int countstrs(string[] texts)
{
    int nums = 0;
    for(int i = 0; i < array.Length; i++)
    {
        switch(texts[i][0])
        {
            case 'a':
            nums++;
            break;
            case 'e':
            nums++;
            break;
            case 'i':
            nums++;
            break;
            case 'o':
            nums++;
            break;
            case 'u':
            nums++;
            break;
            case 'y':
            nums++;
            break;
        }

    }
    return nums;
}

Console.WriteLine(countstrs(array));