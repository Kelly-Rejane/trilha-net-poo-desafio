using DesafioPOO.Models;


Iphone meuIphone = new Iphone("123456", "14 Pro Max", "IOS", "123456789101112", "256GB");
meuIphone.Ligar();
Console.WriteLine($"Modelo: {meuIphone.Modelo}, Sistema Operacional: {meuIphone.SistemaOperacional}");
meuIphone.InstalarAplicativo("WhatsApp");


Console.WriteLine("\n");

Nokia meuNokia = new Nokia("1236547", "NK 15", "Andoid", "1236549871125687", "64G");
meuNokia.ReceberLigacao();
Console.WriteLine($"Modelo: {meuNokia.Modelo}, Sistema Operacional: {meuNokia.SistemaOperacional}");
meuNokia.InstalarAplicativo("Instagram");

