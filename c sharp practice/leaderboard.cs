using System;
namespace lead
{
    class board
    {
        public static void Main(string[] arg)
        {
            int t=Console.ReadLine();
            int[] a=new int[t];
            for(int i=0;i<t;i++)
            {
                a[i]=Console.ReadLine();
            }
            int max=a[t-1];
            for(int i=t-2;i>0;i++)
            {
                if(a[i]>max)
                {
                    Console.WriteLine(a[i]);
                    max=a[i];
                }

            }
        }
    }
}