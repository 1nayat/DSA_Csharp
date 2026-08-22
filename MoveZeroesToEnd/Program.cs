class Program
{

    public static void Main()
    {

        int[] arr = new int[] { 1, 2, 0, 5, 0, 4 };
        MoveZeroes(arr);
        Console.WriteLine(string.Join(" ", arr));

    }
    public static void MoveZeroes (int[]arr)
    {
        int write = 0;
        for( int read =0; read<arr.Length;read++)
        {
            if (arr[read] !=0)
            {
                arr[write++]=arr[read];
            }
        }
        while(write < arr.Length)
        {
            arr[write] = 0;
            write++;
        }
    }

}