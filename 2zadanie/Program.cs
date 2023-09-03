int k = 1;
int b = 0;
int xCord = 0;
int yCord = 0;
double[] line1 = VvodLine(1);
double[] line2 = VvodLine(2);
double Vvod(string message)
{
    Console.WriteLine(message);
    string stringValue = Console.ReadLine();
    double value = Convert.ToDouble(stringValue);
    return value;
}
double[] VvodLine(int number)
{
    double[] line = new double[2];
    line[b] = Vvod($"Введите b{number}");
    line[k] = Vvod($"Введите k{number}");
    return line;
}
double[] FindCord(double[] line1, double[] line2)
{
    double[] cord = new double[2];
    cord[xCord] = (line1[b] - line2[b]) / (line2[k] - line1[k]);
    cord[yCord] = line2[k] * cord[xCord] + line2[b];
    return cord;
}
if (line1[k] == line2[k])
{
    if (line1[b] == line2[b])
    {
        Console.WriteLine("Прямые совпадают");
    }
    else
    {
        Console.WriteLine("Прямые паралельны");
    }
}
else 
{
double[] cord = FindCord(line1, line2);
System.Console.Write($" Точка пересечения уравнений y = {line1[b]} * x + {line1[k]} \n" +
$"y = {line2[b]} * x + {line2[k]} ");
System.Console.WriteLine($"имеет координаты ({cord[xCord]}, {cord[yCord]})");
}
