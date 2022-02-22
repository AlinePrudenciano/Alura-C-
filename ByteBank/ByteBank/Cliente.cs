public class Cliente
    {
    public string Nome { get; set; }
    private string _cpf;
    public string CPF
    {
        get
        {
            return _cpf;
        }
        set
        {
            if (_cpf.Length != 11)  { }
            _cpf = value;
        }
    }
    public string profissao { get; set; }
}

