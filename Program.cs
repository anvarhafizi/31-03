using System;

namespace HW6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("31-03");
            Console.WriteLine("Exercise 2");
            Console.WriteLine("Please enter quantity numbers for array");
            int n=Convert.ToInt32(Console.ReadLine());
             int[] a=new int[n];
             for(int i=0;i<a.Length;i++)
             {
                 Console.Write($"a[{i}]=");
                 a[i]=Convert.ToInt32(Console.ReadLine());
             }
             int max=a[0];
             int min=a[0];
             int sum=0;
             int count=0;
             int me=0;
             for(int i=0;i<a.Length;i++)
             {
                 if(max<a[i])
                 {
                     max=a[i];        
                 }
                 if(min>a[i])
                 {
                     min=a[i];
                 }
                 count++;
             sum=sum+a[i];
                 me=sum/count;
                
             }
             Console.WriteLine();
             Console.WriteLine("The biggest number="+max);
             Console.WriteLine("The smallest number="+min);
             Console.WriteLine("amount of elements="+sum);
             Console.WriteLine("arithmetics mean="+me);
             Console.WriteLine();
             Console.WriteLine("Odd elements:");
             for(int i=0;i<a.Length;i++)
             {
                 if(a[i]%2!=0)
                 {
                     Console.WriteLine($"a[{i}]="+a[i]);
                 }
             }
             Console.WriteLine("To go to another task, CLICK ANY BUTTON");
             Console.ReadKey();

             Console.WriteLine("----------------------");
             Console.WriteLine("Exercise 3");
             Console.WriteLine("Please enter quantity numbers for array:");
             int m=Convert.ToInt32(Console.ReadLine());
             int[]a2=new int[m];
             for(int j=0;j<a2.Length;j++)
            {
                 Console.Write($"a2[{j}]=");
                 a2[j]=Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine("Entered array:");
            for(int j=0;j<a2.Length;j++)
            {
                 Console.WriteLine($"a2[{j}]="+a2[j]);
            }
            Console.WriteLine();
            Console.WriteLine("Inverse array:");
             for(int j=a2.Length-1;j>=0;j--)
             {
                 Console.WriteLine($"a2= "+a2[j]);
            }
            Console.WriteLine("To go to another task, CLICK ANY BUTTON");
                Console.ReadKey();
            Console.WriteLine("------------------------");
             Console.WriteLine("Exercise 4");
             Console.WriteLine("Please enter quantity random numbers for array");
            int a3Size=Convert.ToInt32(Console.ReadLine());
            Random random=new Random();
            int[]a3=new int[a3Size];
            for(int t=0;t<a3.Length;t++)
            {
                a3[t]=random.Next(1000);
            }
            Console.WriteLine();
            for(int t=0;t<a3.Length;t++)
            {
                Console.WriteLine($"a3=[{t}]="+a3[t]);
            }
            Console.WriteLine();

            Console.Write("count=");
            int Count=Convert.ToInt32(Console.ReadLine());
            Console.Write("index=");
            int z=Convert.ToInt32(Console.ReadLine());
            int []a4=new int[Count];
            for(int l=0;l<Count;l++)
            {
                if(l+z<a3.Length)
                {
                    a4[l]=a3[l+z];
                }
                else
                {
                    a4[l]=1;
                }
            }
            
            System.Console.WriteLine("Values:");
            for(int l=0;l<a4.Length;l++)
            {
                Console.WriteLine($"array[{l}]="+a4[l]);
            }
            Console.ReadKey();
        }
    }
}
