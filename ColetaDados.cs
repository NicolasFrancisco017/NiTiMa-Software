public class ColetaDados
{
    private string NomeFilme;
    private Recomendacao Recomendacao;
    private bool Gostei;

    public ColetaDados(string nomeFilme, Recomendacao recomendacao)
    {
        this.NomeFilme = nomeFilme;
        this.Recomendacao = recomendacao;
    }

    public ColetaDados(string nomeFilme, Recomendacao recomendacao, bool gostei)
    {
        this.NomeFilme = nomeFilme;
        this.Recomendacao = recomendacao;
        this.Gostei = gostei;
    }

    public bool Gostou()
    {
        
    }

}