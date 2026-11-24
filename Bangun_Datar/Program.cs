namespace Bangun_Datar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persegi persegi = new Persegi();
            Persegi_Panjang Persegi_Panjang = new Persegi_Panjang();
            Layang_Layang layang_Layang = new Layang_Layang();
            Belah_Ketupat belah_ketupat = new Belah_Ketupat();
            Segitiga segitiga = new Segitiga();

            Console.WriteLine("=== List Bangun Datar ===");

            Console.WriteLine("1. Persegi");
            Console.WriteLine("2. Persegi Panjang");
            Console.WriteLine("3. Layang-Layang");
            Console.WriteLine("4. Belah Ketupat");
            Console.WriteLine("5. Segitiga");
            Console.WriteLine("6. Lingkaran");
            Console.WriteLine("7. Jajar Genjang");
            Console.WriteLine("8. Trapesium");

            Console.Write("Pilih Bangun Datar : ");
            double bangun_datar = Convert.ToDouble(Console.ReadLine());

            Console.Write("Hitung Keliling / Luas : ");
            string choose = Convert.ToString(Console.ReadLine());

            switch (bangun_datar)
            {
                case 1:
                    if (choose == "keliling")
                    {
                        Console.Write("Masukkan sisi : ");
                        double s = Convert.ToDouble(Console.ReadLine());
                        double keliling = persegi.keliling_persegi(s);
                        Console.WriteLine($"Keliling Persegi : {keliling}");
                    }
                    else if (choose == "luas")
                    {
                        Console.Write("Masukkan sisi : ");
                        double s = Convert.ToDouble(Console.ReadLine());
                        double luas = persegi.luas_persegi(s);
                        Console.WriteLine($"Luas Persegi : {luas}");
                    }
                    break;

                case 2: 
                    if(choose == "keliling")
                    {
                        Console.Write("Masukkan panjang : ");
                        double p = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Masukkan lebar : ");
                        double l = Convert.ToDouble(Console.ReadLine());
                        double keliling = Persegi_Panjang.keliling_persegi_panjang(p, l);
                        Console.WriteLine($"Keliling Persegi Panjang : {keliling}");
                    }
                    else if (choose == "luas")
                    {
                        Console.Write("Masukkan panjang : ");
                        double p = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Masukkan lebar : ");
                        double l = Convert.ToDouble(Console.ReadLine());
                        double luas = Persegi_Panjang.luas_persegi_panjang(p, l);
                        Console.WriteLine($"Luas Persegi Panjang : {luas}");
                    }
                    break;

                case 3:
                    if (choose == "keliling")
                    {
                        Console.Write("Masukkan sisi a : ");
                        double a = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Masukkan sisi b : ");
                        double b = Convert.ToDouble(Console.ReadLine());
                        double keliling = layang_Layang.keliling(a, b);
                        Console.WriteLine($"Keliling Layang-Layang : {keliling}");
                    }
                    else if (choose == "luas")
                    {
                        Console.Write("Masukkan diagonal 1 : ");
                        double d1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Masukkan diagonal 2 : ");
                        double d2 = Convert.ToDouble(Console.ReadLine());
                        double luas = layang_Layang.luas(d1, d2);
                        Console.WriteLine($"Luas Layang-Layang : {luas}");
                    }
                    break;

                case 4:
                    if (choose == "luas")
                    {
                        Console.Write("Masukkan diagonal 1 : ");
                        double d1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Masukkan diagonal 2 : ");
                        double d2 = Convert.ToDouble(Console.ReadLine());
                        double luas = belah_ketupat.luas(d1, d2);
                        Console.WriteLine($"Luas Belah Ketupat : {luas}");
                    }
                    else if (choose == "keliling")
                    {
                        Console.Write("Masukkan Sisi : ");
                        double s = Convert.ToDouble(Console.ReadLine());
                        double keliling = belah_ketupat.keliling(s);
                        Console.WriteLine($"Keliling Belah Ketupat : {keliling}");
                    }
                    break;

                case 5:
                    if (choose == "luas")
                    {
                        Console.Write("Masukkan alas : ");
                        double a = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Masukkan tinggi : ");
                        double t = Convert.ToDouble(Console.ReadLine());
                        double luas = segitiga.luas(a, t);
                        Console.WriteLine($"Luas Segitiga : {luas}");
                    }
                    else if (choose == "keliling")
                    {
                        Console.Write("Masukkan sisi a : ");
                        double a = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Masukkan sisi b : ");
                        double b = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Masukkan sisi c : ");
                        double c = Convert.ToDouble(Console.ReadLine());
                        double keliling = segitiga.keliling(a, b, c);
                        Console.WriteLine($"Keliling Segitiga : {keliling}");
                    }
                    break;
                default:
                    Console.WriteLine("Silahkan pilih bangun datar yang ada dilist");
                    break;
            }
        }
    }
}
