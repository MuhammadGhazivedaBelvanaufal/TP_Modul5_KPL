using static TPmodul5_1302220011.Class1;

internal class Program
{
    private static void Main(string[] args)
    {
        HaloGeneric haloGeneric = new HaloGeneric();

        Console.Write("Masukkan nama panggilan Anda: ");
        string namaPanggilan = Console.ReadLine();

        haloGeneric.SapaUser(namaPanggilan);
        //Console.ReadLine();

        Console.Write("Masukkan NIM Anda: ");
        string nim = Console.ReadLine();

        DataGeneric<string> dataGeneric = new DataGeneric<string>(nim);
        dataGeneric.PrintData();

        Console.ReadLine();
    }
}