using System.Text;

namespace BasicCoding
{
    public class ReplaceSpaceSolution
    {
        public string ReplaceSpace(string s)
        {
            var sb = new StringBuilder();
            foreach (var item in s)
            {
                if (item == ' ')
                {
                    sb.Append("%20");
                }
                else
                {
                    sb.Append(item);
                }
            }

            return sb.ToString();
        }
    }
}