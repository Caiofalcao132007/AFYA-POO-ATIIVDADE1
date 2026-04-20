public class Lampada
{
    public string Marca { get; private set; }
    public string Tecnologia { get; } // readonly
    public bool Ligada { get; private set; }
    private int brilho;

    public int Brilho
    {
        get { return brilho; }
        private set
        {
            if (value >= 0 && value <= 100)
                brilho = value;
        }
    }

    public Lampada(string marca, string tecnologia)
    {
        Marca = marca;
        Tecnologia = tecnologia;
        Ligada = false;
        brilho = 100;
    }

    public void Alternar()
    {
        Ligada = !Ligada;
    }

    public void AjustarBrilho(int novoBrilho)
    {
        if (Ligada)
            Brilho = novoBrilho;
    }

    public override string ToString()
    {
        return $"{Marca} - {Tecnologia} | Ligada: {Ligada} | Brilho: {Brilho}";
    }
}