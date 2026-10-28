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

