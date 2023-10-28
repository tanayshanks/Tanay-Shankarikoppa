using System;

public class HelloWorld2
{
    public static void Main(string[] args)
    {
        Console.WriteLine ("enter the size of array");
        int i,n,temp;
        n=Convert.ToInt32(Console.ReadLine()); 
        int[] nums = new int[10];
        Console.WriteLine ("enter the elements");
        for(i=0;i<n;i++)
        {
            nums[i] = Convert.ToInt32(Console.ReadLine());  		
        }
        for(i=0;i<(n/2);i++)
        {
            temp=nums[i];
            nums[i] = nums[n-i-1];
            nums[n-i-1]=temp;
            
        }
        for(i=0;i<n;i++)
        {
            Console.WriteLine (nums[i].ToString());		
        }
    }}