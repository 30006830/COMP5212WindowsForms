using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsExercise
{
    public class Calculate
    {
        public string num1 { get; set; }
        public string num2 { get; set; }
        public char opp { get; set; }

        public double Addition()
        {
            double x = double.Parse(num1) + double.Parse(num2);
            num1 = x.ToString();
            num2 = "";
            return x;
        }
        public double Subtraction()
        {
            double x = double.Parse(num1) - double.Parse(num2);
            num1 = x.ToString();
            num2 = "";
            return x;
        }
        public double Multiplication()
        {
            double x = double.Parse(num1) * double.Parse(num2);
            num1 = x.ToString();
            num2 = "";
            return x;
        }
        public double Division()
        {
            double x = double.Parse(num1) / double.Parse(num2);
            num1 = x.ToString();
            num2 = "";
            return x;
        }
    }
}
