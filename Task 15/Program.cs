// Converts a number into a day of the week and says if it's a weekend

int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

bool IsWeekend(int weekDay)
{
    if (weekDay > 5)
    {
        return true;
    }
    return false;
}

bool ValidateWeekday(int number)
{
    if (number > 0 && number <=7)
    {
        return true;
    }
    Console.WriteLine("It is not a weekday!");
    return false;
}

int weekDay = Prompt("Input weekday: ");
if (ValidateWeekday(weekDay))
{
    if (IsWeekend(weekDay))
    {
        Console.WriteLine("Finally it's weekend!");
    }
    else 
    {
        Console.WriteLine("You gotta work bish");
    }
}
