//Fizz and Buzz refer to any number that's a multiple of 3 and 5 respectively

int[] variablesIn = [1,2,3,4,5,6,7,8,9,10];


foreach (int variable in variablesIn)
{
    if (variable % 15 == 0)
    {
        Console.WriteLine($"Variable {variable} is a fizz buzz");
    }
    else if (variable % 3 == 0)
    {
        Console.WriteLine($"Variable {variable} is a fizz");
    }
    else if ( variable % 5 == 0)
    {
        Console.WriteLine($"Variable {variable} is a buzz");
    }
    else
    {
        Console.WriteLine($"Variable {variable} isnt a fizz buzz");
    }
}