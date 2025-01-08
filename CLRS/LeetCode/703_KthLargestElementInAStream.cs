namespace CLRS.LeetCode;

// problem: 703: Kth Largest Element in a Stream
public partial class Solution
{
    public class KthLargest
    {
        private readonly PriorityQueue<int, int> heap = new PriorityQueue<int, int>();
        private readonly int K = 0;

        public KthLargest(int k, int[] nums)
        {
            foreach (int num in nums)
            {
                heap.Enqueue(num, num);

                if (heap.Count > k)
                {
                    heap.Dequeue();
                }
            }

            K = k;
        }
        
        public int Add(int val)
        {
            heap.Enqueue(val, val);
            if (heap.Count > K)
            {
                heap.Dequeue();
            }

            return heap.Peek();
        }
    }

    /**
    * Your KthLargest object will be instantiated and called as such:
    * KthLargest obj = new KthLargest(k, nums);
    * int param_1 = obj.Add(val);
    */
}
