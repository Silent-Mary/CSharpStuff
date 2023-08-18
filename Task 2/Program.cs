// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Input two numbers: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
if(number1 > number2)
{
    Console.WriteLine("1st number is max");
}
if(number2 > number1)
{
    Console.WriteLine("2nd number is max");
}
if(number1 == number2) 
{
    Console.WriteLine("Please pick differing integers");
}