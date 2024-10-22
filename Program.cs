using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo 1", imei: "2468", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone IPhone:");
Smartphone iphone = new Iphone(numero: "3691215", modelo: "Modelo 2", imei: "246810", memoria: 64);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");

