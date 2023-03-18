const int numbersCount = 4;

IEnumerable<int> ReadNumbers()
{
    var numbers = new int[numbersCount];
    Console.Write("Enter 4 numbers: ");

    var n = 0;
    while (n < numbersCount)
    {
        var line = Console.ReadLine();
        if (line == null)
        {
            continue;
        }

        var sequences = line.Split(' ');
        for (var i = 0; i < sequences.Length && n < numbersCount; ++i)
        {
            if (int.TryParse(sequences[i], out numbers[n]))
            {
                n++;
            }
        }
    }
    return numbers;
}


var numbers = ReadNumbers();
var max = numbers.Max();
Console.WriteLine($"Max: {max}");
