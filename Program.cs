using DesafioPOO.Models; 
using System;

namespace DesafioPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Nokia nokia = new Nokia("123456789", "Nokia Modelo", "123456", 64);
            Iphone iphone = new Iphone("987654321", "iPhone Modelo", "987654", 128);

            Console.WriteLine("Teste Smartphone Nokia:");
            nokia.Ligar();
            nokia.InstalarAplicativo("WhatsApp");
            nokia.ReceberLigacao();

            Console.WriteLine("---------------------------------------------------------");

            Console.WriteLine("Teste Smartphone Iphone:");
            iphone.Ligar();
            iphone.InstalarAplicativo("Instagram");
            iphone.ReceberLigacao();

            Console.ReadLine();
        }
    }
}
