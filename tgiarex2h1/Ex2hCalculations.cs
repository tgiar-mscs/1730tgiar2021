using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace tgiarex2h1
{
    public class Ex2hCalculations
    {
        public static string DateCalc06(string strYear, string strMonth, string strDay)
        {
            string result = "Invalid input";
            DateTime date;
            try
            {
                int year = Int32.Parse(strYear);
                int month = Int32.Parse(strMonth);
                int day = Int32.Parse(strDay);
                date = new DateTime(year, month, day);
                result = date.ToShortDateString();
            }
            catch { }


            return result;
        }
        public static string DateCalc07(string strDate)
        {
            string result = "Invalid input";
            DateTime date;
            try
            {
                date = DateTime.Parse(strDate);
                result = date.ToShortDateString();
            }
            catch { }


            return result;
        }
        public static string DateCalc08(string strDate)
        {
            string result = "Invalid input";
            DateTime date;
            DateTime.TryParse(strDate, out date);
            result = date.ToShortDateString();

            return result;
        }
        public static string DateCalc09(string strA, string strB)
        {
            string result = "Invalid input";
            DateTime dateA, dateB;
            try
            {
                dateA = DateTime.Parse(strA);
                dateB = DateTime.Parse(strB);
                TimeSpan daysTotal = dateA - dateB;
                int days = daysTotal.Days;
                result = days.ToString() + " days";
            }
            catch { }

            return result;

        }

        public static string DateCalc10(string strA, string strB)
        {
            string result = "Invalid input";
            DateTime dateA, dateB;
            try
            {
                dateA = DateTime.Parse(strA);
                dateB = DateTime.Parse(strB);
                TimeSpan daysTotal = dateA - dateB;
                int days = daysTotal.Days;

                if (dateA > dateB)
                    result = days.ToString() + " days past due";
                else
                    result = "On time";

            }
            catch { }

            return result;
        }
        public static string StringCalc01(string s)
        {
            string result = "Invalid input";
            try
            {
                int index1 = s.IndexOf("");
                s = s.Trim();
                s = s.Remove(0, index1 + 1);
                s = s.Insert(0, "cr");
                result = s;
            }
            catch { }

            return result;
        }
        public static string StringCalc02(string s)
        {
            string result = "Invalid input";
            try
            {
                if (s.Length >= 2)
                {
                    int index1 = s.IndexOf("");
                    s = s.Trim();
                    s = s.Remove(1, index1 + 1);
                    s = s.Insert(1, "rit");
                    result = s;
                }
            }
            catch { }

            return result;
        }

        public static string StringCalc03(string s)
        {
            string result = "Invalid input";
            try
            {
                int index1 = s.IndexOf("");
                s = s.Trim();
                string AB = s.Substring(2, 4).ToUpper();
                s = AB;
                result = s;
            }
            catch { }

            return result;

        }
        public static string StringCalc04(string s)
        {
            string result = "Invalid input";
            try
            {
                int index1 = s.IndexOf("");
                s = s.Trim();
                s = s.PadLeft(10, '*');
                result = s;
            }
            catch { }

            return result;
        }
        public static string StringCalc05(string s)
        {
            string result = "Invalid input";
            try
            {
                int index1 = s.IndexOf("");
                s = s.Trim();
                s = s.Replace("(", "");
                s = s.Replace(")", "");
                s = s.Replace(" ", "");
                s = s.Replace("-", "");
                result = s;
            }
            catch { }

            return result;
        }
        public static string StringCalc06(string s)
        {
            string result = "Invalid input";          
            int index1 = s.IndexOf("");

            s = s.Trim();
            s = s.Replace("(", "");
            s = s.Replace(")", "");
            s = s.Replace(" ", "");
            s = s.Replace("-", "");

            if (s.Length == 7)
            {
                s = s.Insert(3, ".");
                result = s;
            }
            else if (s.Length == 10)
            {
                s = s.Insert(3, ".");
                s = s.Insert(7, ".");
                result = s;
            }

            else 
                return result;              
            
            return result;
        }
        public static string StringCalc07(string s)
        {
            string result = "Not found";
            string road = "pioneer";

            s = s.ToLower();

            if (s.Contains(road))
                result = "Found";

            return result;
        }
        public static string StringCalc08(string s)
        {
            string result = "Invalid input";

            s = s.Trim();
            int index1 = s.IndexOf(",");

            string city = "";

            if (index1 == -1)
                return result;

            else
                city = s.Substring(index1);
            city = city.Remove(0, +2);

            result = city;
            return result;
        }
        public static string StringCalc09(string s)
        {
            string result = "Invalid input";

            s = s.Trim();
            int zip = s.LastIndexOf(" ");

            if (zip == -1)
                return result;

            else
                s = s.Remove(0, zip + 1);
            result = s;

            return result;

        }
        public static string StringCalc10(string s1, string s2, string s3)
        {
            string result = "Invalid input";

            StringBuilder sb = new StringBuilder(100);
            try
            {
                sb.Append(s1 + ", " + s2 + ", " + s3);
                result = sb.ToString();
            }
            catch { }

            return result;
        }
    }
}