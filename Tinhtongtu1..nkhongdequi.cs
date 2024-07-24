using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTTL
{
    class Program
    {
        public static void Main()
    {
        int n = 10;
        int totalSum = SumArrayDivideConquer(n);
        Console.WriteLine("Tổng của mảng từ 1 đến {0} là: {1}",n,totalSum);
        Console.ReadKey();
    }
    
    public static int SumArrayDivideConquer(int n)
    {
        // Base case
        if (n == 1)
        {
            return 1;
        }
        
        // Divide the problem into two halves
        int mid = n / 2;
        
        // Sum of first half: 1 + 2 + ... + mid
        int sumFirstHalf = SumSequence(1, mid);
        
        // Sum of second half: (mid + 1) + (mid + 2) + ... + n
        int sumSecondHalf = SumSequence(mid + 1, n);
        
        // Combine the results
        return sumFirstHalf + sumSecondHalf;
    }
    
    // Helper function to compute sum of sequence from start to end
    public static int SumSequence(int start, int end)
    {
        int sum = 0;
        for (int i = start; i <= end; i++)
        {
            sum += i;
        }
        return sum;
    }
       
    }
    
}
