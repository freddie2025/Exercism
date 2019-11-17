using System;

public enum Schedule
{
    Teenth = 13,
    First = 1,
    Second = 8,
    Third = 15,
    Fourth = 22,
    Last = 0
}

public class Meetup
{
    private readonly int Month;
    private readonly int Year;

    public Meetup(int month, int year)
    {
        Month = month;
        Year = year;
    }

    public DateTime Day(DayOfWeek dayOfWeek, Schedule schedule)
    {
        int daysInMonth = DateTime.DaysInMonth(Year, Month);
        int dayOfMonth = 1;

        if(schedule == Schedule.Last)
        {
            for (int day = daysInMonth; day >= 1; day--)
            {
                if(new DateTime(Year, Month, day).DayOfWeek == dayOfWeek)
                {
                    dayOfMonth = day;
                    break;
                }
            }
        }
        else
        {
            for (int day = (int)schedule; day <= daysInMonth; day++)
            {
                if(new DateTime(Year, Month, day).DayOfWeek == dayOfWeek)
                {
                    dayOfMonth = day;
                    break;
                }
            }
        }
        
        return new DateTime(Year, Month, dayOfMonth);
    }
}