using System;
using System.Collections.Generic;

public class Sistema
{
    private List<Utilizador> utilizadores;
    private List<Espaco> espacos;
    private List<Equipamento> equipamentos;
    private List<Reserva> reservas;

    public Sistema()
    {
        utilizadores = new List<Utilizador>();
        espacos = new List<Espaco>();
        equipamentos = new List<Equipamento>();
        reservas = new List<Reserva>();
        relatorios = new List<Relatorio>();
    }

    public void GerirUtilizadores()
    {
        Console.WriteLine("Gestao de utilizadores");
        foreach (Utilizador u in utilizadores)
        {
            Console.WriteLine($"ID: {u.Id} | Nome: {u.Nome} | Email: {u.Email} | Perfil: {u.Perfil}");
        }
    }

    public void GerirEspacos()
    {
        Console.WriteLine("Gestao de espaços desportivos");
        foreach (Espaco e in espacos)
        {
            Console.WriteLine($"ID: {e.Id} | Nome: {e.Nome} | Tipo: {e.TipoEspaco} | Localização: {e.Localizacao} | Estado: {e.Estado}");
        }
    }

    public void GerirEquipamentos()
    {
        Console.WriteLine("Gestão de equipamentos");
        foreach (Equipamento eq in equipamentos)
        {
            Console.WriteLine($"ID: {eq.Id} | Nome: {eq.Nome} | Qtd: {eq.QuantidadeDisponivel} | Estado: {eq.Estado}");
        }
    }

    public void AprovarReserva()
    {
        Console.WriteLine("Aprovação de reservas");
        
        var reservaPendente = reservas.Find(r => r.Estado == EstadoReserva.PENDENTE);

        if (reservaPendente != null)
        {
            if (reservaPendente.VerificarConflitos())
            {
                reservaPendente.Estado = EstadoReserva.EXPIRADA;
                Console.WriteLine($"Conflito detetado. Reserva ID {reservaPendente.Id} marcada como EXPIRADA.");
            }
            else
            {
                reservaPendente.Estado = EstadoReserva.CONFIRMADA;
                Console.WriteLine($"Reserva ID {reservaPendente.Id} aprovada com sucesso!");
            }
        }
        else
        {
            Console.WriteLine("Nenhuma reserva pendente para aprovação.");
        }
    }

    public void GerarRelatorios()
    {
        Console.WriteLine("Gerar rlatorios do sistema");
        
        Relatorio relatorio = new Relatorio();
        
        relatorio.GerarRelatorioReservasPorEspaco();
        relatorio.GerarRelatorioPorPeriodo();
        
        float taxa = relatorio.CalcularTaxaOcupacao();
        Console.WriteLine($"Taxa de Ocupação Geral: {taxa}%");
    }
}