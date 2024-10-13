internal class Program
{
    private static void Main(string[] args)
    {
        int a = 1, b = 2, c = 3;
        float x;

        Console.Write("Nhap a = ");
        string aString = Console.ReadLine();
        a = int.Parse(aString);

        Console.Write("Nhap b = ");
        string bString = Console.ReadLine();
        b = int.Parse(aString);

        Console.Write("Nhap c = ");
        string cString = Console.ReadLine();
        c = int.Parse(aString);

        Console.WriteLine("Giai phuong trinh");
        Console.WriteLine(a + "x + " + b + " = " + c);


        if (a == 0)
        {
            // (x.0) + b = c ==> b = c
            if (b != c)
            {
                // khong bao gio xay ra cai nay
                Console.WriteLine("Khong tim duoc x vi a = 0 va b != c");
            }
            else
            {
                Console.WriteLine("Co vo so nghiem");
            }
        }
        else
        {
            x = (float)(c - b) / a;
            Console.WriteLine("Ket qua cua x la: " + x);
        }


        Console.ReadKey();
    }
}