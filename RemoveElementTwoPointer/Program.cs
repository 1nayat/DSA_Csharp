using System.Reflection;
using System.Xml;

class Program
{
    public static void Main ()
    {
        int[] arr = new int[] { 3, 4, 5, 3 };
        int val = 3;
        int k = RemoveElement(arr, val);
        for (int i =0; i < k;i++ )
        {
            Console.WriteLine(arr[i]);
        }
    }

    public static int RemoveElement(int[] arr , int val)
    {
        int write = 0;
        for (int read =0; read < arr.Length;read++)
        {
            if (arr[read] != val )
            {
                arr[write] = arr[read];
                write++;
            }
        }
        return write;
    }
}

//this is same as that of previous question where we remove element but that will remove only one at a time and the problem is 

//What happens: Every time a matching val is found, DeleteAt shifts the rest of the array left ($O(n)$ work).The issue:
//If the array contains many matches (e.g., [3, 3, 3, 3, 3]), shifting on every deletion results in $O(n^2)$
//total time (nested shifting loops).//and this will remove multiple

//Why the Two - Pointer Pattern Wins
//RemoveElement does not repeatedly shift elements. It scans the array once from left to right:
//Surviving elements are placed directly into index write.
//Every element is visited and copied at most once.
//Total runtime is guaranteed to be linear: $O(n)$.