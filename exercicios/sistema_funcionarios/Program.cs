using sistema_funcionarios.classes;

internal class Program
{
    private static void Main(string[] args)
    {
        Sistema db = new Sistema();
        db.Connection();
        db.Login(email:"admin@suporte.com",senha:"admin");
        db.Cadastrar("Marcelo", "Henrique", "teste@gmail.com","123");
    }
}