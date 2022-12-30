
string[] arr1 = {"Hello" , "2" , "world" , ":-)"};
string[] arr2 = {"1234" , "1567" , "-2" ,"computer science"};
string[] arr3 = {"Russia" , "Denmark" , "Kazan"};

int Max_Word_Length = 3;
string[] GetShortWordsArray(string[] array)
{
    int legth = array.Length;
    string[] result = new string[array.Length];
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= Max_Word_Length)
        {
            result[count] = array[i];
            count++;
        }
    }
   
    return result;
}
void PrintArray(string[] array)
{
     if(array.Length == 0)
     {
        Console.WriteLine($"данный массив пуст");
     }
     
     else
    
    {
        Array.ForEach(array, (str) => Console.Write($"{str} "));
        Console.WriteLine();
    }
}

void PrintTask(string[] array)
{
    Console.WriteLine("Исходный строковый массив:");
    PrintArray(array);
    string[] shortArray = GetShortWordsArray(array);
    Console.WriteLine($"Результирующий массив (слов меньше или равно {Max_Word_Length} символов)");
    PrintArray(shortArray);
    Console.WriteLine();
}
PrintTask(arr1);
PrintTask(arr2);
PrintTask(arr3);
