//Напишите программу которая на вход принимает трехзначное число
// и на выходе показывает вторую цифру этого числа 


Console.WriteLine("Введите трехзначное число: ");
int number = (int)Math.Abs(int.Parse(Console.ReadLine()!));
if (number < 100)
      {
        Console.WriteLine("Число должно быть трехзначное");
      }
else
if (number > 999)
      {
        Console.WriteLine("Число должно быть трехзначное");
      }
else
{
    Console.WriteLine(number.ToString()[1]);
}