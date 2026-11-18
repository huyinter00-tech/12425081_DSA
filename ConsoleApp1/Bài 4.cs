using System;

namespace BTTH2
{
    static class B4C4
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
            Console.WriteLine("=== CHƯƠNG TRÌNH BÀI 4: DANH SÁCH LIÊN KẾT ĐƠN (1) ===");
            Node pHead = TaoDanhSachLKD();

            Console.Write("\n[a] Nhập giá trị x cần đếm: ");
            int x = int.Parse(Console.ReadLine());
            int dem = 0;
            Node p = pHead;
            while (p != null)
            {
                if (p.Data == x) dem++;
                p = p.Next;
            }
            Console.WriteLine($"    Số lượng phần tử bằng {x}: {dem}");

            int minDuong = int.MaxValue;
            p = pHead;
            while (p != null)
            {
                if (p.Data > 0 && p.Data < minDuong) minDuong = p.Data;
                p = p.Next;
            }
            Console.WriteLine($"[b] Phần tử dương nhỏ nhất: {(minDuong == int.MaxValue ? "Không có" : minDuong.ToString())}");

            Console.Write("\n[c] Nhập phần tử x cần xóa đầu tiên: ");
            int xXoa = int.Parse(Console.ReadLine());
            pHead = XoaPhanTuDauTien(pHead, xXoa);

            Console.WriteLine("    Danh sách sau khi xóa:");
            InDanhSachLKD(pHead);
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

        static void InDanhSachLKD(Node head)
        {
            Node p = head;
            Console.Write("  ");
            while (p != null)
            {
                Console.Write(p.Data + " -> ");
                p = p.Next;
            }
            Console.WriteLine("null");
        }

        static Node XoaPhanTuDauTien(Node head, int x)
        {
            if (head == null) return null;
            if (head.Data == x) return head.Next;

            Node p = head;
            while (p.Next != null && p.Next.Data != x)
            {
                p = p.Next;
            }

            if (p.Next != null)
            {
                p.Next = p.Next.Next;
                Console.WriteLine("    -> Đã xóa thành công!");
            }
            else
            {
                Console.WriteLine("    -> Không tìm thấy giá trị cần xóa.");
            }
            return head;
        }
    }
}