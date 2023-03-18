Console.Write("Enter number: ");
var text = Console.ReadLine() ?? "";

if (!int.TryParse(text, out var number)) 
{
    Console.WriteLine("Invalid number");
    return;
}

Console.WriteLine("{0} is {1}", number, number % 2 == 0 ? "even" : "odd");
