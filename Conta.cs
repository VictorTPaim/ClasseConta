public class Conta
{
    public int Codigo { get; }
    public double Saldo { get; private set; }
    
    public Conta(int codigo)
    {
        Codigo = codigo;
        Saldo = 0.0;
    }

    public void Sacar(double valor)
    {
        ValidarValor(valor);
        Saldo = Saldo - valor;
    }

    public void Depositar(double valor)
    {
        VerificarDeposito(valor);
        Saldo = Saldo + valor;
    }

    public void Transferir(double valor, Conta conta)
    {
        Sacar(valor);
        conta.Depositar(valor);
        
        /*ValidarValor(valor);
        conta.Saldo = conta.Saldo + valor;
        Saldo = Saldo - valor;*/
    }

    //Verifica se o Valor é menor ou igual a Zero ou se o Valor é maior que o Saldo.
    private void ValidarValor(double valor)
    {
        if(valor <= 0 || valor > Saldo)
        {
            throw new ArgumentException("O valor não pode ser transferido");
        }
    }

    //Verifica se o valor é menor ou igual a Zero;
    private void VerificarDeposito(double valor)
    {
        if(valor <= 0)
        {
            throw new ArgumentException("O valor não pode ser depositado");
        }
    }
}