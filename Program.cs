
Console.WriteLine("Введите основание числа (систему счисления от 2-ой до 10-ичной)");
int system = Convert.ToInt32(Console.ReadLine());

if (system <= 1)
{
    Console.WriteLine("Вы ввели основание меньше 2");
    return;
}
else if (system >= 10)
{
    Console.WriteLine("Вы ввели основание больше 9");
    return;
}
else
{
    Console.WriteLine($"Ваше основание: {system}");
}
Console.WriteLine("Введите число");
double x = Convert.ToDouble(Console.ReadLine());

if (system == 2)
{
    double check = x % 10;
    if (check <= 1)
    {
        Console.WriteLine($"Ваше число: {x}");
    }
    else if (check >= 2)
    {
        Console.WriteLine("Вы ввели число не в двоичной системе счисления");
        return;
    }
}
if (system == 3)
{
    double check = x % 10;
    if (check <= 2)
    {
        Console.WriteLine($"Ваше число: {x}");
    }
    else if (check >= 3)
    {
        Console.WriteLine("Вы ввели число не в троичной системе счисления");
        return;
    }
}

if (system == 4)
{
    double check = x % 10;
    if (check <= 3)
    {
        Console.WriteLine($"Ваше число: {x}");
    }
    else if (check >= 4)
    {
        Console.WriteLine("Вы ввели число не в четыричной системе счисления");
        return;
    }
}

if (system == 5)
{
    double check = x % 10;
    if (check <= 4)
    {
        Console.WriteLine($"Ваше число: {x}");
    }
    else if (check >= 5)
    {
        Console.WriteLine("Вы ввели число не в пятеричной системе счисления");
        return;
    }
}

if (system == 6)
{
    double check = x % 10;
    if (check <= 5)
    {
        Console.WriteLine($"Ваше число: {x}");
    }
    else if (check >= 6)
    {
        Console.WriteLine("Вы ввели число не в шестеричной системе счисления");
        return;
    }
}

if (system == 7)
{
    double check = x % 10;
    if (check <= 6)
    {
        Console.WriteLine($"Ваше число: {x}");
    }
    else if (check >= 7)
    {
        Console.WriteLine("Вы ввели число не в семеричной системе счисления");
        return;
    }
}

if (system == 8)
{
    double check = x % 10;
    Console.WriteLine($"SUKKKKKKKAAAAAA: {check}");
    if (check <= 7)
    {
        Console.WriteLine($"Ваше число: {x}");
    }
    else if (check >= 8)
    {
        Console.WriteLine("Вы ввели число не в восьмиричной системе счисления");
        return;
    }
}

if (system == 9)
{
    double check = x % 10;
    if (check <= 8)
    {
        Console.WriteLine($"Ваше число: {x}");
    }
    else if (check >= 9)
    {
        Console.WriteLine("Вы ввели число не в девятиричной системе счисления");
        return;
    }
}

if (system == 10)
{
    Console.WriteLine($"Ваше число: {x}");
}

Console.WriteLine("Введите основание в какую систему вы хотите перевести (систему счисления от 2-ой до 10-ичной)");
int system2 = Convert.ToInt32(Console.ReadLine());

if (system2 <= 1)
{
    Console.WriteLine("Вы ввели основание меньше 2");
    return;
}
else if (system2 >= 11)
{
    Console.WriteLine("Вы ввели основание больше 10");
    return;
}
else
{
    Console.WriteLine($"Ваше основание: {system}");
}

string x_leng = Convert.ToString(x);
int x_last_numb = 0;
double x_last_ans = 0;
double sum = 0;
double x_ans = 0;
int x1 = Convert.ToInt32(x);

for (int i = 0; i < x_leng.Length; i++)
{
    x_ans = x1 % 10 * Math.Pow(system, i);
    x_last_numb = x1 / 10;
    x1 = x_last_numb;
    x_last_ans = x_ans;
    sum += x_last_ans;
}

int sum1 = Convert.ToInt32(sum);
string result = "";
int number = sum1;

if (system2 >= 2 && system2 <= 10)
{
    if (number == 0)
    {
        result = "0";
    }
    while (number > 0)
    {
    int x_last_numb1 = number % system2;
    result = x_last_numb1.ToString() + result;
    number /= system2;
    }
    Console.WriteLine($"Чиcло в {system2}-чной системе: {result}");
}


