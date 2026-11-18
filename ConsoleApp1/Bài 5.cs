using System;

namespace BTTH2
{
    static class B5C4
    {
        public class Node
        {
            public int Data;
            public Node Next;
            public Node(int data)
            {
                Data = data;
                Next = null;
            }
        }

        public static void Run()
        {
            Console.WriteLine("=== CHƯƠNG TRÌNH BÀI 5: DANH SÁCH LIÊN KẾT ĐƠN (2) ===");
            Node pHead = TaoDanhSachLKD();

            if (pHead != null)
            {
                int max = pHead.Data;
                Node p = pHead.Next;
                while (p != null)
                {
                    if (p.Data > max) max = p.Data;
                    p = p.Next;
                }
                Console.WriteLine($"\nPhần tử lớn nhất trong danh sách: {max}");
            }

            int tong = 0;
            Node temp = pHead;
            while (temp != null)
            {
                tong += temp.Data;
                temp = temp.Next;
            }
            Console.WriteLine($"Tổng các phần tử: {tong}");

            int demNT = 0;
            temp = pHead;
            while (temp != null)
            {
                if (LaSoNguyenTo(temp.Data)) demNT++;
                temp = temp.Next;
            }
            Console.WriteLine($"Số lượng số nguyên tố: {demNT}");

            int dAm = 0, dDuong = 0, dKhong = 0;
            temp = pHead;
            while (temp != null)
            {
                if (temp.Data < 0) dAm++;
                else if (temp.Data > 0) dDuong++;
                else dKhong++;
                temp = temp.Next;
            }
            Console.WriteLine($"Thống kê: Số âm = {dAm}, Số dương = {dDuong}, Số bằng 0 = {dKhong}");
        }

        static Node TaoDanhSachLKD()
        {
            Console.Write("Nhập số lượng phần tử của danh sách: ");
            int n = int.Parse(Console.ReadLine());
            if (n <= 0) return null;

            Console.Write("  Nhập phần tử thứ 1: ");
            Node head = new Node(int.Parse(Console.ReadLine()));
            Node tail = head;

            for (int i = 1; i < n; i++)
            {
                Console.Write($"  Nhập phần tử thứ {i + 1}: ");
                tail.Next = new Node(int.Parse(Console.ReadLine()));
                tail = tail.Next;
            }
            return head;
        }

        static bool LaSoNguyenTo(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
    }
}