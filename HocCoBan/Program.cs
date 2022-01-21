// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
namespace HocCoBan
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            /*List<SinhVien> ds = new List<SinhVien>();
            StreamReader file = new StreamReader("D:\\Source C sharp\\HocCoBan\\HocCoBan\\sinhvien.txt");

            while (true)
            {
                String line = file.ReadLine();
                if (line == null)
                    break;
                String[] parts = line.Split(',');
                SinhVien sv = new SinhVien();

                sv.Masv = int.Parse(parts[0].Trim());
                sv.Ten = parts[1].Trim();
                sv.Diem = double.Parse(parts[2].Trim());
                ds.Add(sv);
                
            }
            foreach (SinhVien s in ds)
            {
                Console.WriteLine("Mã sv: {0}\t Tên: {1}\t Điểm: {2}", s.Masv, s.Ten, s.Diem);
            }
            */

            SinhVienCNTT a = new SinhVienCNTT();
            a.Diem = 123;
            Console.WriteLine(a.Diem);
            //new
            Console.WriteLine(a.Ten);
        }
    }
}
