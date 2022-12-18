// Задача 13. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
string arrNumber = Convert.ToString(number);
if (arrNumber.Length > 2)
{
    Console.WriteLine("Его третья цифра это: " + arrNumber[2]);
}
else
{
    Console.WriteLine("Третьей цифры не сущетсвует.");
}