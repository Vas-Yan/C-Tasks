// Ввести номер четверти, показать диапазоны для возможных координат
string Range (int QuarterNumber)
{
    string result = string.Empty;
    if (QuarterNumber == 1) result = "X = (0, +infinity); Y = [0, +infinity)";
    if (QuarterNumber == 2) result = "X = (-infinity,0); Y = (0, +infinity)";
    if (QuarterNumber == 3) result = "X = (-infinity,0); Y = (-infinity,0)";
    if (QuarterNumber == 4) result = "X = (0, +infinity); Y = (-infinity,0)";
    return result;
}
Console.WriteLine("insert quarter's # (1-4)");
int QuarterNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Range(QuarterNumber));