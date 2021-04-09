namespace BasicCoding
{
    public class LongestPalindromeSolution
    {
        private int _maxPalindromeLength;
        private int _palindromeStart;

        public string LongestPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s)) return "";

            var length = s.Length;

            _maxPalindromeLength = 0;
            _palindromeStart = 0;

            for (int i = 0; i < length; i++)
            {
                CheckPalindrome(s, length, i, i);
                CheckPalindrome(s, length, i, i + 1);
            }

            return s.Substring(_palindromeStart, _maxPalindromeLength);
        }

        private void CheckPalindrome(string str, int length, int left, int right)
        {
            while (left >= 0 && right < length && str[left] == str[right])
            {
                left--;
                right++;
            }

            var palindromeLength = right - left - 1;
            if (palindromeLength > _maxPalindromeLength)
            {
                _maxPalindromeLength = palindromeLength;
                _palindromeStart = left + 1;
            }
        }
    }
}