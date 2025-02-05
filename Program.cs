// Classe Conta que representa uma conta bancária, com atributos Titular, agência, número da conta, saldo e limite.  
// Inclui um método que retorna as informações detalhadas da conta.  
Titular titular = new Titular("George Harrison", "000.000.000-00", "Rua dos Besouros, Liverpool");
Conta c = new Conta(titular, 1, 2234, 100000);

Console.WriteLine("Informações do Titular: ");
Console.WriteLine($"Nome: {c.Titular.Nome}");
Console.WriteLine($"CPF: {c.Titular.Cpf}");
Console.WriteLine($"Endereço: {c.Titular.Endereco}");

Console.WriteLine("\nInformações da conta");
Console.WriteLine(c.Informacoes);
Console.WriteLine($"Limite: {c.Limite}");