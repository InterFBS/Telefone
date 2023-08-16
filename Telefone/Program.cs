


using Telefone.Models;
Console.WriteLine("Iphone");
Smartphone iphone = new Iphone("898378", "Iphone", "2978409283", 12);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("WhatsApp");

Console.WriteLine("Nokia");
Smartphone nokia = new Nokia("898378", "Iphone", "2978409283", 12);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Telegram");