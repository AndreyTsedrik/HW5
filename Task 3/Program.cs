Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[size];
FillArray(numbers);
PrintArray(numbers);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int s = 0; s < numbers.Length; s++)
{
    if (numbers[s] > max)
        {
            max = numbers[s];
        }
    if (numbers[s] < min)
        {
            min = numbers[s];
        }
}

Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");

void FillArray(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
}
void PrintArray(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    Console.WriteLine();
}