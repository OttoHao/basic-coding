namespace BasicCoding
{
    public class GetLeastNumbersSolution
    {
        public int[] GetLeastNumbers(int[] arr, int k)
        {
            var ret = new int[k];
            var index = 0;
            var length = arr.Length;
            BuildMinHeap(arr, length);
            for (int i = length - 1; i > 0; i--)
            {
                if (index >= k) break;
                ret[index] = arr[0];
                index++;
                
                Swap(arr, 0, i);
                MinHeadpify(arr, 0, i);
            }
            return ret;
        }

        private void BuildMinHeap(int[] arr, int length)
        {
            for (int i = length / 2; i >= 0; i--)
            {
                MinHeadpify(arr, i, length);
            }
        }

        private void MinHeadpify(int[] arr, int i, int length)
        {
            var left = 2 * i + 1;
            var right = 2 * i + 2;
            var minIndex = i;

            if (left < length && arr[left] < arr[minIndex])
            {
                minIndex = left;
            }

            if (right < length && arr[right] < arr[minIndex])
            {
                minIndex = right;
            }

            if (minIndex != i)
            {
                Swap(arr, i, minIndex);
                MinHeadpify(arr, minIndex, length);
            }
        }

        private void Swap(int[] arr, int a, int b)
        {
            var temp = arr[a];
            arr[a] = arr[b];
            arr[b] = temp;
        }
    }
}