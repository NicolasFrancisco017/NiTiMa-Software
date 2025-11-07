public class User {
    private string? NomeUsuario;
    private string? NomeCompleto;
    private string? Senha;
    private string? Preferencia;

    public User(string nomeUsuario, string nomeCompleto, string senha) {
        this.NomeUsuario = nomeUsuario;
        this.NomeCompleto = nomeCompleto;
        this.Senha = senha;
    }

    public bool atualizarDados(string nomeUsuario, string nomeCompleto, string senha)
    {
        try
        {
            this.NomeUsuario = nomeUsuario;
            this.NomeCompleto = nomeCompleto;
            this.Senha = senha;
            return true;
        }
        catch (Exception e)
        {
            Console.WriteLine("Mensagem de erro: " + e);
            return false;
        }
    }
    
    public bool definirPreferencia(string preferencia)
    {
        try
        {
            this.Preferencia = preferencia;
        } catch(Exception e)
        {
            Console.WriteLine("Erro: " + e);
            return false;
        }
        return true;
    }

    public bool excluirUsuario()
    {
        this.NomeCompleto = null;
        this.NomeUsuario = null;
        this.Senha = null;
        Global.logado = false;
        return true;
    }

    public bool logar(string nome, string usuario, string senha)
    {
        if (nome == this.NomeCompleto && usuario == this.NomeUsuario && senha == this.Senha)
        {
            Global.logado = true;
        }

        return true;
    }

    public Dictionary<string, string> visualizarUsuario()
    {
        Dictionary<string, string> user = new Dictionary<string, string>();

        user.Add("Username", this.NomeUsuario);
        user.Add("Name", this.NomeCompleto);
        user.Add("Senha", this.Senha);

        return user;
    }

    public string getNome()
    {
        return this.NomeCompleto;
    }

    public string getUserName()
    {
        return this.NomeUsuario;
    }
    
    public string getPreferencia()
    {
        return this.Preferencia;
    }

}