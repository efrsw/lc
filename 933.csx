public class RecentCounter 
{
    private readonly Queue<int> _pings; 

    public RecentCounter() 
    {
        _pings = [];  
    }
    
    public int Ping(int t) 
    {
        while (_pings.TryPeek(out var i) && i < t - 3000) _pings.Dequeue();
        _pings.Enqueue(t);

        return _pings.Count;
    }
}

/**
 * Your RecentCounter object will be instantiated and called as such:
 * RecentCounter obj = new RecentCounter();
 * int param_1 = obj.Ping(t);
 */
