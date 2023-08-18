// Show the second digit of a 3-digit integer 
int Prompt(string message)

{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int number = Prompt("Input a 3-digit number: ");

if (number < 100 || number >= 1000)
{
    Console.WriteLine("Your number wasn't a 3-digit one. Try again. ");
    return;
}

Console.WriteLine($"Input number '{number}'");
int secondRank = number / 10 % 10;
Console.WriteLine($"Second digit '{secondRank}'");