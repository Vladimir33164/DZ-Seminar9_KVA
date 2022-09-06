//Задача 64: Задайте значения M и N. Напишите программу, которая выведет все 
//натуральные числа в промежутке от M до N.

//M = 1; N = 5. -> "1, 2, 3, 4, 5"
//M = 4; N = 8. -> "4, 6, 7, 8"



// ввод данных
Console.Write("Enter a value M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter a value N: ");
int N = Convert.ToInt32(Console.ReadLine());
if (M > N) // если M больше чем N то выводим ошибку
    Console.WriteLine("The value of M must be less than or equal to N!");
else // иначе
    for (int i = M; i <= N; i++) // в цикле от M до N выводим значение счетчика
        Console.Write(i + ", ");