using System;
class numtostr
{
    public static void Main(string[] arg)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        String s = Convert.ToString(n);
        int c = 0;
        char[] ar = s.ToCharArray();
        for (int i=0;i<s.Length;i++)
        {
            c++;
        }
        if(c%2!=0)
        {
            
            String r="";
            for(int i=s.Length-1;i>=0;i--)
            {
                r = r + ar[i];
            }
            Console.WriteLine(r);
        }
        else
        {
            int k = c / 2;
            String fr = "";
            for(int i=k-1;i>=0;i--)
            {
                fr = fr + ar[i];
            }
            for(int i=s.Length-1;i>=k;i--)
            {
                fr = fr + ar[i];
            }
            Console.WriteLine(fr);

        }
        
    }
}
