
using System;

namespace BTTH2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;

            int luaChon;
            do
            {
                Console.Clear();
                Console.WriteLine("======================= MENU CHÍNH =======================");
                Console.WriteLine("  1. Chạy Bài 1: Chèn phần tử vào mảng 1 chiều");
                Console.WriteLine("  2. Chạy Bài 2: Quản lý danh sách nhân viên (Struct)");
                Console.WriteLine("  3. Chạy Bài 3: Xử lý ma trận vuông cấp n");
                Console.WriteLine("  4. Chạy Bài 4: Danh sách liên kết đơn (Phần 1)");
                Console.WriteLine("  5. Chạy Bài 5: Danh sách liên kết đơn (Phần 2)");
                Console.WriteLine("  0. Thoát chương trình");
                Console.WriteLine("==========================================================");
                Console.Write(" Nhập số tương ứng để chọn bài (0-5): ");

                if (!int.TryParse(Console.ReadLine(), out luaChon))
                {
                    luaChon = -1;
                }

                Console.WriteLine();

                switch (luaChon)
                {
                    case 1:
                        B1C4.Run();
                        break;
                    case 2:
                        B2C4.Run();
                        break;
                    case 3:
                        B3C4.Run();
                        break;
                    case 4:
                        B4C4.Run();
                        break;
                    case 5:
                        B5C4.Run();
                        break;
                    case 0:
                        Console.WriteLine("Đang thoát chương trình. Tạm biệt!");
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ! Vui lòng chọn từ 0 đến 5.");
                        break;
                }

                if (luaChon != 0)
                {
                    Console.WriteLine("\n----------------------------------------------------------");
                    Console.Write("Bấm phím bất kỳ để quay lại Menu chính...");
                    Console.ReadKey();
                }

            } while (luaChon != 0);
        }
    }
}