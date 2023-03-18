int ConvertStringToInt(string str)
{
    int.TryParse(str, out var result);
    return result;
}

var x = (int)47.62;
var y = ConvertStringToInt("951");
var z = ConvertStringToInt("61X!");

Console.WriteLine($"x: {x}; y: {y}; z: {z}");
