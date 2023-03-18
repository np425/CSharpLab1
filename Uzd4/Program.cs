string? FindMonth(int month)
{
    return month switch
    {
        <= 0 => null,
        <= 3 => "spring",
        <= 6 => "summer",
        <= 9 => "autumn",
        <= 12 => "winter",
        _ => null
    };
}

Console.Write("Enter number: ");
var monthNumber = Convert.ToInt32(Console.ReadLine());
var month = FindMonth(monthNumber);
Console.WriteLine(month == null ? "No such month" : $"Month: {month}");
