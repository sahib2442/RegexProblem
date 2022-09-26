using System;
using System.Text.RegularExpressions;
namespace RegexProblemStatement
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Validate validate = new Validate();
            validate.Pincode("400088");
            validate.Pincode("^400088");
            validate.Pincode("400088");
        }

    }
}
