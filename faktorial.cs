﻿int number = 8;
int factorial = 1;

for (int i = 1; i <= number; i++)
{
    factorial *= i;
}

Console.WriteLine(factorial);
Console.ReadLine();