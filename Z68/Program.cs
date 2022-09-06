//Задача 68: Напишите программу вычисления функции Аккермана с помощью 
//рекурсии. Даны два неотрицательных числа m и n. 

//m = 2, n = 3 -> A(m,n) = 29




// рекурсивная функция Аккермана
static uint aker(uint m, uint n)
{
    if (m == 0)
        return n + 1;
    else
        if ((m > 0) && (n == 0))
        return aker(m - 1, 1);
    else
        return aker(m - 1, aker(m, n - 1));
}
static void Main(string[] args)
{
    // ввод данных
    Console.Write("Enter a value M: ");
    uint M = uint.Parse(Console.ReadLine());
    Console.Write("Enter a value N: ");
    uint N = uint.Parse(Console.ReadLine());
    if (M < 0 || N < 0) // если M меньше нуля или N меньше нуля то выводим ошибку
        Console.WriteLine("The value of M and N must not be negative");
    else // иначе    
        Console.WriteLine("A(M, N) = " + aker(M, N)); // вызов функции и вывод результата
}