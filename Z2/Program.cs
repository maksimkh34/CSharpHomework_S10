string[] collstrs(string[] texts)
{
    string[] newarray = new string[texts.Length / 2];
    for (int i = 0; i < texts.Length/2; i++)
    {
        newarray[i] = texts[i] + texts[i + 1];
    }
    return newarray;
}

void printstrarray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);
    }
    Console.WriteLine();
}
string[] array = { "qwe", "wer", "ert", "rty", "tyu", "yui" };

printstrarray(array);

string[] newarray = collstrs(array);

printstrarray(newarray);