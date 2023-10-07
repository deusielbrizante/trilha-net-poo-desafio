using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Celular Nokia");
Smartphone nokia = new Nokia(numero: "92836", modelo: "Tijolão", imei: "162754712", memoria: 16);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Genshin Impact");

Console.WriteLine("\n");

Console.WriteLine("Celular Iphone");
Smartphone iphone = new Iphone(numero: "31231", modelo: "Mais Caro", imei: "621867451", memoria: 512);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Clash Royale");
