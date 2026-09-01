using System.Timers;

class Program
{

    public static void Main()
    {
        int[][] matrix =
             {
            new int[] { 1, 2, 3 },
            new int[] { 4, 5, 6 },
            new int[] { 7, 8, 9 }
        };
        RotateImage(matrix);
        PrintMatrix(matrix);
    }
    public static void  RotateImage(int[][] matrix)
    {
        int n = matrix.Length;
        for (int i =0;i<n;i++)
        {
            for (int j =i+1;j<n;j++)
            {
                (matrix[i][j], matrix[j][i]) = (matrix[j][i], matrix[i][j]);
            }
        }
        for (int i =0;i<n;i++)
        {
            Array.Reverse(matrix[i]);
        }
    }
    public static void PrintMatrix(int[][] matrix)
    {
        foreach (int[]row in matrix)
        {
            Console.WriteLine(string.Join(" ", row));
        }
    }
}

//Time Complexity: O(n²)
//Space Complexity: O(1)