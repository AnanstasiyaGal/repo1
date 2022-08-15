int value(int Number)
{
    int namber1 = Number % 100;
    int namber2 = namber1 / 10;
    return namber2;
}

int N = new Random().Next(100, 999);
Console.WriteLine(N);
Console.WriteLine(value(N));


/* решение без метода
Console.WriteLine("Введите трехзначное целое число: ");
int N = Convert.ToInt32(Console.ReadLine());
int A = N % 100;
int number = A / 10;
Console.WriteLine(value());
*/


