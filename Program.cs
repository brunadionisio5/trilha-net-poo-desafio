using DesafioPOO.Models;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Testando smartphone Nokia:");
        Smartphone nokia = new Nokia("1199001000", "Nokia 3310", "IMEI123456", 64);
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("WhatsApp");

        Console.WriteLine("\nTestando smartphone iPhone:");
        Smartphone iphone = new Iphone("1199111222", "iPhone 14", "IMEI987654", 128);
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");
    }
}
