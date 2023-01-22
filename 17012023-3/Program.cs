Console.WriteLine("Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.");
Console.Write("Введите число от 1 до 7 соответсвующего дня недели:   ");
int day = Convert.ToInt32(Console.ReadLine());
switch (day)
{
case(1):
  Console.WriteLine("Понедельник - день рабочий");
  break;
case(2):
  Console.WriteLine("Вторник - день рабочий");
  break;  
case(3):
  Console.WriteLine("Среда - день рабочий.");
  break; 
case(4):
  Console.WriteLine("Четверг -день рабочий.");
  break;
case(5):
  Console.WriteLine("Пятница - день рабочий.");
  break;
case(6):
  Console.WriteLine("Суббота - выходной день.");
  break;
case(7):
  Console.WriteLine("Воскресенье - выходной день.");
  break;
default:
  Console.WriteLine("Вы ввели неправильное число. В неделе всего семь дней.");
  break;
}
