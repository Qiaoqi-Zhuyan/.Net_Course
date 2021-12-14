using System;
public class Method
{
    public int[] GetArray(ref string StudentNumber)
    {
       int seed = Convert.ToInt32(StudentNumber.Substring(StudentNumber.Length-4,4));
        var rd = new Random(seed);//Seed 



       int len = Convert.ToInt32(StudentNumber.Substring(StudentNumber.Length - 2, 2));
       if (len%20<=5)
        {
            len += 10;
        }
        int[] Array = new int[len];
        int i;
        for(i=0 ;i<Array.Length ;i++ )
        {
            Array[i] = rd.Next(0, 101);
        }//generate the array
        Console.WriteLine("Array: ");
        for(i=0;i<Array.Length ;i++)
        {
            Console.Write("{0}\t", Array[i]);
        }
        Console.WriteLine();

        return (Array);
    }
      
        
     public void descending(int[] Array)//descending
    {
        int i, j;
        for(i=0;i<Array.Length-1 ; i++)
        {
            for(j=0;j<Array.Length-1-i ; j++)
            {
                if (Array[j] < Array[j +1])
                {
                    int tamp;
                    tamp = Array[j + 1];
                    Array[j + 1] = Array[j];
                    Array[j] = tamp;
                }
            }
        }

        Console.WriteLine("New Array");
        for(i=0;i<Array.Length ;i++)
        {
            Console.Write("{0}\t", Array[i]);
        }
        Console.WriteLine();

        
    }


    public  void ascending(int[] Array)//ascending
    {
        int i, j;
        for (i = 0; i < Array.Length - 1; i++)
        {
            for (j = 0; j < Array.Length - 1 - i; j++)
            {
                if (Array[j] > Array[j + 1])
                {
                    int tamp;
                    tamp = Array[j+1 ];
                    Array[j + 1] = Array[j];
                    Array[j] = tamp;
                }
            }
        }

        Console.WriteLine("New Array");
        for (i = 0; i < Array.Length; i++)
        {
            Console.Write("{0}\t", Array[i]);
        }
        Console.WriteLine();
    }

    public void DisPlay()
    {
        Console.Write("input your StudentNumber: ");
        string StudentNumber = Console.ReadLine();

        




        int i = Convert.ToInt32(StudentNumber.Substring(0, 1));
        if (i % 2 == 1)
        {
            descending(GetArray(ref StudentNumber));
        }
        else
        {
           ascending(GetArray(ref StudentNumber));
        }
    }

}
public class Program
{
    public static void Main()
    {
        Method m1 = new Method();
        m1.DisPlay();
    }
}
