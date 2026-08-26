class Program
{
    static void Main()
    {
        string text = "inayat";
        int[] freq = CountLetters(text);
        for (int i = 0; i < 26; i++)
        {
            if (freq[i] > 0)
            {
                char letter = (char)('a' + i);
                Console.WriteLine($"Letter {letter} : {freq[i]} times ");
            }
        }
    }

    public static int[] CountLetters(string s )
    {
        int[] count = new int[26];
        foreach(char c in s)
        {
            count[c - 'a']++;
        }
        return count;
    }
}