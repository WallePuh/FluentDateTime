using System;
using System.Globalization;
using FluentDate;


namespace FluentDateTime
{
    public static class Months
    {

        public static DateTime January(this int number)
        {
            return new DateTime(number, 1, 1);
        }

        public static DateTime January(this DateTime date)
        {
            return date.SetMonth(1);
        }

        public static DateTime February(this int number)
        {
            return new DateTime(number, 2, 1);
        }

        public static DateTime February(this DateTime date)
        {
            return date.SetMonth(2);
        }
        public static DateTime March(this int number)
        {
            return new DateTime(number, 3, 1);
        }

        public static DateTime March(this DateTime date)
        {
            return date.SetMonth(3);
        }
        public static DateTime April(this int number)
        {
            return new DateTime(number, 4, 1);
        }

        public static DateTime April(this DateTime date)
        {
            return date.SetMonth(4);
        }
        public static DateTime May(this int number)
        {
            return new DateTime(number, 5, 1);
        }

        public static DateTime May(this DateTime date)
        {
            return date.SetMonth(5);
        }
        public static DateTime June(this int number)
        {
            return new DateTime(number, 6, 1);
        }

        public static DateTime June(this DateTime date)
        {
            return date.SetMonth(6);
        }
        public static DateTime July(this int number)
        {
            return new DateTime(number, 7, 1);
        }

        public static DateTime July(this DateTime date)
        {
            return date.SetMonth(7);
        }
        public static DateTime August(this int number)
        {
            return new DateTime(number, 8, 1);
        }

        public static DateTime August(this DateTime date)
        {
            return date.SetMonth(8);
        }
        public static DateTime September(this int number)
        {
            return new DateTime(number, 9, 1);
        }

        public static DateTime September(this DateTime date)
        {
            return date.SetMonth(9);
        }

        public static DateTime October(this int number)
        {
            return new DateTime(number, 10, 1);
        }

        public static DateTime October(this DateTime date)
        {
            return date.SetMonth(10);
        }

        public static DateTime November(this int number)
        {
            return new DateTime(number, 11, 1);
        }

        public static DateTime November(this DateTime date)
        {
            return date.SetMonth(11);
        }

        public static DateTime December(this int number)
        {
            return new DateTime(number, 12, 1);
        }

        public static DateTime December(this DateTime date)
        {
            return date.SetMonth(12);
        }
    }
}