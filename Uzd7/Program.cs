
Console.Write("Enter number: ");
var number = Convert.ToInt32(Console.ReadLine());

var reverseNumber = 0;
var numberLength = 0;
while (number != 0) {
    numberLength++;
    reverseNumber = reverseNumber * 10 + (number % 10);
    number /= 10;
}

Console.WriteLine($"length: {numberLength}");
Console.WriteLine($"reverse: {reverseNumber}");
