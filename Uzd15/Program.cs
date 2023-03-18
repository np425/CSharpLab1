var names = new List<string>
{
    "Jake",
    "Jack",
    "Harry",
    "Jacob",
    "Charlie",
    "Thomas",
    "George",
    "Oscar",
    "James",
    "William"
};

Console.WriteLine("All names:");
names.ForEach(Console.WriteLine);

Console.WriteLine("Harry exists: {0}", names.Contains("Harry"));
Console.WriteLine($"8th index: {names[8]}");

Console.WriteLine("Inserting bob into 4th position...");
names.Insert(5, "Bob");

Console.WriteLine("Removing all names that begin with J");
names.RemoveAll(name => name[0] == 'J');

Console.WriteLine($"Remaining elements amount: {names.Count}");

Console.WriteLine($"Last element: {names.Last()}");

Console.WriteLine("Adding Emily, Megan, Susan, Sarah, Margaret...");
names.Add("Emily");
names.Add("Megan");
names.Add("Susan");
names.Add("Sarah");
names.Add("Margaret");

Console.WriteLine("Sorting...");
names.Sort();

Console.WriteLine("All names:");
names.ForEach(Console.WriteLine);
