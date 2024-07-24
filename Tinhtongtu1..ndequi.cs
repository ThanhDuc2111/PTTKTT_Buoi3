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
            int n = 10; // Ví dụ tính tổng từ 1 đến 10
            int totalSum = DivideAndConquerSum(1, n);
            Console.WriteLine("Tổng của mảng từ 1 đến {0} là: {1}", n, totalSum);
        }

        public static int DivideAndConquerSum(int start, int end)
        {
            // Base case
            if (start > end)
            {
                return 0;
            }

            // Base case: khi chỉ có một phần tử
            if (start == end)
            {
                return start;
            }

            // Chia bài toán thành hai phần
            int mid = (start + end) / 2;

            // Đệ qui tính tổng của mỗi nửa và kết hợp kết quả
            int leftSum = DivideAndConquerSum(start, mid);
            int rightSum = DivideAndConquerSum(mid + 1, end);

            return leftSum + rightSum;
        }
    }
    
}
