// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
//является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine( "Введите цифру от 1 до 7 ");
int number = Convert.ToInt32(Console. ReadLine());

if (number>1 && number <=5)
{
    Console.WriteLine("нет");
}
else if (number ==6 || number == 7)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("Вы ввели неверное число");
}