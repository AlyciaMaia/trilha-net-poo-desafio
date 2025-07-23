using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("IPHONE: ");
Smartphone iphone = new Iphone("928390909", "Iphone 16 pro", "09840882394", 128);
iphone.ReceberLigacao();
iphone.Ligar();
iphone.InstalarAplicativo("Instagram");

Console.WriteLine("\n");

Console.WriteLine("NOKIA: ");
Smartphone nokia = new Nokia("936373480", "Nokia 150J", "12284958587", 64);
nokia.ReceberLigacao();
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

