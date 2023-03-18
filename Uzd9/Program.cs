int[] a = {1,2,2,2,9,7,1,10,3};
int[] b = {3,9};

var filtered = a.Where(n => !Array.Exists(b, e => e == n)).ToHashSet();

Console.WriteLine("output: {0}", String.Join(",", filtered));
