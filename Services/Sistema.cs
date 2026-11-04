using System;
using System.Collections.Generic;

    public class Sistema
    {
        private List<Utilizador> utilizadores;
        private List<Espaco> espacos;
        private List<Reserva> reservas;

        public List<Utilizador> Utilizadores
        {
            get { return utilizadores; }
            set { utilizadores = value; }
        }

        public List<Espaco> Espacos
        {
            get { return espacos; }
            set { espacos = value; }
        }

        public List<Reserva> Reservas
        {
            get { return reservas; }
            set { reservas = value; }
        }

        public Sistema()
        {
            this.utilizadores = new List<Utilizador>();
            this.espacos = new List<Espaco>();
            this.reservas = new List<Reserva>();
        }

        public void gerirUtilizadores()
        {
        }

        public void gerirEspacos()
        {
        }

        public void aprovarReserva()
        {
        }

        public void gerarRelatorios()
        {
        }
    }
