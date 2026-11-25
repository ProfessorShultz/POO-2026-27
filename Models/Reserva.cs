using System;
using System.Collections.Generic;
using System.Linq;

public class Reserva
{
    public int Id { get; set; }
    public Utilizador Utilizador { get; set; }
    public Espaco Espaco { get; set; }
    public DateTime Data { get; set; }
    public TimeSpan HoraInicio { get; set; }
    public TimeSpan HoraFim { get; set; }
    public EstadoReserva Estado { get; set; }

    public Reserva()
    {
        Estado = EstadoReserva.PENDENTE;
    }

    public Reserva(int id, Utilizador utilizador, Espaco espaco, DateTime data, TimeSpan horaInicio, TimeSpan horaFim, EstadoReserva estado)
    {
        if (utilizador == null)
            throw new UnauthorizedAccessException("Tentativa de reserva sem autenticação.");
        if (espaco == null)
            throw new KeyNotFoundException("Espaço inexistente.");
        if (horaFim <= horaInicio)
            throw new ArgumentException("Dados inválidos: a hora de fim tem de ser depois da hora de início.");

        Id = id;
        Utilizador = utilizador;
        Espaco = espaco;
        Data = data;
        HoraInicio = horaInicio;
        HoraFim = horaFim;
        Estado = estado;
    }

    public void criarReserva()
    {
        Estado = EstadoReserva.PENDENTE;
    }

    public void alterarReserva(DateTime novaData, TimeSpan novoInicio, TimeSpan novoFim)
    {
        if (novoFim <= novoInicio)
            throw new ArgumentException("Dados inválidos: horário incorreto.");

        Data = novaData;
        HoraInicio = novoInicio;
        HoraFim = novoFim;
    }

    public void cancelarReserva()
    {
        Estado = EstadoReserva.CANCELADA;
    }

    public bool verificarConflitos(List<Reserva> todasReservas)
    {
        if (todasReservas == null || Espaco == null)
            return false;

        return todasReservas.Any(r =>
            r.Id != this.Id &&
            r.Espaco != null &&
            r.Espaco.Id == this.Espaco.Id &&
            r.Data.Date == this.Data.Date &&
            r.Estado != EstadoReserva.CANCELADA &&
            r.Estado != EstadoReserva.EXPIRADA &&
            (this.HoraInicio < r.HoraFim && this.HoraFim > r.HoraInicio)
        );
    }
}