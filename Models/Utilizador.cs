using System;

public class Utilizador
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public Perfil Perfil { get; set; }

    public Utilizador()
    {
        Nome = string.Empty;
        Email = string.Empty;
        Password = string.Empty;
        Perfil = Perfil.UTILIZADOR_NORMAL;
    }

    public Utilizador(int id, string nome, string email, string password, Perfil perfil)
    {
        if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            throw new ArgumentException("Dados inválidos: nome, email e password são obrigatórios.");

        Id = id;
        Nome = nome;
        Email = email;
        Password = password;
        Perfil = perfil;
    }

    public void Registar()
    {
        if (string.IsNullOrWhiteSpace(Email) || string.IsNullOrWhiteSpace(Password))
            throw new ArgumentException("Dados inválidos para registo.");
    }

    public bool Login(string emailInput, string passwordInput)
    {
        return string.Equals(Email, emailInput, StringComparison.OrdinalIgnoreCase)
               && Password == passwordInput;
    }

    public string ConsultarPerfil()
    {
        return $"ID: {Id} | Nome: {Nome} | Email: {Email} | Perfil: {Perfil}";
    }
}
