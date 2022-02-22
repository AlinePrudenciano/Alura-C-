public class ContaCorrente
{
    public Cliente _titular { get; set; }
    public int _agencia { get; set; }
    public int _numero { get; set; }
    private double _saldo = 100;
    public double Saldo
    {
        get
        {
            return _saldo;
        }
        set
        {
            if (value < 0)
            {
                return;
            }
            _saldo = value;
        }
    }

    public void Depositar(double valor)
    {
        this._saldo += valor;
    }

    public bool Sacar(double valor)
    {
        if (this._saldo < valor)
        {
            return false;
        }

        this._saldo -= valor;
        return true;
    }

    public bool Transferir(double valor, ContaCorrente contaDestino) 
    {
        if(this._saldo < valor)
        {
            return false;
        }

        this._saldo -= valor;
        contaDestino.Depositar(valor);
        return true;
    }


}