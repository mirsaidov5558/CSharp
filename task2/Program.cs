﻿Console.WriteLine("Введмте число a: ");   //Задание_2
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введмте число b: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a == b)
{
    Console.WriteLine("Числа равны: \nЧисло a: " + a + 0 + "\n" + "Число b: " + b + 0);
}
else
{
    Console.WriteLine("Числа не равны: " + ++a);
    Console.WriteLine(++b);
}



//Console.WriteLine("Введите operand1: ");   //Задание_3
//int operand1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите operand2: ");
//int operand2 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите: +, -, *, /, %.");
//string sign = Convert.ToString(Console.ReadLine());
//switch (sign)
//{
//    case "+":
//        Console.WriteLine(operand1 + operand2);
//        break;
//    case "-":
//        Console.WriteLine(operand1 - operand2);
//        break;
//    case "*":
//        Console.WriteLine(operand1 * operand2);
//        break;
//    case "/":
//        Console.WriteLine(operand1 / operand2);
//        break;
//    case "%":
//        Console.WriteLine(operand1 % operand2);
//        break;
//    default:
//        Console.WriteLine("Ввели неправильный знак!");
//        break;
//}



//Console.WriteLine("Введите число от 0-100: "); // Задание_4
//int a = Convert.ToInt32(Console.ReadLine());
//if (a <= 14)
//{
//    Console.WriteLine("Число в промежутки [0-14]");
//}
//else if (a <= 35)
//{
//    Console.WriteLine("[15-35]");
//}
//else if (a < 50)
//{
//    Console.WriteLine("[36-49]");
//}
//else if (a <= 100)
//{
//    Console.WriteLine("[50-100]");
//}
//else
//    Console.WriteLine("Ввели неправильное число!");


//Console.WriteLine("Введите число от 0-100: "); // Задание_4
//int a = Convert.ToInt32(Console.ReadLine());
//if (a >= 0 && a <= 14)
//{
//    Console.WriteLine("Число в промежутки [0-14]");
//}
//else if (a >= 15 && a <= 35)
//{
//    Console.WriteLine("[15-35]");
//}
//else if (a >= 36 && a <= 49)
//{
//    Console.WriteLine("[36-50]");
//}
//else if (a >= 50 && a <= 100)
//{
//    Console.WriteLine("[50-100]");
//}
//else
//    Console.WriteLine("Ввели неправильное число!");

