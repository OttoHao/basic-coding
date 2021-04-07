namespace BasciCoding
{
    public class NumOfOneSolution
    {
        public int HammingWeight(uint n)
        {
            var count = 0;
            while (n != 0)
            {
                n &= (n - 1);
                count++;
            }

            return count;
        }
    }
}