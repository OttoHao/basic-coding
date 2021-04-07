namespace BasicCoding
{
    public class CuttingRopeSolution
    {
        public int CuttingRope(int n)
        {
            var sum = 1;
            if (n == 2) return 1;
            if (n == 3) return 2;
            while (n > 4)
            {
                n -= 3;
                sum *= 3;
            }

            sum *= n;
            return sum;
        }
    }
}