int Factorial(int n)
{
    var m = n;
    for (--n; n > 1; n--)
    {
        m *= n;
    }

    return m;
}

Console.Write("Enter number: ");
var number = Convert.ToInt32(Console.ReadLine());
var fact = Factorial(number);
Console.WriteLine($"Factorial: {fact}");
