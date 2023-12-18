/* Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная. */

Console.WriteLine("enter a number. for quitting write 'q'");

while (true) {
    Console.Write("enter a number: ");
    string num = Console.ReadLine();            

    if (num.ToLower() == "q") {
        Console.WriteLine("exit");            
        break;            
    }
           
    if (int.TryParse(num, out int number)) {

        if (EvenSum(number)) {
            Console.WriteLine($"sum of numbers {number} is even. problem has ended.");
            break;
        }
        else {
            Console.WriteLine($"sum of numbers {number} is odd.");
        }
    }

    else {
        Console.WriteLine("it's not a number. enter 'q' for exit.");
    }
}

bool EvenSum(int n) {
    int sum = 0;
    while (n != 0) {
        sum += n % 10;
        n /= 10;
    }
    return sum % 2 == 0;
}