﻿//Напишите программу, которая на вход принимает число и выдает его квадрат
//(число умноженное на само себя)

//Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine()); //Пользователь вводит число и мы его конвертируем в Int32
int mulNumber = number * number;

//Console.WriteLine(mulNumber);
Console.WriteLine($"Ваш результат {mulNumber}");