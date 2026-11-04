public class Reserva
{
    
    public int Id { get; set; }
    public DateTime Data { get; set; }
    public TimeSpan HoraInicio { get; set; }
    public TimeSpan HoraFim { get; set; }
    public EstadoReserva Estado { get; set; }

    // Construtor
    public Reserva(int id, DateTime data, TimeSpan horaInicio, TimeSpan horaFim, EstadoReserva estado)
    {
        Id = id;
        Data = data;
        HoraInicio = horaInicio;
        HoraFim = horaFim;
        Estado = estado;
    }

    // Criar uma reserva
    public void CriarReserva()
    {
        // Criar reserva
    }

    // Alterar uma reserva
    public void AlterarReserva()
    {
        // Alterar os dados da reserva
    }

    // Cancelar uma reserva
    public void CancelarReserva()
    {
        Estado = EstadoReserva.Cancelada;
    }

    // Verificar conflitos de reservas
    public bool VerificarConflitos()
    {
        // Verificar se existem conflitos de horário
        return false;
    }
}