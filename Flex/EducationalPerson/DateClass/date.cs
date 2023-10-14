using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flex.EducationalPerson.DateClass
{
    public class Date
    {
        private int m_day, m_month, m_year;

        public Date(int day = 1, int month = 1, int year = 1)
        {
            m_day = day;
            m_month = month;
            m_year = year;
        }
        public Date(string date)
        {
            // string has data with pattern "dd-mm-yy"
            // setting m_day to dd
            // setting m_month to mm
            // setting m_year to yy
            string[] dateTokens = date.Split('-');
            m_day = Int32.Parse(dateTokens[0]);
            m_month = Int32.Parse(dateTokens[1]);
            m_year = Int32.Parse(dateTokens[2]);
        }

        // getters
        public int getYear()
        {
            return m_year;
        }
        public int getMonth()
        {
            return m_month;
        }

        public int getDay()
        {
            return m_day;
        }

        // function to set the date to current system date
        // precodition: system date should be original!
        public void setToCurrent()
        {
            DateTime now = DateTime.Now;
            m_day = now.Day;
            m_month = now.Month;
            m_year = now.Year;
        }

        // overloading writing stream
        public override string ToString()
        {
            return $"{m_day}/{m_month}/{m_year}";
        }

    }
}
