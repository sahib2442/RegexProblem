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
        public void Pincode2(string pincode)
        {
            Pincode(pincode);
        }
        public void Pincode3(string pincopde)
        {
            Pincode(pincopde);
        }
        public void Pincode4(string pincode)
        {
            Regex regex = new Regex(PINCODE_REGEX);
            bool result = regex.IsMatch(pincode);
            Console.WriteLine(result);

        }
    }
}
