namespace Uzd13_b;

public class Program
{
    private double Celsius { get; set; }

    private double Fahrenheit { get; set; }
    private double Kelvin { get; set; }

    private Program(double celsius)
    {
        Celsius = celsius;
    }

    private void TemperatureConversions(double celsius = 30)
    {
        Celsius = celsius;
        Fahrenheit = (celsius * 9 / 5) + 32;
        Kelvin = celsius + 273.15;
    }    
    
    private static void Main()
    {
        Console.Write("Enter celsius: ");
        var celsius = Convert.ToInt32(Console.ReadLine());
        
        var tempConverter = new Program(celsius);
        tempConverter.TemperatureConversions();
        
        Console.WriteLine($"Celsius: {tempConverter.Celsius}");
        Console.WriteLine($"Fahrenheit: {tempConverter.Fahrenheit}");
        Console.WriteLine($"Kelvin: {tempConverter.Kelvin}");
    }
}
