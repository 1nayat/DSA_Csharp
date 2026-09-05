using System.Timers;

class Program { 
    public static void Main()
    {
        int[][] matrix =
 {
            new int[] { 1, 2, 3, 4 },
            new int[] { 5, 6, 0, 8 },
            new int[] { 9, 10, 11, 12 }
        };
        SetZeroes(matrix);
        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = 0; j < matrix[0].Length; j++)
            {
                Console.Write(matrix[i][j] + " ");
            }

            Console.WriteLine();
        }
        
    }
public static void SetZeroes(int[][] matrix)
    {
        bool firstrow = false;
        bool firstcol = false;

        for(int i =0;i<matrix.Length;i++)
        {
            for (int j = 0; j < matrix[0].Length;j++)
            {
                if (matrix[i][j] ==0)
                {
                    if (i == 0)
                        firstrow = true;
                    if (j == 0)
                        firstcol = true;
                    matrix[0][j] = 0;
                    matrix[i][0] = 0;

                }
            }
        }

        for (int i =1;i<matrix.Length;i++)
        {
            for (int j = 1; j < matrix[0].Length;j++)
            {
                if (matrix[i][0] ==0 || matrix[0][j] == 0)
                {
                    matrix[i][j] = 0;
                }

            }
        }

        if (firstrow)
        {
            for (int j = 0; j < matrix[0].Length;j++)
            {
                matrix[0][j] = 0;
            }
        }
        if(firstcol)
        {
            for(int i =0;i<matrix.Length;i++)
            {
                matrix[i][0] = 0;
            }
        }
    }

}
//Time Complexity: O(m × n)
  //  Space complexity is O(1)