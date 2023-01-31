/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

System.Console.WriteLine("____Tusk 10____");

System.Console.Write("Enter number 100 - 999: " );

int Number = Convert.ToInt32(Console.ReadLine());

if (Number >= 100 && Number <= 999)
{
    System.Console.WriteLine((Number % 100) / 10 );
}
else
{
    System.Console.WriteLine("Error, enter number 100 - 999");
}




/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

System.Console.WriteLine("____Tusk 13____");

System.Console.Write("Enter number 100 - 999: " );

int Number1 = Convert.ToInt32(Console.ReadLine());

int i=1000;

while (i <= Number1)
{
    i*=10;
}

if (Number1 < 100)
{
     System.Console.WriteLine("Erro, enter number > 100");
}
else
{
     System.Console.WriteLine((Number1 % (i / 100)) / (i / 1000));
}
    



/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

System.Console.WriteLine("____Tusk 15____");             

System.Console.Write("Enter the number of the day of the week: " );

int Number2 = Convert.ToInt32(Console.ReadLine());

if (Number2 == 6 || Number2 == 7)
{
    System.Console.WriteLine("Yes. Day off");
}
else
{
    System.Console.WriteLine("No");
}