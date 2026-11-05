using System;
    public class Reserva
    {
        private int id;
        private Utilizador utilizador;
        private Espaco espaco;
        private DateTime data;
        private TimeSpan horaInicio;
        private TimeSpan horaFim;
        private EstadoReserva estado;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public Utilizador Utilizador
        {
            get { return utilizador; }
            set { utilizador = value; }
        }

        public Espaco Espaco
        {
            get { return espaco; }
            set { espaco = value; }
        }

        public DateTime Data
        {
            get { return data; }
            set { data = value; }
        }

        public TimeSpan HoraInicio
        {
            get { return horaInicio; }
            set { horaInicio = value; }
        }

        public TimeSpan HoraFim
        {
            get { return horaFim; }
            set { horaFim = value; }
        }

        public EstadoReserva Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public Reserva()
        {
            this.estado = EstadoReserva.PENDENTE;
        }

        public Reserva(int id, Utilizador utilizador, Espaco espaco, DateTime data, TimeSpan horaInicio, TimeSpan horaFim, EstadoReserva estado)
        {
            this.id = id;
            this.utilizador = utilizador;
            this.espaco = espaco;
            this.data = data;
            this.horaInicio = horaInicio;
            this.horaFim = horaFim;
            this.estado = estado;
        }

        public void criarReserva()
        {
            this.estado = EstadoReserva.PENDENTE;
        }

        public void alterarReserva()
        {
        }

        public void cancelarReserva()
        {
            this.estado = EstadoReserva.CANCELADA;
        }

        public bool verificarConflitos()
        {
            return false;
        }
    }