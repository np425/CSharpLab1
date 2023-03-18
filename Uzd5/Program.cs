Console.Write("Enter number: ");
var number = Convert.ToInt32(Console.ReadLine());
var bigger = number % 10 * (number / 1000 % 10) > number / 10 % 10 * (number / 100 % 10);
Console.WriteLine("digits are " + (bigger ? "bigger" : "smaller"));
