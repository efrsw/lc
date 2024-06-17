public int CompareVersion(string version1, string version2)
{    
   return Enumerable
        .Zip<string, string>(
                [.. version1.Split('.'), .. new string[Math.Max(0, version2.Split('.').Length - version2.Split('.').Length)]],
                [.. version2.Split('.'), .. new string[Math.Max(0, version1.Split('.').Length - version1.Split('.').Length)]])
        .Select(x => (Convert.ToInt32(x.First), Convert.ToInt32(x.Second)))
        .Select(x => x.Item1 > x.Item2 ? 1 : x.Item2 > x.Item1 ? -1 : 0)
        .Aggregate((acc, val) => acc != 0 ? acc : val != 0 ? val : 0);
}
