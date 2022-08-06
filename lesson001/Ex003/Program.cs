Console.WriteLine("Какой по счету сегодня день недели? Введите число от 1 до 7: ");
int Number = Convert.ToInt32(Console.ReadLine());
if (Number == 1)
{
    Console.WriteLine("Понедельник");
}
else if (Number == 2)
{
    Console.WriteLine("Втоник");
}
else if (Number == 3)
{
    Console.WriteLine("Среда");
}
else if (Number == 4)
{
    Console.WriteLine("Четверг");
}
else if (Number == 5)
{
    Console.WriteLine("Пятница");
}
else if (Number == 6)
{
    Console.WriteLine("Суббота");
}
else if (Number == 7)
{
    Console.WriteLine("Воскресенье");
}
else 
{
    Console.WriteLine("Такого дня недели нет, повторите попытку.");
}