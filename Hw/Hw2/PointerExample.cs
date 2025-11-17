using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw.Hw2
{
    public class PointerExample
    {
        public unsafe static void Main()
        {
            int x = 10;
            int* px = &x;  // Lấy địa chỉ

            Console.WriteLine("Value of x via pointer: " + *px);

            *px = 20;  // Thay đổi giá trị thông qua pointer
            Console.WriteLine("New value of x: " + x);

            // Không cần free, vì C# quản lý stack
        }
    }
}
