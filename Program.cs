using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia (numero:"111111",modelo: "Modelo 1", imei:"imeixxxxx", memoria: 256);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine();

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone (numero:"22222222",modelo: "Modelo 2", imei:"imeiyyyyyyy", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");