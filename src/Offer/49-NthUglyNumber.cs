namespace BasicCoding
{
    public class NthUglyNumberSolution
    {
        public int NthUglyNumber(int n)
        {
            var dp = new int[n];
            dp[0] = 1;
            var indexForTwo = 0;
            var indexForThree = 0;
            var indexForFive = 0;

            var retForTwo = 0;
            var retForThree = 0;
            var retForFive = 0;
            var ret = 0;

            var i = 1;
            while (i < n)
            {
                retForTwo = dp[indexForTwo] * 2;
                retForThree = dp[indexForThree] * 3;
                retForFive = dp[indexForFive] * 5;
                if (retForTwo <= retForThree && retForTwo <= retForFive)
                {
                    indexForTwo++;
                    ret = retForTwo;
                }
                if (retForThree <= retForTwo && retForThree <= retForFive)
                {
                    indexForThree++;
                    ret = retForThree;
                }
                if (retForFive <= retForTwo && retForFive <= retForThree)
                {
                    indexForFive++;
                    ret = retForFive;
                }

                dp[i] = ret;
                i++;
            }

            return dp[n - 1];
        }
    }
}