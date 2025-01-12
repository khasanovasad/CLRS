namespace CLRS.LeetCode;

// problem #881: Boats to Save People
// notes: intuition is that we need to pair the heaviest person with the lightest person
// if the pairing goes beyond the limit, we will just put the heaviest person
// in it's own boat
public partial class Solution
{
    public int NumRescueBoats(int[] people, int limit)
    {
        int left = 0;
        int right = people.Length - 1;
        int answer = 0;

        Array.Sort(people);

        while (left <= right)
        {
            if (people[left] + people[right] <= limit)
            {
                left++;
            }

            right--;
            answer++;
        }

        return answer;
    }
}
