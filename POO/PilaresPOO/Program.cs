using PilaresPOO.Classes.Pilares;
Console.Clear();

ContaCorrente ctKayky = new ContaCorrente();
ctKayky.Titular = "Kayky Nascimento Moura";
ctKayky.Depositar(1000f); // usuario colocou grana direto no saldo

Console.WriteLine($"Titular da Conta: {ctKayky.Titular}");
Console.WriteLine($"Saldo da Conta: {ctKayky.getSaldo()}");

float valorSacado = ctKayky.Sacar(500f);

Console.WriteLine($"Valor do Saque: {valorSacado}");
Console.WriteLine($"Saldo da conta: {ctKayky.getSaldo()}");


