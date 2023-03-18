// See https://aka.ms/new-console-template for more information
public class HaloGeneric
{
    String nama;
    public void sapaUser(String nama)
    {
        Console.WriteLine("Halo " + nama);
    }
}

public class program
{
    static void Main(string[] args)
    {
        HaloGeneric halo = new HaloGeneric();
        Console.WriteLine("Masukkan nama anda: ");
        string nama = Console.ReadLine();
        halo.sapaUser(nama);
    }
}
