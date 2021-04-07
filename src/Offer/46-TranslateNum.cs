namespace BasicCoding
{
    public class TranslateNumSolution
    {
        // f(i) = f(i-1) 
        // f(i) = f(i-1) + f(i-2)
        public int TranslateNum(int num)
        {
            int cur = 0;
            int pre = -1;
            int preCount = 1;
            int count = 1;
            while (num > 0)
            {
                cur = num % 10;

                var newCount = count;
                if (cur == 1 && pre >= 0) newCount += preCount;
                if (cur == 2 && pre <= 5 && pre >= 0) newCount += preCount;
                
                num /= 10;

                preCount = count;
                count = newCount;
                pre = cur;
            }

            return count;
        }
    }
}