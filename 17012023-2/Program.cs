Console.WriteLine("Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.");

Console.Write("Введите трехзначное число:  ");
int A = Convert.ToInt32(Console.ReadLine());
if (A>100 && A<999)   
    {
      int B= (A % 10);
       Console.Write("Третья цифра введенного числа - " + B);
    }
else if (A<100)
    {
      Console.Write("Число является двухзначным.Третьей цифры нет.");
    }
else
    {
      Console.Write ("Введенное число не является трехзначным.");
    }