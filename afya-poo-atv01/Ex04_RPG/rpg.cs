public class Personagem
{
    public string Nome { get; private set; }
    public string Classe { get; private set; }
    public int Nivel { get; private set; }

    private double vidaAtual;
    private double vidaMaxima;

    public Personagem(string nome, string classe)
    {
        Nome = nome;
        Classe = classe;
        Nivel = 1;

        if (classe == "Guerreiro")
            vidaMaxima = 150;
        else
            vidaMaxima = 80;

        vidaAtual = vidaMaxima;
    }

    public void ReceberDano(double pontos)
    {
        if (vidaAtual <= 0) return;

        vidaAtual -= pontos;
        if (vidaAtual < 0)
            vidaAtual = 0;
    }

    public void Curar(double pontos)
    {
        if (vidaAtual <= 0) return;

        vidaAtual += pontos;
        if (vidaAtual > vidaMaxima)
            vidaAtual = vidaMaxima;
    }

    public void SubirNivel()
    {
        if (vidaAtual <= 0) return;

        Nivel++;
        vidaMaxima *= 1.10;
        vidaAtual = vidaMaxima;
    }

    public void Ressuscitar()
    {
        if (vidaAtual == 0)
            vidaAtual = vidaMaxima;
    }

    public override string ToString()
    {
        return $"{Nome} ({Classe}) - Lvl {Nivel} - HP: {vidaAtual}/{vidaMaxima}";
    }
}