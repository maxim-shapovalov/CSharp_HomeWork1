//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Write("Введите 1-е число ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-е число ");
int b = Convert.ToInt32(Console.ReadLine());

if (a == b) { 
    Console.Write("Введенные числа равны");
}

else if (a > b) {
    Console.Write("Число " + a + " максимальное, а число " + b + " минимальное");
}
else {
    Console.Write("Число " + b + " максимальное, а число " + a + " минимальное");
}