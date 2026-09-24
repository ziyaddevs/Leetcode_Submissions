public class Solution {
    public int CalPoints(string[] operations)
    {
        int n = operations.Length;
        List<int> record = new List<int>();

        for(int i = 0; i < n; i++)
        {
            // if its a number, parse and add it.
            if(int.TryParse(operations[i], out int score))
            {
                record.Add(score);
            }
            // if it's "+"
            else if(operations[i] == "+")
            {
                int sum = record[record.Count - 1] + record[record.Count - 2];
                record.Add(sum);
            }
            // 3. if it's a "c"
            else if(operations[i] == "C")
            {
                record.RemoveAt(record.Count - 1);
            }
            // 4. if it's a "D" (Double)
            else if(operations[i] == "D")
            {
                int doubleScore = record[record.Count - 1] * 2;
                record.Add(doubleScore);
            }
        }
        // now we return the total sum of all the elements in the record.
        int totalSum = 0;
        foreach(int num in record)
        {
            totalSum += num;
        }
        return totalSum;
        
    }
}