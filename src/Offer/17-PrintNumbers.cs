using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicCoding
{
    public class PrintNumbersSolution
    {
        private IList<string> _ret = new List<string>();
        public int[] PrintNumbers(int n)
        {
            var path = new char[n];
            Recur(n, path, 0);

            return _ret.Skip(1).Select(item => int.Parse(item)).ToArray();
        }

        private void Recur(int n, char[] path, int index)
        {
            if (index == n)
            {
                _ret.Add(ConvertPath(path));
                return;
            }
            for (int i = 0; i < 10; i++)
            {
                path[index] = char.Parse(i.ToString());
                Recur(n, path, index+1);
            }
        }

        private string ConvertPath(char[] path)
        {
            var ret = new string(path);

            ret.Trim('0');

            return ret;
        }
    }
}