using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConcepts.Logic
{
    public class Date
    {
        private int _year;
        private int _month;
        private int _day;


        public Date(int year, int month, int day)
        {
            Year = validateYear(year);
            Month = validateMonth(month);
            Day = validateDay(day);
        }

        public Date()
        {
            _year = 1900;
            _month = 1;
            _day = 1;
        }

        public int Year
        {
            get => _year;
            set => _year = validateYear(value);
        }
        public int Month
        {
            get => _month;
            set => _month = validateMonth(value);
        }
        public int Day
        {
            get => _day;
            set => _day = validateDay(value);
        }




        private int validateDay(int day)
        {
            if (_month == 2 && day == 29 && isLeapYear(_year))
            {
                return day;
            }

            int[] daysPerMonth = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if (day >= 1 && day <= daysPerMonth[_month])
            {
                return day;
            }

            throw new ArgumentException("day is not valid");
        }

        private bool isLeapYear(int year)
        {
            return year % 400 == 0 || year % 4 == 0 && year % 100 != 0;
        }

        private int validateMonth(int month)
        {
            if (month < 1 || month > 12)
            {
                throw new ArgumentOutOfRangeException("the month is not valid");
            }
            return month;
        }

        private int validateYear(int year)
        {
            if (year < 0)
            {
                throw new ArgumentException("the year not valid");
            }
            return year;
        }
        public override string ToString()
        {
            return $"{Year,4:0000}/{Month,2:00}/{Day,2:00}";
        }
    }
}
