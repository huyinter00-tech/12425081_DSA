using System;

namespace BTTH2
{
    static class B3C4
    {
        public static void Run()
        {
            Console.WriteLine("=== CHƯƠNG TRÌNH BÀI 3: MA TRẬN VUÔNG ===");
            Console.Write("Nhập cấp ma trận n (0 < n < 100): ");
            int n = int.Parse(Console.ReadLine());
            int[,] a = new int[n, n];

            Console.WriteLine("Nhập các phần tử ma trận:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"  a[{i},{j}] = ");
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }

            int tongTatCa = 0;
            foreach (int val in a) tongTatCa += val;
            Console.WriteLine($"\n[a] Tổng tất cả các phần tử: {tongTatCa}");

            int minDuong = int.MaxValue;
            foreach (int val in a)
            {
                if (val > 0 && val < minDuong) minDuong = val;
            }
            Console.WriteLine($"[b] Giá trị dương nhỏ nhất: {(minDuong == int.MaxValue ? "Không có" : minDuong.ToString())}");

            int tongCP = 0;
            for (int i = 0; i < n; i++)
            {
                tongCP += a[i, n - 1 - i];
            }
            Console.WriteLine($"[c] Tổng đường chéo phụ: {tongCP}");

            bool tangDan = true;
            for (int i = 0; i < n - 1; i++)
            {
                if (a[i, i] >= a[i + 1, i + 1])
                {
                    tangDan = false;
                    break;
                }
            }
            Console.WriteLine($"[d] Đường chéo chính có tăng dần không? {(tangDan ? "Có" : "Không")}");
        }
    }
}