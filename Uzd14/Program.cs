Strip[] ReadStrips(string fileName)
{
    Strip[] strips =
    {
        new Strip('Z'), new Strip('G'), new Strip('R')
    };

    using var reader = new StreamReader(fileName);
    var chunksAmount = Convert.ToInt32(reader.ReadLine());

    for (var i = 0; i < chunksAmount; i++)
    {
        var sequences = reader.ReadLine()!.Split(' ');
        var color = sequences[0][0];
        var amount = int.Parse(sequences[1]);

        switch (color)
        {
            case 'Z':
                strips[0].Amount += amount;
                break;
            case 'G':
                strips[1].Amount += amount;
                break;
            case 'R':
                strips[2].Amount += amount;
                break;
        }
    }

    return strips;
}

int FindMinStrips(Strip[] strips)
{
    var min = strips[0].Amount;
    for (var i = 1; i < 3; ++i)
    {
        if (strips[i].Amount < min)
        {
            min = strips[i].Amount;
        }
    }

    return min;
}

int CalculateFlags(Strip[] strips)
{
    var min = FindMinStrips(strips);
    return min / 2;
}

FlagsRating RateFlagsAmount(int flagsAmount)
{
    return flagsAmount switch
    {
        > 10 => FlagsRating.Large,
        > 5 => FlagsRating.Medium,
        > 2 => FlagsRating.Small,
        _ => FlagsRating.Micro
    };
}

void SaveResults(string fileName, int flagsAmount, IEnumerable<Strip> strips)
{
    using var writer = new StreamWriter(fileName);
    var rating = RateFlagsAmount(flagsAmount);
    writer.WriteLine($"{flagsAmount} {rating}");

    foreach (var strip in strips)
    {
        writer.WriteLine($"{strip.Color} = {strip.Amount - 2 * flagsAmount}");
    }
}

var strips = ReadStrips("colors.txt");
var flagsAmount = CalculateFlags(strips);
SaveResults("results.txt", flagsAmount, strips);

internal struct Strip
{
    public readonly char Color;
    public int Amount;

    public Strip(char color, int amount = 0)
    {
        this.Color = color;
        this.Amount = amount;
    }
}

internal enum FlagsRating
{
    Micro,
    Small,
    Medium,
    Large
}
