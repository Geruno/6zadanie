Console.WriteLine("Введите количество чисел: ");
string str_count = Console.ReadLine();
int count = int.Parse(str_count);
int[] array = new int[count];
for (int i = 0; i < count; i++)
{
    Console.WriteLine($"Введите {i+1} число");
    string str_chisl = Console.ReadLine();
    int chisl = int.Parse(str_chisl);
    array[i] = chisl;
}
int OverNull(int[] array) 
{
int i = 0;
int over = 0;
while (i < count)
{
    if (array[i] > 0)
    {
        over = over +1;
    }
    i = i + 1;
}
return over;
}
Console.WriteLine($"Из введенных чисел больше нуля {OverNull(array)}");