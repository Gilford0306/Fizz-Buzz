//задание 1
//пользователь вводит с клавиатуры число в диапа-
//зоне от 1 до 100. если число кратно 3 (делится на 3 без 
//остатка) нужно вывести слово fizz. если число кратно 5 
//нужно вывести слово buzz. если число кратно 3 и 5 нужно 
//вывести fizz buzz. если число не кратно не 3 и 5 нужно 
//вывести само число.
//если пользователь ввел значение не в диапазоне от 1 
//до 100 требуется вывести сообщение об ошибке.

int k;
do
{
    Console.WriteLine("Input number");
    int num = int.Parse(Console.ReadLine());
    if (num > 100 || num < 0)
        Console.WriteLine("Number not in the range 1 to 100");
    else if (num % 3 == 0 && num % 5 == 0)
        Console.WriteLine("fizz buzz");
    else if (num % 3 == 0)
        Console.WriteLine("buzz");
    else if (num % 5 == 0)
        Console.WriteLine("fizz");
    else
        Console.WriteLine(num);
    Console.WriteLine("Int key - 1 - to continue, 0 - to exit");
    k = int.Parse(Console.ReadLine());
} while (k == 1);
return;



