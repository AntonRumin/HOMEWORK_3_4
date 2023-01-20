/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16
*/

Console.Clear();
// Функция1 1. Запрос и ввод целого числа

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
            Console.WriteLine("Ввели не число");
        }
    }

    return result;
}
// Функция 2. Возведение числа в степень

int GetDegree (int numA, int numB)
{
   int product = 1;
        for (int i = 1; i <= numB; i++)
        {
            product = product * numA;
        }
        return product;
}
// Объявление переменных и ввод данных с помощью Функции 1

int numberA = GetNumber ("Введите Первое число (основание степени): ");
int numberB = GetNumber ("Введите Второе число (показатель степени):");
// Вычисление с помощью Функции 2

int degree = GetDegree(numberA,numberB);
//Вывод результата вычисления 

Console.WriteLine($"Число {numberA} в степени {numberB} равно {degree}");