namespace Hot100
{
    public class HammingDistanceSolution
    {
        public int HammingDistance(int x, int y)
        {
            var xor = x ^ y;
            var count = 0;
            while (xor != 0)
            {
                xor &= xor - 1;
                count++;
            }

            return count;
        }
    }
}