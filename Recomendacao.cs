public class Recomendacao
{
    private List<Movie> filmes = new List<Movie>();
    private Dictionary<string, int> Preferencias =  new Dictionary<string, int>
    {{"Acao", 0}, {"Romance", 0}, {"Terror", 0}, {"Comedia", 0}};
    

    public void analisarAvaliacao(bool gostei, string genero)
    {
        if(gostei)
        {
            Preferencias[genero]++;
        }
    }


}