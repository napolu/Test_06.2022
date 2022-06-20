//string[] words = {"крог", "мыш", "абак", "щер", "ут", "кусь", "сма", "чкур"};
string[] words = {"Hello", "2", "world", ":-)"};
//string[] words = {"1234", "1567", "-2", "computer science"};
//string[] words = {"Russia", "Denmark", "Kazan"};

int SizeDefiner(string[]arr)
{
    int newSize = 0;
    int limit = 3;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i].Length <= limit)
            newSize = newSize + 1;
    }
    return newSize;
}

string[] threeSymbols(string[] arr, int newSize)
{
    string[] newArr = new string[newSize];
    int limit = 3;
    for (int i = 0,j = 0; i < arr.Length; i++)
    {
        if(arr[i].Length <= limit)
        {
            newArr[j] = arr[i];
            j++;
        }
    }
    return newArr;
}

void ShowWords(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i]);
        if(i < arr.Length-1)
            Console.Write(", ");
    }
    Console.Write("]");
}


ShowWords(words);
Console.Write("  =>  ");
int newStringSize = SizeDefiner(words);
ShowWords(threeSymbols(words, newStringSize));