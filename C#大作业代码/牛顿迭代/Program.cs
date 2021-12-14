using System;

namespace Q_2
{
  public  class Func
    {

        public double func(ref int a ,ref int b,ref int c,ref double Varible)
        {
            double Value = Varible -( a * Varible * Varible + b * Varible + c)/(2*a*Varible+b);

            return Value;            
        }

        
        static void Main(string[] args)
        {
            Console.Write("Input your Student Number: ");
            string StudentNumber = Console.ReadLine();
            int Seed = Convert.ToInt32(StudentNumber.Substring(StudentNumber.Length - 4, 4));
            var rd = new Random(Seed);
            int[] Array = new int[3];
            int i;//generate the array

           



            Func f = new Func();
            double guess=1.0, next=1.0;
                int a, b, c;
            do
            {
                for (i = 0; i < Array.Length; i++)
                {
                    Array[i] = rd.Next(0, 100);
                }
              
                a = Array[0];
                b = Array[1];
                c = Array[2];
              
                if(f.func(ref a ,ref b, ref c,ref guess)==0)
                {
                   
                    Console.WriteLine("result ={0}",guess);
                    break;
                }
                for (i = 0; i < 50; i++)
                {
                    guess = next;
                    next = f.func(ref a, ref b, ref c, ref guess);
                     
                }
                
                Console.WriteLine();
            } while (Math.Abs(guess - next) > 0.0001);

            Console.WriteLine("a = {0}\tb={1}\tc={2};", a, b, c);
            Console.WriteLine("final result: {0}",next);
        }
    }
}
