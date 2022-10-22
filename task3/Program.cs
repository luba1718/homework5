// Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
Console.WriteLine("Введите размер массива  ");
int size = Convert.ToInt32(Console.ReadLine());
int[] number = new int[size];
FillArrayRandomNumbers(number);
PrintArray(number);
int min = Int32.MaxValue;
int max = Int32.MinValue;
    for (int j = 0; j < number.Length; j++)
{
    if (number[j] > max)
        {
            max = number[j];
        }
    if (number[j] < min)
        {
            min = number[j];
        }
}
Console.Write($" Максимальное значение = {max}, минимальное значение = {min} -> разница {max - min}");
void FillArrayRandomNumbers(int[] number)
{
    for(int i = 0; i < number.Length; i++)
        {
            number[i] = Convert.ToInt32(new Random().Next(1,100));
        }
}
void PrintArray(int[] number)
{
    for(int i = 0; i < number.Length; i++)
        {
            Console.Write(number[i] + " ");
        }
    Console.WriteLine();
}
