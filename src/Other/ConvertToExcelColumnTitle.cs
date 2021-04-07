using System.Text;

namespace BasicCoding
{
    public class ConvertToExcelColumnTitleSolution
    {
        public string ConvertToTitle(int columnNumber)
        {
            var sb = new StringBuilder();
            
            while (columnNumber > 0)
            {
                columnNumber --;
                var num = columnNumber % 26;
                var c = (char)('A' + num);
                sb.Insert(0, c);
                columnNumber /= 26;
            }

            
            return sb.ToString();

        }
    }
}