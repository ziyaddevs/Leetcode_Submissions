public class Solution {
    public int CalPoints(string[] operations) {
        
        List<int> record = new List<int>();

        foreach(string op in operations)
        {
            if (op == "+")
            {
                // sum of the previous two scores
                record.Add(record[record.Count - 1] + record[record.Count - 2]);
            }
            else if (op == "D")
            {
                record.Add( 2 * record[record.Count - 1]);
            }
            else if (op == "C")
            {
                record.RemoveAt(record.Count - 1);
            }
            else
            {
                record.Add(int.Parse(op));
            }
        }
        return record.Sum();
    }
}