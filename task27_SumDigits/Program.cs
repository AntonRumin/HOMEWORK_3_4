/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12
*/
/* ----- Вариант получения длины строки 
Console.Write ("Введите число");
string str = Console.ReadLine();
int length = str.Length;
Console.Write ($"в строке {str} содержится  {length} символов");

*/
// Функция 1. Запрос и ввод числа 
Console.Clear();

int GetNumber(string msg)
{

    int result = 0;

    while(true)
    {
        Console.Write(msg);

        if(int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Введено не число. Повторите ввод.");
        }
    }
    return result;
}
// Функция 2. Вычисление суммы цифр числа
int GetDigitSum (int num)
{
int rest = num;
int count = 0;

    while (rest != 0) // Цикл для вычисления количества цифр в числе
    {
        rest = rest/10;
        count +=1;
    }
        
int sum = 0;
int b = 10;
int c = 1;

    for (int i  =0; i < count; i++)
    {
        sum = sum + ((num % (b))/c);
        b = b * 10;
        c = c * 10;
    // Проверка промежуточных вычислений в цикле
    // Console.WriteLine(sum);
    }
    return sum;
}
// Объявление переменных.
// Ввод значений с помощью функции 1

int number = GetNumber("Введите число ");
// Вычисление переменных с помощью функции 2

int digitSum = GetDigitSum (number);
// Вывод результата
Console.Write ($"Сумма цифр числа {number} равна {digitSum}");