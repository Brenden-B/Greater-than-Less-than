Console.WriteLine("When taking the following Quiz, the value of 'c' is equivalent to the value of 'a' + 'b'. It is essential that responses of 'Yes' and 'No' begin with a capitalized letter.");
Console.Write("What would you like the value of 'a' to be equivalent to? ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("What would you like the value of 'b' to be equivalent to? ");

int b = Convert.ToInt32(Console.ReadLine());
int c = a + b; 

if (c == 10)
{
    Console.WriteLine("C is equivalent to 10");
    return;
}

Console.Write("Is c less than 10? ");
string? response = Console.ReadLine();

if (response == "Yes")
{
    if(c < 10)
    {
        Console.WriteLine("That is correct.");
    }
    
}

if (response != "Yes")
{
    if (c > 10)
    {
        Console.WriteLine("That is correct");
    }
}
