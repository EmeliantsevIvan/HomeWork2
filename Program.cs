/*
// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1


int SecondNumber(int Number)
{
    int des = Number % 100;

    int result = des / 10; 
    return result;
}


Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());

int newNum = SecondNumber(num);
Console.WriteLine($"new version of {num} is {newNum}");
*/

/*
// Задача 13: Напишите программу, которая выводит третью цифру заданного числа.
// 645 -> 5
// 32679 -> 6
// 21 -> -1


int thirdNumber(int number);
if (number <=-100 || number >=100)
{
    result = -1
}

Console.Write("Введи число: ");
int anyNumber = Convert.ToInt32(Console.ReadLine());
string anyNumberText = Convert.ToString(anyNumber);
if (anyNumberText.Length > 2){
  Console.WriteLine("третья цифра -> " + anyNumberText[2]);
}
else {
  Console.WriteLine("-> третьей цифры нет");
}
*/


Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

//6 -> да
//7 -> да
//1 -> нет

bool Day (int number)
{
    bool result = true;
    if (number <=5 || number >7)
    {
        result = false;
    }
    result = Day;
    return result;
}

Console.Write("Введите число от 1 до 7: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(result);

