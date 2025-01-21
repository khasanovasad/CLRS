namespace CLRS.LeetCode;

// problem #146: LRU Cache
public partial class Solution
{
    public class LRUCache
    {
        private readonly Dictionary<int, LinkedListNode<KeyValuePair<int, int>>> map = [];
        private readonly LinkedList<KeyValuePair<int, int>> list = [];
        private readonly int capacity;

        public LRUCache(int capacity)
        {
            this.capacity = capacity;
        }
        
        public int Get(int key)
        {
            if (map.TryGetValue(key, out LinkedListNode<KeyValuePair<int, int>> node))
            {
                int value = node.Value.Value;

                list.Remove(node);
                map[key] = new LinkedListNode<KeyValuePair<int, int>>(new KeyValuePair<int, int>(key, value));
                list.AddFirst(map[key]);

                return value;
            }
            else
            {
                return -1;
            }
        }
        
        public void Put(int key, int value)
        {
            if (map.TryGetValue(key, out LinkedListNode<KeyValuePair<int, int>> node))
            {
                list.Remove(node);
                map.Remove(key);
            }

            map[key] = new LinkedListNode<KeyValuePair<int, int>>(new KeyValuePair<int, int>(key, value));
            list.AddFirst(map[key]);
            if (list.Count > capacity)
            {
                var nodeToRemove = list.Last;
                list.Remove(nodeToRemove);
                map.Remove(nodeToRemove.Value.Key);
            }
        }
    }

    /**
    * Your LRUCache object will be instantiated and called as such:
    * LRUCache obj = new LRUCache(capacity);
    * int param_1 = obj.Get(key);
    * obj.Put(key,value);
    */
}
