public class Utilizador
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }
    private string Password { get; set; }
    public Perfil Perfil { get; set; }

    // Construtor
    public Utilizador(int id, string nome, string email, string password, Perfil perfil)
    {
        Id = id;
        Nome = nome;
        Email = email;
        Password = password;
        Perfil = perfil;
    }

    // Métodos
    public void Registar()
    {

           // Registar os dados do utilizador
     Console.WriteLine("Utilizador registado com sucesso!");

    }

    public bool Login()
    {
        return false;
    }

    public void ConsultarPerfil()
    {

    }
}


public class Utilizador
{
    
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }
    public string PalavraPasse { get; set; }

    //Construtor - overloading
    public Utilizador(int id, string nome, string email, string palavraPasse)
    {
        Id = id;
        Nome = nome;
        Email = email;
        PalavraPasse = palavraPasse;
    }
}