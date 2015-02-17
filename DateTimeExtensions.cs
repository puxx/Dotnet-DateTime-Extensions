using System;

namespace Tools.Extensions
{
    public static class DateTimeExtensions
    {
        /// <summary>
        /// Get first second of dateTime    
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        public static DateTime StartOfDay(this DateTime dateTime)
        {
            return dateTime.Date;
        }

        /// <summary>
        /// Get last second of dateTime
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        public static DateTime EndOfDay(this DateTime dateTime)
        {
            return new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, 23, 59, 59);
        }

        /// <summary>
        /// Get first day of dateTime month
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        public static DateTime FirstDayOfMonth(this DateTime dateTime)
        {
            return new DateTime(dateTime.Year, dateTime.Month, 1);
        }

        /// <summary>
        /// Get last day of dateTime month
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        public static DateTime LastDayOfMonth(this DateTime dateTime)
        {
            int numberOfDays = DateTime.DaysInMonth(dateTime.Year, dateTime.Month);
            return new DateTime(dateTime.Year, dateTime.Month, numberOfDays);
        }
        
        /// <summary>
        /// Get first day of dateTime week
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        public static DateTime FirstDayOfWeek(this DateTime dateTime)
        {
            DateTime firstDayInWeek = dateTime.Date;

            while (firstDayInWeek.DayOfWeek != DayOfWeek.Monday)
                firstDayInWeek = firstDayInWeek.AddDays(-1);
            return firstDayInWeek.StartOfDay();
        }

        /// <summary>
        /// Get last day of dateTime week
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        public static DateTime LastDayOfWeek(this DateTime dateTime)
        {
            DateTime lastDayInWeek = dateTime.Date;

            while (lastDayInWeek.DayOfWeek != DayOfWeek.Sunday)
                lastDayInWeek = lastDayInWeek.AddDays(1);
            return lastDayInWeek.StartOfDay();
        }

        /// <summary>
        /// Get last second of last day of dateTime month
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        public static DateTime EndOfLastDayOfMonth(this DateTime dateTime)
        {
            int numberOfDays = DateTime.DaysInMonth(dateTime.Year, dateTime.Month);
            return new DateTime(dateTime.Year, dateTime.Month, numberOfDays, 23, 59, 59);
        }

        /// <summary>
        /// Check if datetime consist between two dates include start and end dates
        /// </summary>
        /// <param name="dateTime"></param>
        /// <param name="startDate">Min date</param>
        /// <param name="endDate">Max date</param>
        /// <returns></returns>
        public static bool IsInPeriod(this DateTime dateTime, DateTime startDate, DateTime endDate)
        {
            if (dateTime >= startDate && dateTime <= endDate)
                return true;
            return false;
        }

        /// <summary>
        /// Check if datetime not in two dates not include start and end dates
        /// </summary>
        /// <param name="dateTime"></param>
        /// <param name="startDate">Min date</param>
        /// <param name="endDate">Max date</param>
        /// <returns></returns>
        public static bool IsOutOfPeriod(this DateTime dateTime, DateTime startDate, DateTime endDate)
        {
            if (dateTime < startDate || dateTime > endDate)
                return true;
            return false;
        }

    }
}
