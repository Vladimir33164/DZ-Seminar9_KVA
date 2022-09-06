//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
//натуральных элементов в промежутке от M до N.

//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30




// ввод данных
Console.Write("Enter a value M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter a value N: ");
int N = Convert.ToInt32(Console.ReadLine());
int sum = 0; // переменная для суммы
if (M > N) // если M больше чем N то выводим ошибку
    Console.WriteLine("The value of M must be less than or equal to N!");
else // иначе
    for (int i = M; i <= N; i++) // в цикле от M до N прибавляем к сумме значение счетчика
        sum += i;
Console.WriteLine("The sum of natural numbers in the range from M to N = " + sum);