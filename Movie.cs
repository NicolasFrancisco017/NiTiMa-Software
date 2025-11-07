public class Movie {
    private string Name;
    private string Descricao;
    private int Avaliacoes;
    private Category Categoria;

    public Movie(string Name, string Descricao, int Avaliacoes, Category Categoria)
    {
        this.Name = Name;
        this.Avaliacoes = Avaliacoes;
        this.Descricao = Descricao;
        this.Avaliacoes = Avaliacoes;
        this.Categoria = Categoria;
    }

    public Dictionary<string, string> getMovie()
    {
        Dictionary<string, string> movie = new Dictionary<string, string>();

        movie.Add("name", this.Name);
        movie.Add("Desc", this.Descricao);
        movie.Add("Avaliacao", this.Avaliacoes.ToString());
        movie.Add("Categoria", this.Categoria.getName());

        return movie;
    }

    public string getName()
    {
        return this.Name;
    }

    public string getDesc()
    {
        return this.Descricao;
    }

    public string getAvalStr()
    {
        return this.Avaliacoes.ToString();
    }

    public int getAvalInt()
    {
        return this.Avaliacoes;
    }

    public string getCategory()
    {
        return this.Categoria.getName();
    }
}