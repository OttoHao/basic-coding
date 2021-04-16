namespace BasicCoding
{
    public class ReverseLeftInWordSolution
    {
        public string ReverseLeftWords(string s, int n)
        {
            var left = s.Substring(0, n);
            var right = s.Substring(n);

            return right + left;
        }
    }
}