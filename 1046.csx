public int LastStoneWeight(int[] stones)
{
    var q = new PriorityQueue<int, int>(Comparer<int>.Create((x, y) => y - x));
    q.EnqueueRange(stones.Select(x => (x, x)));

    while (q.Count != 1)
    {
        var (e1, e2) = (q.Dequeue(), q.Dequeue());
        var newEl = Math.Abs(e1 - e2);
        q.Enqueue(newEl, newEl);
    }
    
    return q.Peek();
}
