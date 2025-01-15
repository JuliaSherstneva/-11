/*4.Выполнить сортировку элементов, записанных на нечетных местах. 
 Использовать сортировку простым выбором. */ 

int[] array = { 12, 7, 18, 3, 25, 10, 30, 2, 45, 5 };

for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine(array[i] + " ");
}
Console.WriteLine();

for (int i = 1; i < array.Length; i += 2) 
{
    int minIndex = i;
    for (int j = i + 2; j < array.Length; j += 2)
    {
        if (array[j] < array[minIndex])
        {
            minIndex = j;
        }
    }
    int temp = array[i];
    array[i] = array[minIndex];
    array[minIndex] = temp;
}
for (int i = 0; i < array.Length; i++)
{
     Console.Write(array[i] + " ");
}
Console.WriteLine();