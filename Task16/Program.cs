// Дано число обозначающее день недели. Выяснить является номер недели выходным днём
int GetRandom (int MinValue, int MaxValue)
{
    return new Random ().Next(MinValue,MaxValue);
}
int Number = GetRandom(1,8);  
Console.WriteLine(Number);
void WeekdayOrWeekend (int Number)
{
    if(Number<6) Console.WriteLine("weekday"); // Monday-Friday correspond to numbers 1-5;
    else
    {
        Console.WriteLine("weekend");//Saturday & Sunday - numbers 6-7
    }
}
WeekdayOrWeekend(Number);