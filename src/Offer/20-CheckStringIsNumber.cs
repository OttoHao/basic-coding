using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCoding
{
    //todo check offical answer
    public class CheckStringIsNumberSolution
    {
        // (num)(e/E)(num)
        // ((+/-)(a.b))(e/E)((+/-)(a))
        private IList<char> _nums = new List<char> { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        public bool IsNumber(string s)
        {
            if (s == null) return false;
            var splited = s.ToLower().Trim().Split('e');
            if (splited.Length > 2)
            {
                return false;
            }

            if (splited.Length == 2)
            {
                return IsNormalNumber(splited[0]) && IsSignInt(splited[1]);
            }

            return IsNormalNumber(splited[0]);
        }

        private bool IsSignInt(string input)
        {
            if (input.Length == 0) return false;
            if (input[0] == '+' || input[0] == '-')
            {
                return IsInt(input.Substring(1));
            }

            return IsInt(input);

        }

        private bool IsNormalNumber(string input)
        {
            if (input.Length == 0) return false;
            if (input[0] == '+' || input[0] == '-')
            {
                return IsUnSignNumber(input.Substring(1));
            }

            return IsUnSignNumber(input);
        }

        private bool IsUnSignNumber(string input)
        {
            var splited = input.Split('.');

            if (splited.Length > 2)
            {
                return false;
            }

            if (splited.Length == 2)
            {
                var a = string.IsNullOrEmpty(splited[0]) && IsInt(splited[1]);
                var b = IsInt(splited[0])&& string.IsNullOrEmpty(splited[1]);
                var c = IsInt(splited[0]) && IsInt(splited[1]);
                return a || b || c;
            }

            return IsInt(splited[0]);
        }

        private bool IsInt(string input)
        {
            if (input.Length == 0) return false;
            foreach (var item in input)
            {
                if (!_nums.Contains(item))
                {
                    return false;
                }
            }

            return true;
        }
    }
}