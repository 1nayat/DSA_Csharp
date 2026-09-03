class Program {

    public static void Main()
    {
        int[][] matrix =
            {
         new int[] { 1, 2, 3 },
         new int[] { 4, 5, 6 },
         new int[] { 7, 8, 9 }
        
        };
        IList<int> result = SpiralOrder(matrix);
        foreach(int num in result)
        {
            Console.Write(num);
        }
    }
    public static IList<int> SpiralOrder(int[][] matrix)
    {
        var result = new List<int>();
        if (matrix.Length == 0)
            return result;
        int top = 0;
        int bottom = matrix.Length - 1;
        int left = 0;
        int right = matrix[0].Length - 1;

        while (top <= bottom && left <= right)
        {
            for (int j = left; j <= right; j++)
            {
                result.Add(matrix[top][j]);
            }
            top++;

            for (int i = top; i <= bottom; i++)
            {
                result.Add(matrix[i][right]);
            }
            right--;
            if (top <= bottom)
            {
                for (int j = right; j >= left; j--)
                {
                    result.Add(matrix[bottom][j]);

                }
                bottom--;
            }
            if (left <= right)
            {
                for (int i = bottom; i >= top; i--)
                {
                    result.Add(matrix[i][left]);
                }
                left++;
            }
        }
        return result;

    }
}
