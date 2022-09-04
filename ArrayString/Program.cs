
string[] FullArray = { "hello", "2", "world", ":-)" };

int j = 0;
for (int i = 0; i < FullArray.Length; i++)
{
    if (FullArray[i].Length <= 3 ) j++;
}
