public class Category
{
    private string Name;
    private string Desc;

    public Category(string Name, string Desc)
    {
        this.Name = Name;
        this.Desc = Desc;   
    }

    public string getName()
    {
        return this.Name;
    }

    public string getDesc()
    {
        return this.Desc;
    }
}