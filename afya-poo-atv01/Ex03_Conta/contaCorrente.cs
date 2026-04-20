public class Conta
{
    public string Numero { get; }
    public string Titular { get; set; }

    private double saldo;
    private double limite;

    public double SaldoTotal => saldo + limite;

    public string StatusConta => saldo < 0 ? "Negativo" : "Positivo";

    public Conta(string numero, string titular)
    {
        Numero = numero;
        Titular = titular;
        saldo = 0;
        limite = 500;
    }

    public bool Depositar(double valor)
    {
        if (valor > 0)
        {
            saldo += valor;
            return true;
        }
        return false;
    }

    public bool Sacar(double valor)
    {
        if (valor <= SaldoTotal)
        {
            saldo -= valor;
            return true;
        }
        return false;
    }

    public override string ToString()
    {
        return $"Conta: {Numero} | Titular: {Titular} | Saldo: {saldo} | Limite: {limite}";
    }
}