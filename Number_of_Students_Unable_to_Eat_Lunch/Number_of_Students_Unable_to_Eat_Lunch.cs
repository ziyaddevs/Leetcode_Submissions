public class Solution {
    public int CountStudents(int[] students, int[] sandwiches) {
        int preferredZero = 0;
        int preferredOnes = 0;

        foreach(int student in students)
        {
            if(student == 0) preferredZero++;
            else preferredOnes++;
        }

        for(int i = 0; i < sandwiches.Length; i++)
        {
            int currentSandwich = sandwiches[i];


            if(currentSandwich == 0 && preferredZero > 0)
            {
                preferredZero--;
            }
            else if (currentSandwich == 1 && preferredOnes > 0)
            {
                preferredOnes--;
            }
            else
            {
                break;
            }
        }
        return preferredZero + preferredOnes;

    }
}