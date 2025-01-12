namespace CLRS.LeetCode;

// problem #2126: Destroying Asteroids
public partial class Solution
{
    public bool AsteroidsDestroyed(int mass, int[] asteroids)
    {
        long currentMass = mass;
        Array.Sort(asteroids);

        foreach (int asteroid in asteroids)
        {
            if (currentMass < asteroid)
            {
                return false;
            }

            currentMass += asteroid;
        }

        return true;
    }
}
