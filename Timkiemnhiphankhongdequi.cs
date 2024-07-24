using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTTL
{
    class Program
    {
        static void Main()
        {
            int[] array = { 5, 7, 23, 32, 34, 62 };
            int target = 23;
            int result = TimKiemNhiPhan(array, target);

            if (result != -1)
            {
                Console.WriteLine("Phần tử được tìm thấy tại chỉ số: " + result);
            }
            else
            {
                Console.WriteLine("Phần tử không được tìm thấy.");
            }
            Console.ReadKey();

        }

        static int TimKiemNhiPhan(int[] array, int target)
        {
            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (array[mid] == target)
                {
                    return mid;
                }
                else if (array[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return -1;
        }
    }
}
