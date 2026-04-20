public class Cofre
{
    public string Dono { get; private set; }
    private string senha;
    public bool EstaAberto { get; private set; }
    private int tentativasErradas;

    public Cofre(string dono, string senhaInicial)
    {
        Dono = dono;
        senha = senhaInicial;
        EstaAberto = false;
        tentativasErradas = 0;
    }

    public string Abrir(string senhaInformada)
    {
        if (tentativasErradas >= 3)
            return "Cofre Bloqueado";

        if (senhaInformada == senha)
        {
            EstaAberto = true;
            tentativasErradas = 0;
            return "Cofre aberto!";
        }

        tentativasErradas++;
        return "Senha incorreta";
    }

    public void Fechar()
    {
        EstaAberto = false;
    }

    public bool AlterarSenha(string senhaAntiga, string novaSenha)
    {
        if (EstaAberto && senhaAntiga == senha)
        {
            senha = novaSenha;
            return true;
        }
        return false;
    }
}