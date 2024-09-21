using DesafioPOO.Models;
// TODO: Realizar os testes com as classes Nokia e Iphone


Iphone iphone1 = new Iphone("(11)94238-1503", "Iphone 15 Pro", "123456789", 64);
Nokia nokia1 = new Nokia("(11)99891-5196", "Nokia Tijolão", "987654321", 28);

nokia1.InstalarAplicativo("Android");
nokia1.Ligar();
nokia1.ReceberLigacao();


iphone1.InstalarAplicativo("Telegram");
iphone1.Ligar();
iphone1.ReceberLigacao();


