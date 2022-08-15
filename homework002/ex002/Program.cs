int value = new Random().Next(35, 9999);
Console.WriteLine(value);
string valueText = Convert.ToString(value);
if (valueText.Length > 2)
{
  Console.WriteLine("третья цифра -> " + valueText[2]);
}
else {
  Console.WriteLine("-> в числе нет третьей цифры");
}

