namespace ProjetoFinal;
/// <summary>
/// Classe Jewel: define Jewel
/// </summary>
public abstract class Jewel : ItemMap 
{
    public int Points {get; private set;}
    public Jewel(string Symbol, int Points) : base(Symbol)
    {
        this.Points = Points;
    }
}
