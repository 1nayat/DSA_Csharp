class Program
{
    public static void Main()
    {
        string s = "Bbbanana546";
        Dictionary<char, int> result = FrequencyMap(s);
        foreach(var item in result)
        {
            Console.WriteLine($"{item.Key} -> {item.Value}");
        }
    }
    public static Dictionary<char,int> FrequencyMap(string s)
    {
        var count = new Dictionary<char, int>();
        
        foreach(char c in s)
        {
            count.TryGetValue(c, out int exixting);
            count[c] = exixting + 1;
        }
        return count;
    }

}