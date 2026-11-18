using System;

namespace BTTH2
{
    static class B1C4
    {
        public static void Run()
        {
            Console.WriteLine("= CHƯƠNG TRÌNH BÀI 1: CHÈN PHẦN TỬ VÀO MẢNG =");
            Console.Write("Nhập số lượng phần tử n: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"  Nhập a[{i}] = ");
                a[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Nhập vị trí cần chèn k: ");
            int k = int.Parse(Console.ReadLine());

            Console.Write("Nhập giá trị cần chèn x: ");
            int x = int.Parse(Console.ReadLine());

            int[] tmp = new int[a.Length + 1];
            for (int i = 0; i < k; i++)
            {
                tmp[i] = a[i];
            }
            tmp[k] = x;
            for (int i = k; i < a.Length; i++)
            {
                tmp[i + 1] = a[i];
            }

            Console.WriteLine("\nKết quả mảng sau khi chèn:");
            for (int i = 0; i < tmp.Length; i++)
            {
                Console.Write(tmp[i] + " ");
            }
            Console.WriteLine();
        }
    }
}