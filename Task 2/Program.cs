System.Console.WriteLine("Введите размер массива ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];

void FillArray(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100,1000);
    }
}
void PrintArray(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.WriteLine();
}

FillArray(numbers);
PrintArray(numbers);
int sum = 0;

for (int j = 0; j < numbers.Length; j+=2)
sum = sum + numbers[j];

Console.WriteLine($"Сумма чисел с нечетными индексами равна {sum}");