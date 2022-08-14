/*Найти позицию в массиве, на которой находится заданное число (индекс)*/

int[] array = { 1, 3, 5, 7, 8, 9, 5, 6 };

int n = array.Length;
int find  = 6;

int index = 0;

while(index<n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
    }
    
    index++;

}