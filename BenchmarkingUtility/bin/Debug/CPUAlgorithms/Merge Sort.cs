using System;
using System.Threading;
using System.Runtime.CompilerServices;

public static class FannkuchRedux
{
    public static void Main(string[] args)
    {
        mergesort();
    }

    public static int[] merge()
    {

    }

    public static int[] mergesort(int[] list)
    {
        if (list.Length <= 1)
        {
            return list;
        }
        int mid = (int)list.Length / 2;
        int left = mergesort(list[mid]);
        int right = mergesort(list[mid]);

    }
}