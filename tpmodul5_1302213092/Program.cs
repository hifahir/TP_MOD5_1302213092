// See https://aka.ms/new-console-template for more information
public class HaloGeneric
{
    String nama;
    public void sapaUser(String nama)
    {
        Console.WriteLine("Halo " + nama);
    }
}

public class dataGeneric<T>
{
    private T data {  get; set; }

    public dataGeneric(T data)
    {
        this.data = data;
    }

    public void printData()
    {
        Console.WriteLine("Data yang tersimpan: " +  data);
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

        Console.WriteLine("Masukkan NIM: ");
        string NIM = Console.ReadLine();
        dataGeneric<string> data = new dataGeneric<string>(NIM);
        data.printData();
    }
}


