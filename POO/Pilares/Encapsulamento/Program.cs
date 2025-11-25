using Encapsulamento;

// float dinheiro = 200; 

// ContaBancaria contaSamuel = new ContaBancaria();
// ContaBancaria contaMaria = new ContaBancaria();

// contaSamuel.Depositar(dinheiro);
// Console.WriteLine($"Novo Saldo da conta R${contaSamuel.GetSaldo()} ");

// Console.WriteLine($"Novo Saldo da conta R${contaMaria.GetSaldo()} ");

// contaSamuel.Sacar(100);
// Console.WriteLine($"Saldo apos o saque do edu {contaSamuel.GetSaldo()}");

Carro c1 = new Carro();

c1.DefinirMarca("Fiat");
c1.DefinirModelo("Touro");

c1.Acelerar(100);
c1.Acelerar(50);
c1.frear(10);

Console.WriteLine($"Marca :{c1.ObterMarca()}");
Console.WriteLine($"Modelo: {c1.Obtermodelo()}" );
Console.WriteLine($"Velocidade Atual: {c1.ObterVelocidade()} KM/H");