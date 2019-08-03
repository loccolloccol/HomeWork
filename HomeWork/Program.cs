using System;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = 1, max = 50, num = 10,t;
            int[] ran = new int[num];
            GetRan(ran,min,max,num);
            for (int p = 0; p <= ran.Length - 2; p++)
            {
                for (int i = 0; i <= ran.Length - 2; i++)
                {
                    if (ran[i] > ran[i + 1])
                    {
                        t = ran[i + 1];
                        ran[i + 1] = ran[i];
                        ran[i] = t;
                    }
                }
            }
            Console.WriteLine("\n" + "Sorted array :");
            foreach (int aa in ran)
                Console.Write(aa + " ");



        }

        //---------------------------------------------------------------------
        public static void GetRan(int[] list,int min,int max,int num)
        {
            int temp;
            int n = 0;
            bool more;
            Random ra = new Random();
            do
            {
                more = false;
                temp = ra.Next(min,max+1);
                for (int k=0;k<=n;k++)
                {
                    if (list[k]==temp)
                    {
                        more = true;
                        break;
                    }
                    
                }
                if (more==false)
                {
                    list[n] = temp;
                    n++;
                }
            } while (n < num);
        }
    }
}
