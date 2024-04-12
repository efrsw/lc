public string PredictPartyVictory(string senate)
{
    Queue<int> rQueue = [];
    Queue<int> dQueue = [];
    int nextRoundPos = senate.Length;

    for (var i = 0; i < senate.Length; i++)
    {
        switch (senate[i])
        {
            case 'R': rQueue.Enqueue(i); break;
            case 'D': dQueue.Enqueue(i); break;
            default: throw new ArgumentException("Party is not supported");
        }
    }

    while (true)
    {
        switch (rQueue.TryPeek(out var activeRadiant), dQueue.TryPeek(out var activeDire))
        {
            case (false, true): return "Dire";
            case (true, false): return "Radiant";
            default:
                Console.WriteLine($"Fighting senators: D{activeDire} vs. R{activeRadiant}");
                if (activeRadiant > activeDire)
                {
                    _ = rQueue.Dequeue();
                    dQueue.Dequeue();
                    dQueue.Enqueue(++nextRoundPos);
                }
                else
                {
                    _ = dQueue.Dequeue();
                    rQueue.Dequeue();
                    rQueue.Enqueue(++nextRoundPos);
                }
                break;
        }
    }
}

Console.WriteLine(PredictPartyVictory("RDD"));
