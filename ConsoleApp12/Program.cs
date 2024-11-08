using System;

class Program
{
    static void Main(string[] args)
    {
        int m = 3;   
        int n = 4;  

      
        Console.WriteLine($"A({m}, {n}) = {Ackermann(m, n)}");     
        Console.WriteLine("Devam etmek için bir tuşa basın...");
        Console.ReadLine();  
    }

    
    static int Ackermann(int m, int n)
    {
        
        if (m == 0)
            return n + 1;          
        else if (m == 1)
            return n + 2;       
        else if (m > 1 && n == 0)
            return Ackermann(m - 1, 1);         
        else if (m > 1 && n > 0)
            return Ackermann(m - 1, Ackermann(m, n - 1));  
       throw new ArgumentOutOfRangeException("m and n must be non-negative integers.");
    }
}