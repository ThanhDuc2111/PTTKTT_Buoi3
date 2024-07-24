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
            int result = TimKiemNhiPhan(array, target, 0, array.Length - 1);

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

        static int TimKiemNhiPhan(int[] array, int target, int left, int right)
        {
            if (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (array[mid] == target)
                {
                    return mid;
                }
                else if (array[mid] < target)
                {
                    return TimKiemNhiPhan(array, target, mid + 1, right);
                }
                else
                {
                    return TimKiemNhiPhan(array, target, left, mid - 1);
                }
            }

            return -1;
        }
    }
}
