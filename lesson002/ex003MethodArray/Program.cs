int [] array = {11, 21, 35, 4, 35, 68, 78, 8};
int n = array.Length; //определили длинну массива
int find = 35; //задали число для поиска нмера индекса
int index = 0; // задалии индексу номер для старта
while (index < n)
{
    if(array[index]==find)
    {
    Console.WriteLine(index);
    break;//прервать операцию, если вдруг искомых чисел несколько
    }
    index++;// прибавляем 1
}