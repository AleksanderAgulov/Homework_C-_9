//Задача 1 :Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
//Выполнить с помощью рекурсии.
/*
Console.WriteLine("Введите число больше 1:");
int number = Convert.ToInt32(Console.ReadLine());

///Метод вывода натуральных чисел от N до 1:
void NumberNatural (int number)
{
    if (number < 0) 
    {
        Console.Write($"{number} не натуральное число");
    }
    
    if (number == 0)
    {
        return;
    } 
    Console.Write("{0,4}", number);
    NumberNatural (number - 1);
}

NumberNatural(number);
*/
//Задача 2 : Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
/*
Console.WriteLine("Введите начальное число M:");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите начальное число N:");
int num2 = Convert.ToInt32(Console.ReadLine());

void GapNumberSum (int number1, int number2, int sum)
{
    if (number1 > number2) 
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}"); 
        return;
    }
    sum = sum + (number1++);
    GapNumberSum(number1, number2, sum);
}

GapNumberSum(num1, num2, 0);*/
//Задача 3 : Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

//m 1 n 2
/*
Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

AkkermanFunction(m,n);


// вызов функции Аккермана
void AkkermanFunction(int m, int n)
{
    Console.Write(Akkerman(m, n)); 
}

// функция Аккермана
int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return (Akkerman(m - 1, Akkerman(m, n - 1)));
    }
}*/