int number1 = 10;
int number2 = 11;

number1 = number2;

Console.WriteLine(number1 + "\n");

int[] numbers1 = { 1, 2, 3 };
int[] numbers2 = { 4, 5, 6 };

numbers1 = numbers2;

foreach (int number in numbers1)
{
    Console.WriteLine(number);
}

