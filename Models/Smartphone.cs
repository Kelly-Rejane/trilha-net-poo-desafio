namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        public string Modelo { get; private set; }
        public string SistemaOperacional { get; private set; }
        public string Imei { get; private set; }
        public string Memoria { get; private set; }

        public Smartphone(string numero, string modelo, string sistemaOperacional, string imei, string memoria)
        {
            Numero = numero;
            Modelo = modelo;
            SistemaOperacional = sistemaOperacional;
            Imei = imei;
            Memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}