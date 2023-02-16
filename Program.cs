// Задача: Написать программу, которая из имеющегося массива строк
// формирует массив из строк, длина которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте 
// выполнения алгоритма.
// Примеры:
// ["hello", "2", "world", ":-)"] -> [2,:-)]
// ["1234", "1567", "-2"] -> [-2]
// ["Russia", "Danmark", "Kazan"] -> []

string[] array1 = {"hello", "2", "world", ":-)"};
string[] array2 = {"1234", "1567", "-2"};
string[] array3 = {"Russia", "Danmark", "Kazan"};

Console.WriteLine($"[{String.Join(",", SortArrays(array1))}]");
Console.WriteLine($"[{String.Join(",", SortArrays(array2))}]");
Console.WriteLine($"[{String.Join(",", SortArrays(array3))}]");

// -------------------метод-----------------------

string[] SortArrays(string[] stroka)
{
    int size = 0;
    for (int i = 0; i < stroka.Length; i++) 
    {          
        if (stroka[i].Length <= 3)
        {               
            size++;           
        }        
    } 

    String[] res = new String[size];
    int index = 0;
    for (int j = 0; j < stroka.Length; j++)
    {                     
        if (stroka[j].Length <= 3) 
        {                            
            res[index] = stroka[j];                 
            index++; 
        }  
    }   
    return res;   
}
