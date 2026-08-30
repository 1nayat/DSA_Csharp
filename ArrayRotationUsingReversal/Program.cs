class Program
{

    public static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5, 6 };
        int k = 3;
        Rotate(arr, k);
        Console.WriteLine(string.Join("",arr ));
    }
    public static void Rotate (int[] arr , int k )
    {
        int n = arr.Length;
        k = k%n;
        Reverse(arr, 0, n - 1);
        Reverse(arr, 0, k - 1);
        Reverse(arr, k, n - 1);
    }
    public static void Reverse(int[] arr, int left,int right)
    {
        while (left<right)
        {
            (arr[left], arr[right]) = (arr[right], arr[left]);
            
            left++;
            right--;
        }
    }
}