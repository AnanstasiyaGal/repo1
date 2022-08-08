Console.WriteLine("Введите целое число: ");
int N = Convert.ToInt32(Console.ReadLine());
while (N > 1)
{
    int resalt = N % 2;
    if (resalt == 0)
    {
Console.WriteLine(N);
    }
    N = N -1;
}