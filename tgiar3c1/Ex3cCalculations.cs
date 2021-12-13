using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tgiar3c1
{
   public class Ex3cCalculations
    {
        public static string  Calc0(int index)
        {
            string[] days = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

            string weekdays = "";
            if (index >= 1 && index < 8)
            {
                weekdays = days[index - 1];
                return weekdays;
            }

            return "Invalid index";
        }

        public static string Calc1(string search)
        {
            search = search.Trim();
            search = search.ToUpper();
            string[] days = { "SUNDAY", "MONDAY", "TUESDAY", "WEDNESDAY", "THURSDAY", "FRIDAY", "SATURDAY" };
            string[] hours = { "Closed", "10am - 6pm", "10am - 6pm", "10am - 6pm", "10am - 9pm", "10am - 6pm", "8am - 4pm" };

            int index = Array.IndexOf(days, search);
            if (index >= 0 && index <= 6)
            {
                return hours[index];
            }

            return "Invalid input";
        }

        public static int Calc2(int[] numbers)
        {
            int sum = 0;
            foreach (int total in numbers)
                sum += total;

            return sum;
        }
        public static double Calc3(double[] numbers, int count)
        {
            double sum = 0.0;
            int length = numbers.GetLength(0);
            if (count >= 0 && count <= length)
            {
                for (int i = 0; i < count; i++)
                    sum += numbers[i];

                return sum;
            }

            return sum;
       
        }
        public static double Calc5(double[] numbers)
        {
            double avg = 0.0;
            int length = numbers.GetLength(0);
            if (length > 0)
            {
                avg = Calc3(numbers, length) / length;
                return avg;
            }
            return -1;
        }

        public static double[]  Calc6(double[] numbers)
        {
            int length = numbers.GetLength(0);
            List<Double> aboveAvgList = new List<double>();
            if (length > 0)
            {
                double avg = Calc5(numbers);

                //aboveAvgList.Add(numbers[2]);
                //aboveAvgList.Add(numbers[3]);
                foreach(double number in numbers)
                {
                    if (number > avg)
                        aboveAvgList.Add(number);
                }
            }

            return aboveAvgList.ToArray();
        }
    }
}
