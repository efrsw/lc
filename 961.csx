public int RepeatedNTimes(int[] nums) 
{
    HashSet<int> uniq = [];

    foreach (int n in nums) 
        if (!uniq.Add(n)) return n;

    return 0;
}
