using DesafioPOO.Models;

// *IMPLEMENTADO*: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("\nTeste Nokia:");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Nokia 1", imei: "0000111101", memoria: 64);
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n-----------------------");

Console.WriteLine("\nTeste iPhone:");
Smartphone iphone = new Iphone(numero: "654321", modelo: "iPhone 1", imei: "0000222202", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Facebook");

Console.WriteLine("\n-----------------------");
