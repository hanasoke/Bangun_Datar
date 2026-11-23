namespace Bangun_Datar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persegi persegi = new Persegi();

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

                default:
                    Console.WriteLine("Silahkan pilih bangun datar yang ada dilist");
                    break;
            }
        }
    }
}
