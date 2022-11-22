using System;
class dir
{
    public static void Main(string[] arg)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        String [] a = new String[n];
        for(int i=0;i<n;i++)
        {
            a[i] = Console.ReadLine();
        }
        Stack<String> s = new Stack<String>();

        for (int i = 0; i < n; i++)
        {

            if (a[i] == "../" && s.Count != 0)
            {

                s.Pop();
            }


            else if (a[i] != "./")
            {


                s.Push(a[i]);
            }
        }
        int k = s.Count();
        Console.WriteLine(k);

    }
}
