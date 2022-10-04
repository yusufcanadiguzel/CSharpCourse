for (int i = 0; i <= 100; i += 10)
{
    Console.WriteLine(i + "\n");
}

int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

for (int i = 0, x = numbers.Length; i < x; i++)
{
    Console.WriteLine(numbers[i]);
}

Console.WriteLine("For loop is over.\n");

foreach (var number in numbers)
{
    Console.WriteLine(number);
}

Console.WriteLine("Foreach loop is over.");
