/*
// Задача 10. Напишите программу, которая принимает на вход трёхзначное 
// число и на выходе показывает вторую цифру этого числа.

int CutNumber(int num)
{
    int decade = num / 10;
    int result = decade % 10;
    return result;
}
Console.Write("Input a three digit number for checking: ");
int number = Convert.ToInt32(Console.ReadLine());
int newNumber = CutNumber(number);
if (number > 1000 || number < 100) Console.Write("USE THREE DIGIT NUMBERS!");
if (number < 1000 && number > 100) Console.Write("Your number is: " + newNumber);
*/


