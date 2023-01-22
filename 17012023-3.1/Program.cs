
Console.WriteLine("Введите число от 1 до 7 соответсвующего дня недели:   ");
int numday=Convert.ToInt32(Console.ReadLine());

if(numday<=5) 
{
    Console.WriteLine("Это рабочий день");
}
if(numday==6 || numday==7) 
{
    Console.WriteLine("Это выходной день.");
}
if(numday>7)
{
   Console.WriteLine("Вы ввели неправильное число. В неделе всего семь дней");
}