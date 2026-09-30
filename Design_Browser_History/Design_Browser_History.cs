public class BrowserHistory {
    private List<string> history;
    private int currentIndex;

    public BrowserHistory(string homepage) {
        history = new List<string>();
        history.Add(homepage);
        currentIndex = 0;
    }
    
    public void Visit(string url) {
        // 1. Clear all forward history by removing everything after the current index
        if (currentIndex < history.Count - 1) {
            history.RemoveRange(currentIndex + 1, history.Count - (currentIndex + 1));
        }
        
        // 2. Add the new URL and move our pointer forward
        history.Add(url);
        currentIndex++;
    }
    
    public string Back(int steps) {
        // Move back, but don't go past index 0
        currentIndex = Math.Max(0, currentIndex - steps);
        return history[currentIndex];
    }
    
    public string Forward(int steps) {
        // Move forward, but don't go past the end of the history list
        currentIndex = Math.Min(history.Count - 1, currentIndex + steps);
        return history[currentIndex];
    }
}