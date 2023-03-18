int Sum(int start, int end)
{
    var sum = start;
    for (var i = start + 1; i <= end; ++i)
    {
        sum += i;
    }

    return sum;
}

Console.Write("Enter two numbers separated by space: ");
var sequences = Console.ReadLine()!.Split(' ');

var start = int.Parse(sequences[0]);
var end = int.Parse(sequences[1]);

var sum = Sum(start, end);
var average = (double)sum / (end - start + 1);

Console.WriteLine($"Sum: {sum}, Average: {average}");
