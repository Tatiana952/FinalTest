
string[] FullArray = { "hello", "2", "world", ":-)" };

int j = 0;
for (int i = 0; i < FullArray.Length; i++)
{
    if (FullArray[i].Length <= 3 ) j++;
}

if (j == 0)
{
    Console.WriteLine();
}
else
{
    string[] ShortArray = new string[j];
    int i = 0;
    int k = 0;
    while(i < FullArray.Length)
    {
        if (FullArray[i].Length <= 3 )
        {
        ShortArray[k] = FullArray[i];
        k++;
        }
        i++;
    }
}