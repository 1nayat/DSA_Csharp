using System;
using System.Security.Cryptography.X509Certificates;

class Program {
public static void Main()
    {

        int[] arr = new int[6] { 1, 2, 3, 0, 0, 0 };
        int length = 3;

        length = InsertAt(1, length, 99, arr);
        PrintArray(arr, length);

        length = DeleteAt(1, length, 99, arr);
        PrintArray(arr, length);
        
    }
    public static int InsertAt( int pos , int length, int value , int[]a)
    {
        if (length >= a.Length || pos < 0 || pos > length)
            return length;

        for (int i = length; i>pos;i--)
        {
            a[i] = a[i - 1];
        }
        a[pos] = value;

        return length + 1;

    }
    public static int   DeleteAt(int pos, int length, int value, int[] a)
    {
        if (pos < 0 || pos >= length)
            return length;

        for (int i = pos; i<length-1;i++)
        {
            a[i] = a[i + 1];
        }
        a[length - 1] = 0;
        return length - 1;
    }
    public static void PrintArray(int[]a ,int length)
    {
        for (int i=0;i<length;i++)
        {
            Console.WriteLine(a[i] + "");
        }
        Console.WriteLine();
    }

}

