class Program
{
    public static void Main()
    {
        int[] a = { 1, 2, 3, 0, 0, 0 };
        int m = 3;
        int[] b = { 2, 5, 6 };
        int n = 3;
        Merge(a, m, b, n);
        Console.WriteLine(string.Join(" ", a));
    }
    public static void Merge(int[] a , int m , int[] b  ,int n )
    {
        int i = m - 1;
        int j = n - 1;
        int k = m + n - 1;

        while (j>=0)
        {
            if (i>=0 && a[i] > b[j])
            {
                a[k--] = a[i--];
            }    
            else
            {
                a[k--] = b[j--];
            }
        }
    }
}