﻿//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)
Console.Write("Введите число ");
int x = Convert.ToInt32(Console.ReadLine());
if (x == 0) {
    Console.Write("Введен ноль");
}
else if (x%2 == 0){
    Console.Write("Введено четное число");
}
else {
    Console.Write("Введено нечетное число");
}