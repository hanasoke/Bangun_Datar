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
            Lingkaran lingkaran = new Lingkaran();
            Jajargenjang jajargenjang = new Jajargenjang();
            Trapesium trapesium = new Trapesium();

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
                        Console.Write("Masukkan ukuran sisi : ");
                        double s = Convert.ToDouble(Console.ReadLine());
                        double keliling = persegi.keliling_persegi(s);
                        Console.WriteLine($"Keliling Persegi : {keliling} cm");
                    }
                    else if (choose == "luas")
                    {
                        Console.Write("Masukkan ukuran sisi : ");
                        double s = Convert.ToDouble(Console.ReadLine());
                        double luas = persegi.luas_persegi(s);
                        Console.WriteLine($"Luas Persegi : {luas} cm");
                    }
                    break;
                    
                case 2: 
                    if(choose == "keliling")
                    {
                        Console.Write("Masukkan ukuran panjang : ");
                        double p = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Masukkan ukuran lebar : ");
                        double l = Convert.ToDouble(Console.ReadLine());
                        double keliling = Persegi_Panjang.keliling_persegi_panjang(p, l);
                        Console.WriteLine($"Keliling Persegi Panjang : {keliling} cm");
                    }
                    else if (choose == "luas")
                    {
                        Console.Write("Masukkan ukuran panjang : ");
                        double p = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Masukkan ukuran lebar : ");
                        double l = Convert.ToDouble(Console.ReadLine());
                        double luas = Persegi_Panjang.luas_persegi_panjang(p, l);
                        Console.WriteLine($"Luas Persegi Panjang : {luas} cm");
                    }
                    break;

                case 3:
                    if (choose == "keliling")
                    {
                        Console.Write("Masukkan ukuran sisi a : ");
                        double a = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Masukkan ukuran sisi b : ");
                        double b = Convert.ToDouble(Console.ReadLine());
                        double keliling = layang_Layang.keliling(a, b);
                        Console.WriteLine($"Keliling Layang-Layang : {keliling} cm");
                    }
                    else if (choose == "luas")
                    {
                        Console.Write("Masukkan ukuran diagonal 1 : ");
                        double d1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Masukkan ukuran diagonal 2 : ");
                        double d2 = Convert.ToDouble(Console.ReadLine());
                        double luas = layang_Layang.luas(d1, d2);
                        Console.WriteLine($"Luas Layang-Layang : {luas} cm");
                    }
                    break;

                case 4:
                    if (choose == "luas")
                    {
                        Console.Write("Masukkan ukuran diagonal 1 : ");
                        double d1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Masukkan ukuran diagonal 2 : ");
                        double d2 = Convert.ToDouble(Console.ReadLine());
                        double luas = belah_ketupat.luas(d1, d2);
                        Console.WriteLine($"Luas Belah Ketupat : {luas} cm");
                    }
                    else if (choose == "keliling")
                    {
                        Console.Write("Masukkan ukuran sisi : ");
                        double s = Convert.ToDouble(Console.ReadLine());
                        double keliling = belah_ketupat.keliling(s);
                        Console.WriteLine($"Keliling Belah Ketupat : {keliling} cm");
                    }
                    break;

                case 5:
                    if (choose == "luas")
                    {
                        Console.Write("Masukkan ukuran alas : ");
                        double a = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Masukkan ukuran tinggi : ");
                        double t = Convert.ToDouble(Console.ReadLine());
                        double luas = segitiga.luas(a, t);
                        Console.WriteLine($"Luas Segitiga : {luas} cm");
                    }
                    else if (choose == "keliling")
                    {
                        Console.Write("Masukkan ukuran sisi a : ");
                        double a = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Masukkan ukuran sisi b : ");
                        double b = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Masukkan ukuran sisi c : ");
                        double c = Convert.ToDouble(Console.ReadLine());
                        double keliling = segitiga.keliling(a, b, c);
                        Console.WriteLine($"Keliling Segitiga : {keliling} cm");
                    }
                    break;

                case 6:
                    if (choose == "keliling")
                    {
                        Console.Write("Masukkan ukuran jari - jari : ");
                        double r = Convert.ToDouble(Console.ReadLine());
                        double keliling = lingkaran.keliling(r);
                        Console.WriteLine($"Keliling Lingkaran : {keliling} cm");
                    } 
                    else if (choose == "luas")
                    {
                        Console.Write("Masukkan ukuran jari - jari : ");
                        double r = Convert.ToDouble(Console.ReadLine());
                        double luas = lingkaran.luas(r);
                        Console.WriteLine($"Luas Lingkaran : {luas} cm");
                    }
                    break;

                case 7:
                    if (choose == "keliling")
                    {
                        Console.Write("Masukkan alas : ");
                        double a = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Masukkan tinggi :");
                        double t = Convert.ToDouble(Console.ReadLine());
                        double keliling = jajargenjang.keliling(a, t);
                        Console.WriteLine($"Keliling Jajargenjang : {keliling}");
                    }
                    else if (choose == "luas")
                    {
                        Console.Write("masukkan alas : ");
                        double a = Convert.ToDouble(Console.ReadLine());
                        Console.Write("masukkan sisi miring : ");
                        double b = Convert.ToDouble(Console.ReadLine());
                        double luas = jajargenjang.luas(a, b);
                        Console.WriteLine($"Luas Jajargenjang : {luas}");
                    }
                    break;

                case 8:
                    if(choose == "keliling")
                    {
                        Console.Write("masukkan sisi sejajar terpanjang : ");
                        double a = Convert.ToDouble(Console.ReadLine());
                        Console.Write("masukkan sisi sejajar terpendek : ");
                        double b = Convert.ToDouble(Console.ReadLine());
                        Console.Write("masukkan sisi miring kiri : ");
                        double c = Convert.ToDouble(Console.ReadLine());
                        Console.Write("masukkan sisi miring kanan : ");
                        double d = Convert.ToDouble(Console.ReadLine());
                        double keliling = trapesium.keliling(a, b, c, d);
                        Console.WriteLine($"Keliling Trapesium : {keliling}");
                    }
                    else if(choose == "luas")
                    {
                        Console.Write("masukkan sisi sejajar terpanjang : ");
                        double a = Convert.ToDouble(Console.ReadLine());
                        Console.Write("masukkan sisi sejajar terpendek : ");
                        double b = Convert.ToDouble(Console.ReadLine());
                        Console.Write("masukkan tinggi : ");
                        double t = Convert.ToDouble(Console.ReadLine());
                        double luas = trapesium.luas(a, b, t);
                        Console.WriteLine($"Luas Trapesium : {luas}");
                    }
                    break;

                default:
                    Console.WriteLine("Silahkan pilih bangun datar yang ada dilist");
                    break;
            }
        }
    }
}
