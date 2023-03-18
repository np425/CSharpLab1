static bool NumberContainsDigit3(int number) {
    while (number != 0) {
        if (number % 10 == 3) {
            return true;
        }
        number /= 10;
    }
    return false;
}

for (var a = 1; a <= 10; a++) {
    Console.WriteLine(a + "x");
    for (var b = 1; b <= 10; b++) {
        var contains3 = NumberContainsDigit3(a) || NumberContainsDigit3(b) || NumberContainsDigit3(a*b);
        Console.WriteLine("{0} x {1} = {2} -> {3}", a, b, a*b, contains3 ? "true" : "false");
    }
    Console.WriteLine();
}
