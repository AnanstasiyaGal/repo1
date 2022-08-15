Console.Write("Введи цифру, обозначающую день недели: ");
int number = Convert.ToInt32(Console.ReadLine());

void DayWeek (int Number) {
  if (number == 6 || number == 7) {
  Console.WriteLine("этот день выходной");
  }
  else if (number < 1 || number > 7) {
    Console.WriteLine("нет такого дня недели");
  }
  else Console.WriteLine("этот день НЕ выходной");
}

DayWeek(number);
