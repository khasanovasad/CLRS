using System;
using System.Collections.Generic;
using System.Text;

namespace CLRS.LeetCode
{
    // Yandex Contest questions and answers: https://contest.yandex.ru/contest/8458/enter/?utm_source=habr&utm_content=post070519
    public partial class Solution
    {

        // jewels and stones problem
        public static void Main1(string[] args)
        {
            string j = Console.ReadLine();
            string s = Console.ReadLine();

            var map = new HashSet<char>(j);
            int answer = 0;
            foreach (char c in s)
            {
                if (map.Contains(c))
                {
                    answer++;
                }
            }

            Console.WriteLine(answer);
        }

        // return the length of the maximum subarray containing only 1s
        public static void Main2(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());

            int answer = 0;
            int currentAnswer = 0;
            for (int i = 0; i < n; ++i)
            {
                if (1 == Int32.Parse(Console.ReadLine()))
                {
                    ++currentAnswer;
                    answer = Math.Max(currentAnswer, answer);
                }
                else
                {
                    currentAnswer = 0;
                }
            }

            Console.WriteLine(answer);
        }

        // remove duplicates from the array
        // using constant memory
        public static void Main3(string[] args)
        {
            /*
            int n = Int32.Parse(Console.ReadLine());

            var answer = new HashSet<int>();
            for (int i = 0; i < n; ++i)
            {
                answer.Add(Int32.Parse(Console.ReadLine()));
            }

            foreach (int num in answer)
            {
                Console.WriteLine(num);
            }
            */
            var reader = Console.In;
            var writer = Console.Out;

            int n = int.Parse(reader.ReadLine());

            int previous = int.MinValue;
            bool isFirst = true;

            for (int i = 0; i < n; ++i)
            {
                int current = int.Parse(reader.ReadLine());
                if (isFirst || current != previous)
                {
                    writer.WriteLine(current);
                    previous = current;
                    isFirst = false;
                }
            }
        }

        // generate valid parenthesis
        public static void Main4(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());

            var answer = new List<string>();
            Main4Backtrack(answer, 0, 0, new StringBuilder(), n);

            foreach (string str in answer)
            {
                Console.WriteLine(str);
            }
        }

        public static void Main4Backtrack(List<string> answer, int leftCount, int rightCount, StringBuilder current, int n)
        {
            if (current.Length == n * 2)
            {
                answer.Add(current.ToString());
                return;
            }

            if (leftCount < n)
            {
                current.Append('(');
                Main4Backtrack(answer, leftCount + 1, rightCount, current, n);
                current.Remove(current.Length - 1, 1);
            }

            if (rightCount < leftCount)
            {
                current.Append(')');
                Main4Backtrack(answer, leftCount, rightCount + 1, current, n);
                current.Remove(current.Length - 1, 1);
            }
        }

        // check for anagrams
        public static void Main5(string[] args)
        {
            string str1 = new string(Console.ReadLine().OrderBy(x => x).ToArray());
            string str2 = new string(Console.ReadLine().OrderBy(x => x).ToArray());

            Console.WriteLine(str1.Equals(str2) ? 1 : 0);
        }
    }
}
