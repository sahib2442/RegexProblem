using System;
using System.Text.RegularExpressions;
namespace RegexProblemStatement
{
    public class Validate
    {
        public const string PINCODE_REGEX_NUM = "^[0-9]{6}$";
        public const string PINCODE_REGEX = "^([0-9]+([ ][0-9]){0,1}){6,7}$";
        public void Pincode(string pincode)
        {
            Regex regex = new Regex(PINCODE_REGEX_NUM);
            bool result = regex.IsMatch(pincode);
            Console.WriteLine(result);
        }
        
    }
}
