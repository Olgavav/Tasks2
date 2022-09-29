Console.WriteLine("Введите число: ");
int number = (int)Math.Abs(int.Parse(Console.ReadLine()!));
if (number < 100)
      {
        Console.WriteLine("Третьей цифры нет");
      }
else
{
    Console.WriteLine(number.ToString()[2]);
}
