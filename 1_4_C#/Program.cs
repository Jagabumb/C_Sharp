//Задача №5. Напишите программу, которая на вход принимает одно число (N), 
//а на выходе показывает все целые числа в промежутке от -N до N.
//4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
//2 -> " -2, -1, 0, 1, 2

Console.WriteLine("Введите число ");
int number1 = Convert.ToInt32(Console.ReadLine());
if (number1 < 0)
{
  number1 = number1 * -1;
}
for (int x = -number1; x <= number1; x++)
{
  Console.Write(x + " ");
}

