using System;
using System.Linq;

namespace BTTH2
{
    static class B2C4
    {
        struct NhanVien
        {
            public string MaNV;
            public string Hoten;
            public int Namsinh;
            public string Phongban;
            public int LuongCB;
            public int Thuong;
            public int ThucLinh => LuongCB + Thuong;
        }

        public static void Run()
        {
            Console.WriteLine("=== CHƯƠNG TRÌNH BÀI 2: QUẢN LÝ NHÂN VIÊN ===");
            Console.Write("Nhập số lượng nhân viên n: ");
            int n = int.Parse(Console.ReadLine());
            NhanVien[] DS = new NhanVien[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nNhập thông tin nhân viên thứ {i + 1}:");
                Console.Write("  Mã NV: "); DS[i].MaNV = Console.ReadLine();
                Console.Write("  Họ tên: "); DS[i].Hoten = Console.ReadLine();
                Console.Write("  Năm sinh: "); DS[i].Namsinh = int.Parse(Console.ReadLine());
                Console.Write("  Phòng ban: "); DS[i].Phongban = Console.ReadLine();
                Console.Write("  Lương CB: "); DS[i].LuongCB = int.Parse(Console.ReadLine());
                Console.Write("  Thưởng: "); DS[i].Thuong = int.Parse(Console.ReadLine());
            }

            int tongThucLinh = DS.Sum(nv => nv.ThucLinh);
            Console.WriteLine($"\n[a] Tổng thực lĩnh: {tongThucLinh:N0} VNĐ");

            if (DS.Length > 0)
            {
                int minLuong = DS.Min(nv => nv.LuongCB);
                Console.WriteLine($"\n[b] Nhân viên có lương cơ bản thấp nhất ({minLuong:N0}):");
                foreach (var nv in DS.Where(nv => nv.LuongCB == minLuong)) InNV(nv);
            }

            int demThuong = DS.Count(nv => nv.Thuong >= 1200000);
            Console.WriteLine($"\n[c] Số lượng nhân viên thưởng >= 1.200.000: {demThuong}");

            Console.WriteLine("\n[d] Danh sách tăng dần theo phòng ban (trùng phòng giảm theo mã NV):");
            var sorted = DS.OrderBy(nv => nv.Phongban).ThenByDescending(nv => nv.MaNV);
            foreach (var nv in sorted) InNV(nv);

            Console.WriteLine("\n[e] Danh sách sau khi tăng lương cơ bản lên 5%:");
            for (int i = 0; i < DS.Length; i++)
            {
                DS[i].LuongCB = (int)(DS[i].LuongCB * 1.05);
                InNV(DS[i]);
            }
        }

        static void InNV(NhanVien nv)
        {
            Console.WriteLine($"  - [{nv.MaNV}] {nv.Hoten} | Phòng: {nv.Phongban} | Lương CB: {nv.LuongCB:N0} | Thưởng: {nv.Thuong:N0} | Thực lĩnh: {nv.ThucLinh:N0}");
        }
    }
}