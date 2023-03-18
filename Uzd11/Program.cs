int ReverseNumber(int number)
{
    var reverseNumber = 0;
    while (number != 0)
    {
        reverseNumber = reverseNumber * 10 + (number % 10);
        number /= 10;
    }

    return reverseNumber;
}

bool IsNumberSymmetrical(int number)
{
    return number == ReverseNumber(number);
}

Console.Write("Enter number: ");
var number = Convert.ToInt32(Console.ReadLine());
var isNumberSymmetrical = IsNumberSymmetrical(number);

Console.WriteLine("Number is {0}", isNumberSymmetrical ? "symmetrical" : "not symmetrical");
