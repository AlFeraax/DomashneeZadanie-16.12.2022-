//Задача 15. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите номер дня недели: ");
int daynumber = Convert.ToInt32(Console.ReadLine());
if (daynumber == 1)
{
    Console.WriteLine("это Понедельник, это не выходной.");
}
if (daynumber == 2)
{
    Console.WriteLine("это Вторник, это не выходной.");
}
if (daynumber == 3)
{
    Console.WriteLine("это Среда, это не выходной.");
}
if (daynumber == 4)
{
    Console.WriteLine("это Четверг, это не выходной.");
}
if (daynumber == 5)
{
    Console.WriteLine("это Пятница, это не выходной.");
}
if (daynumber == 6)
{
    Console.WriteLine("это Суббота, и это выходной!");
}
if (daynumber == 7)
{
    Console.WriteLine("это Воскресенье, и это выходной!");
}
else if (daynumber >= 7) 
{
    Console.WriteLine("Это не день недели, в неделе 7 дней.");
}