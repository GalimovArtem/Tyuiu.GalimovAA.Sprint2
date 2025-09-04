using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.GalimovAA.Sprint2.Task5.V12.Lib
{
    public class DataService : ISprint2Task5V12
    {
        public string FindDateOfPreviousDay(int g, int m, int n)
        {
            // Проверка на корректность входных данных
            if (m < 1 || m > 12 || n < 1 || n > 31)
            {
                return "Неверные входные данные";
            }

            int prevDay = n - 1;
            int prevMonth = m;
            int prevYear = g;

            // Если день стал 0, переходим к предыдущему месяцу
            if (prevDay == 0)
            {
                prevMonth--;

                // Если месяц стал 0, переходим к предыдущему году
                if (prevMonth == 0)
                {
                    prevMonth = 12;
                    prevYear--;
                }

                // Определяем количество дней в предыдущем месяце
                prevDay = GetDaysInMonth(prevMonth, prevYear);
            }

            return $"{prevYear}.{prevMonth:D2}.{prevDay:D2}";
        }

        private int GetDaysInMonth(int month, int year)
        {
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31;
                case 4:
                case 6:
                case 9:
                case 11:
                    return 30;
                case 2:
                    return IsLeapYear(year) ? 29 : 28;
                default:
                    return 0;
            }
        }

        private bool IsLeapYear(int year)
        {
            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        }
    }
}