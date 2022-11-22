using System;
class train
{
    public static void Main(string[] arg)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[n];
        int[] dep = new int[n];
        for(int i=0;i<n;i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        for(int i=0;i<n;i++)
        {
            dep[i] = Convert.ToInt32(Console.ReadLine());
        }
        int c = 1,k=0;
        if (arr[0] != dep[0])
        {
            for (int i = 1; i < n; i++)
            {
                if ((arr[i] != dep[i]))
                {
                    if (dep[i - 1] < arr[i])
                    {
                        c = c + 1;
                    }
                    if(arr[i] == dep[i - 1])
                    {
                        k = k + 1;
                    }
                }
            }
        }
        Console.WriteLine(k+c);
    }
}
