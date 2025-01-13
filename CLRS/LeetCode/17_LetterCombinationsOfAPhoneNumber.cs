namespace CLRS.LeetCode;

// problem #17: Letter Combinations of a Phone Number
public partial class Solution
{
    Dictionary<char, char[]> PhoneNumberMap = new Dictionary<char, char[]>
    {
        { '2', ['a', 'b', 'c'] },
        { '3', ['d', 'e', 'f'] },
        { '4', ['g', 'h', 'i'] },
        { '5', ['j', 'k', 'l'] },
        { '6', ['m', 'n', 'o'] },
        { '7', ['p', 'q', 'r', 's'] },
        { '8', ['t', 'u', 'v'] },
        { '9', ['w', 'x', 'y', 'z'] }
    };

    public IList<string> LetterCombinations(string digits)
    {
        var answer = new List<string>();

        if (digits.Length > 0)
        {
            LetterCombinationsBacktrack(digits, answer, new List<char>(), 0);
        }
        
        return answer;
    }

    public void LetterCombinationsBacktrack(string digits, List<string> answer, List<char> current, int index)
    {
        if (current.Count == digits.Length)
        {
            answer.Add(new string(current.ToArray()));
            return;
        }

        var letters = PhoneNumberMap[digits[index]];
        foreach (char c in letters)
        {
            current.Add(c);
            LetterCombinationsBacktrack(digits, answer, current, index + 1);
            current.RemoveAt(current.Count - 1);
        }
    }
}
