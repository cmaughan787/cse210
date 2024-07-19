public class Date
{
    int _day;
    int _month;
    int _year;
    
        public Date(int day, int month, int year)
    {
        _day = day;
        _month = month;
        _year = year;
    }

    // public string DisplayDate(Date date)
    // {
    //    DateTime dateTime = new DateTime(_year, _month, _day);
    //    return dateTime.ToString("D");      
    // }
    public bool IsLeapYear()
    {
        if ((_year % 4 == 0 && _year % 100 != 0) || (_year % 400 == 0))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public int DaysInMonth()
    {
        switch (_month)
        {
            case 1: case 3: case 5: case 7: case 8: case 10: case 12:
                return 31;
            case 4: case 6: case 9: case 11:
                return 30;
            case 2:
                return IsLeapYear() ? 29 : 28;
            default:
                throw new ArgumentException("Invalid month");
        }
    }

    public string DisplayDate()
    {
        return $"{_day:D2}/{_month:D2}/{_year}";
    }

    public bool IsValidDate()
    {
        if (_month < 1 || _month > 12)
        {
            return false;
        }
        if (_day < 1 || _day > DaysInMonth())
        {
            return false;
        }
        return true;
    }
}