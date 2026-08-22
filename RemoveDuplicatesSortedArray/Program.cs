class Program { 

public static void Main()
    {
        int[] arr = new int[] { 1, 2, 3, 4, 5, 5, 5 };
        int k = RemoveDuplicates(arr);
        for (int i =0;i<k;i++)
        {
            Console.WriteLine(arr[i]);
        }
    }


public static int RemoveDuplicates(int[] arr)
    {
        if (arr.Length == 0)
            return 0;
        int write = 1;
      for ( int read = 1; read < arr.Length; read++)
        {
            if (arr[read] != arr[write-1])
            {
                arr[write] = arr[read];
                write++;
            }


        }
        return write;
    }

}

