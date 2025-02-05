class Conta
{
    public Titular Titular { get; set; }
    public int Agencia { get; set; }
    public int NumeroConta { get; set; }
    public double Saldo { get; }
    public int Limite { get; set; }
    public string Informacoes => $"Conta nº {this.NumeroConta}, Agência {this.Agencia}, Titular: {this.Titular.Nome} - Saldo: {this.Saldo}";

    public Conta(Titular titular, int agencia, int numeroConta, int limite)
    {
        this.Titular = titular;
        this.Agencia = agencia;
        this.NumeroConta = numeroConta;
        this.Limite = limite;
        this.Saldo = 0;
    }
}
