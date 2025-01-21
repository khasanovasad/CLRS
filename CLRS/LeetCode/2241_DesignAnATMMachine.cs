namespace CLRS.LeetCode;

// problem #2241: Design an ATM Machine
public partial class Solution
{
    public class ATM
    {
        public readonly int[] denominators = [20, 50, 100, 200, 500];
        public readonly int[] stores = [0, 0, 0, 0, 0];

        public ATM()
        {
        }
        
        public void Deposit(int[] banknotesCount)
        {
            for (int i = 0; i < banknotesCount.Length; ++i)
            {
                stores[i] += banknotesCount[i];
            }            
        }
        
        public int[] Withdraw(int amount)
        {
            var answer = new int[5];

            int i = 4;
            while (amount > 0 && i >= 0)
            {
                int takeThisMany = Math.Min(amount / denominators[i], stores[i]);
                answer[i] = takeThisMany;
                amount -= takeThisMany * denominators[i];

                --i;
            }

            if (amount == 0)
            {
                for (int j = 0; j < 5; ++j)
                {
                    stores[j] -= answer[j];
                }
                return answer;
            }
            else
            {
                return [-1];
            }
        }
    }

    /**
    * Your ATM object will be instantiated and called as such:
    * ATM obj = new ATM();
    * obj.Deposit(banknotesCount);
    * int[] param_2 = obj.Withdraw(amount);
    */
}
