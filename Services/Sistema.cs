using System;
using System.Collections.Generic;
using System.Linq;

public class Sistema
{
    public List<Utilizador> Utilizadores { get; set; }
    public List<Espaco> Espacos { get; set; }
    public List<Reserva> Reservas { get; set; }

    public Sistema()
    {
        Utilizadores = new List<Utilizador>();
        Espacos = new List<Espaco>();
        Reservas = new List<Reserva>();
    }

    public void RegistarUtilizador(Utilizador novo)
    {
        if (novo == null)
            throw new ArgumentException("Dados inválidos.");

        if (Utilizadores.Any(u => u.Email.Equals(novo.Email, StringComparison.OrdinalIgnoreCase)))
            throw new InvalidOperationException("Já existe um utilizador registado com esse email.");

        novo.Id = Utilizadores.Count > 0 ? Utilizadores.Max(u => u.Id) + 1 : 1;
        Utilizadores.Add(novo);
    }

    public Utilizador Autenticar(string email, string password)
    {
        Utilizador user = Utilizadores.FirstOrDefault(u => u.Login(email, password));
        if (user == null)
            throw new UnauthorizedAccessException("Login inválido: email ou password incorretos.");

        return user;
    }

    public void AdicionarEspaco(Espaco espaco)
    {
        if (espaco == null)
            throw new ArgumentException("Dados inválidos.");

        espaco.Id = Espacos.Count > 0 ? Espacos.Max(e => e.Id) + 1 : 1;
        Espacos.Add(espaco);
    }

    public void SolicitarReserva(Reserva novaReserva)
    {
        if (novaReserva == null || novaReserva.Utilizador == null)
            throw new UnauthorizedAccessException("Tentativa de reserva sem autenticação.");

        Espaco espacoReal = Espacos.FirstOrDefault(e => e.Id == novaReserva.Espaco.Id);
        if (espacoReal == null)
            throw new KeyNotFoundException("Espaço inexistente.");

        if (espacoReal.Estado == EstadoEspaco.INDISPONIVEL)
            throw new InvalidOperationException("O espaço selecionado encontra-se indisponível.");

        if (novaReserva.verificarConflitos(Reservas))
            throw new InvalidOperationException("Conflito de horários: já existe uma reserva para esse espaço nesse período.");

        novaReserva.Id = Reservas.Count > 0 ? Reservas.Max(r => r.Id) + 1 : 1;
        novaReserva.Espaco = espacoReal;
        novaReserva.criarReserva();
        Reservas.Add(novaReserva);
    }

    public void aprovarReserva(int reservaId)
    {
        Reserva r = Reservas.FirstOrDefault(res => res.Id == reservaId);
        if (r == null)
            throw new KeyNotFoundException("Reserva não encontrada.");

        r.Estado = EstadoReserva.CONFIRMADA;
    }

    public void gerirUtilizadores() { }
    public void gerirEspacos() { }
    public void gerarRelatorios() { }
}