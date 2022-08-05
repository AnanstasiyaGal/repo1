Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int Nmin = N * (-1);
while (Nmin <= N)
{
Console.WriteLine(Nmin);
Nmin++;
}
