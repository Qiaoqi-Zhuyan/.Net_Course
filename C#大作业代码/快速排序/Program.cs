using System;

public class Method2
{
  

    public int quicksort(int[] array, int left, int right)
    {
        int tamp = array[left];

        while (left < right)
        {
            while (left < right && array[right] >= tamp)
            {
                right--;
            }//if righ side is greater than left side , move to the left

            array[left] = array[right];

            while (left < right && array[left] <= tamp)
            {
                left++;
            }//same as above

            array[right] = array[left];
        }
        array[left] = tamp;
        return right;
    }
     public void QuickSort(int[] array, int left , int right)
    { 
        if(left >=right)
        {
            return ;
        }
       int  param = quicksort(array,left,right);
        QuickSort(array, left, param - 1);
        QuickSort(array, param + 1, right);


    }


    public void Display()
    {
        Console.WriteLine("Enter your student Number: ");
        string StudentNumber = Console.ReadLine();
        int seed = Convert.ToInt32(StudentNumber.Substring(StudentNumber.Length - 4, 4));
        var rd = new Random(seed);//Seed 



        int len = Convert.ToInt32(StudentNumber.Substring(StudentNumber.Length - 2, 2));
        if (len % 20 <= 5)
        {
            len += 10;
        }
        int[] Array = new int[len];
        int i;
        for (i = 0; i < Array.Length; i++)
        {
            Array[i] = rd.Next(0, 101);
        }//generate the array


        Console.WriteLine("Array: ");
        for (i = 0; i < Array.Length; i++)
        {
            Console.Write("{0}\t", Array[i]);
        }
        Console.WriteLine();


        QuickSort(Array, 0, Array.Length - 1);

        Console.WriteLine("New Array:");
           for( i=0; i<Array.Length;i++)
        {
            Console.Write("{0}\t",Array[i]);
        }
                    

    }



    static void Main(string[] args)

        {
        Method2 m2 = new Method2();
        m2.Display();

       
        

    }
    }


//