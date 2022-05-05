
public class Bichinho
{
    //* Atributos
    private string? _nome;
    private int _vida;
    private int _fome;
    private int _tedio;
    private int _sono;

    //* Getters e Setters
    public string? nome
    {
        get { return this._nome; }
        set { this._nome = value; }
    }
    public int vida
    {
        get { return this._vida; }
        set { this._vida = value; }
    }
    public int fome
    {
        get { return this._fome; }
        set { this._fome = value; }
    }
    public int tedio
    {
        get{ return this._tedio;}
        set{ this._tedio = value;}
    }
    public int sono
    {
        get{ return this._sono;}
        set{ this._sono = value;}
    }

}
