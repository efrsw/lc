public int[] AsteroidCollision(int[] asteroids)
{
    /*
     * - [5, -5, 10]
     * 5 [-5, 10]
     * - [10]
     * 10 [-]
     *
     * - [10, 2, -5]
     * 10 [2, -5]
     * 10 2 [-5]
     * 10 [-5]
     * 10 [-]
     */

    Stack<int> s = [];

    for (var i = asteroids.Length - 1; i >= 0; i--)
    {
        if (s.Count == 0 || s.Peek() > 0 || asteroids[i] < 0)
        {
            s.Push(asteroids[i]);
        } 
        else if (-s.Peek() == asteroids[i])
        {
            s.Pop();
        }
        else if (-s.Peek() < asteroids[i])
        {
            s.Pop();
            i++;
        }
    }

    return s.ToArray();
}
