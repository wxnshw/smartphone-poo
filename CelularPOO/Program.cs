using CelularPOO.Models;

namespace Program
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Nokia:");
            Smartphone smarthphoneNokia = new Nokia(numero: "622102102", modelo: "500", imei: "121a6596252362", memoria: 16);
            smarthphoneNokia.Ligar();
            smarthphoneNokia.ReceberLigacao();
            smarthphoneNokia.InstalarAplicativo("Whatsapp");

            Console.WriteLine("\n");

            Console.WriteLine("Iphone:");
            Smartphone smarthphoneIphone = new Iphone(numero: "1541542323", modelo: "6 Plus", imei: "451221220d1211", memoria: 32);
            smarthphoneIphone.Ligar();
            smarthphoneIphone.ReceberLigacao();
            smarthphoneIphone.InstalarAplicativo("Facebook");
        }
    }
}