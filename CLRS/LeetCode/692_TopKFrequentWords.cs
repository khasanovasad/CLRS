namespace CLRS.LeetCode;

// 692. Top K Frequent Words
public partial class Solution
{
    // O (n) to build a hashmap
    // O (n log k) to build heap
    // O (n)
    public IList<string> TopKFrequent(string[] words, int k)
    {
        // O (n) time and O (n) space
        var map = new Dictionary<string, int>();
        foreach (string word in words)
        {
            if (!map.ContainsKey(word))
            {
                map.Add(word, 0);
            } 
            ++map[word];
        }

        // O (n log k)
        var heap = new PriorityQueue<string, WordPriority>();
        foreach (var (word, frequency) in map)
        {
            heap.Enqueue(word, new WordPriority(frequency, word));

            while (heap.Count > k)
            {
                heap.Dequeue();
            }
        }

        // O (k logk)
        var answer = new string[k];
        int i = k - 1;
        while (heap.Count > 0)
        {
            answer[i--] = heap.Dequeue();
        }

        // O (n) or O (1)
        return new List<string>(answer);
    }

    public struct WordPriority : IComparable<WordPriority>
    {
        public int Frequency { get; }
        public string Word { get; }
        
        public WordPriority(int frequency, string word)
        {
            Frequency = frequency;
            Word = word;
        }
        
        public int CompareTo(WordPriority other)
        {
            if (Frequency != other.Frequency)
                return Frequency - other.Frequency;
            
            return other.Word.CompareTo(Word);
        }
    }
}