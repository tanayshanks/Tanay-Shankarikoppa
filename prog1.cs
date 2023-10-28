using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine ("enter the size of array");
        int i,j,n,f;
        n=Convert.ToInt32(Console.ReadLine()); 
        int[] nums= new int[10];
        Console.WriteLine ("enter the elements");
        int x=0;
        for(i=0;i<n;i++)
        {
            nums[i] = Convert.ToInt32(Console.ReadLine());  		

            
        }
        for(i=0;i<n;i++)
        {
            f=0;
            for(j=0;j<n;j++)
        {
            if(nums[j]==nums[i])
            {
                f++;
            }
            if(f>=2)
            {
                x++;
                break;
            }
        }    
        }
        if(x>=1)
        {
            Console.WriteLine("true");
        }
        else if(x==0)
        {
            Console.WriteLine("false");
        }
        else{
            Console.WriteLine("wrong input");
        }



        
    }
}