namespace DesafioPOO.Models
{

    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string sistemaOperacional, string imei, string memoria) :
        base(numero, modelo, sistemaOperacional, imei, memoria)
        {

        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp} no Nokia {Modelo}");
        }
    }
}