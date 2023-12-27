namespace bai_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string hoten;
            float DiemToan;
            float Diemvan;
            Console.WriteLine(" moi nhap ho ten");
            hoten = Console.ReadLine();
            Console.WriteLine("moi nhap diem toan");
            DiemToan = float.Parse(Console.ReadLine());
            Console.WriteLine("moi nhap diem van");
            Diemvan = float.Parse(Console.ReadLine());
            Console.WriteLine("hoc sinh co diem la:{0},{1},{2}",hoten,DiemToan,Diemvan);
            Console.ReadKey();



        }
    }
}
