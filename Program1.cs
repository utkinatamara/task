//задача 2
//Задайте произвольный массив. Выведете
//его элементы, начиная с конца. Использовать
//рекурсию, не использовать циклы.*/

void PrintArr(int[] array, int first = 0)
{
    if(first != array.Length) 
{
        PrintArr(array, first + 1);
        Console.Write($"{array[first]} ");
    }
}
        
void RecMas(string[] args)
{
    var array = new int[]{11, 22, 34, 4, 5 };
    PrintArr(array);            
}
RecMas(args);
