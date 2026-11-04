public class Espaco
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string TipoEspaco { get; set; }
    public string Localizacao { get; set; }
    public int CapacidadeMaxima { get; set; }
    public EstadoEspaco Estado { get; set; }

    // Construtor
    public Espaco(int id, string nome, string tipoEspaco,
                  string localizacao, int capacidadeMaxima,
                  EstadoEspaco estado)
    {
        Id = id;
        Nome = nome;
        TipoEspaco = tipoEspaco;
        Localizacao = localizacao;
        CapacidadeMaxima = capacidadeMaxima;
        Estado = estado;
    }

    public void AdicionarEspaco()
    {
    }

    public void AlterarEspaco()
    {
    }

    public void RemoverEspaco()
    {
    }
}
