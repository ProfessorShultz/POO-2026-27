using System;

    public class Equipamento
    {
        private int id;
        private string nome;
        private int quantidadeDisponivel;
        private string estado;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public int QuantidadeDisponivel
        {
            get { return quantidadeDisponivel; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("A quantidade disponível não pode ser negativa.");
                quantidadeDisponivel = value;
            }
        }

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public Equipamento()
        {
            this.nome = string.Empty;
            this.estado = "Disponível";
        }

        public Equipamento(int id, string nome, int quantidadeDisponivel, string estado)
        {
            this.id = id;
            this.nome = nome;
            this.QuantidadeDisponivel = quantidadeDisponivel;
            this.estado = estado;
        }

        public void atualizarEstado()
        {
        }

        public void atualizarEstado(string novoEstado)
        {
            if (string.IsNullOrWhiteSpace(novoEstado))
                throw new ArgumentException("O estado do equipamento é inválido.");

            this.estado = novoEstado;
        }
    }
