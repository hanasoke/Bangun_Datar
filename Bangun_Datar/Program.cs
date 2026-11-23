namespace Bangun_Datar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persegi persegi = new Persegi();
            Persegi_Panjang Persegi_Panjang = new Persegi_Panjang();

            Console.WriteLine("=== List Bangun Datar ===");

            Console.WriteLine("1. Persegi");
            Console.WriteLine("2. Persegi Panjang");

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

                default:
                    Console.WriteLine("Silahkan pilih bangun datar yang ada dilist");
                    break;
            }
        }
    }
}
