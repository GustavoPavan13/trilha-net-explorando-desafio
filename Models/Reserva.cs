using System.Diagnostics.Contracts;

namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            
            if (hospedes.Count() <=  Suite.Capacidade)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new Exception (" A quantidade de hospedes desejada é maior que a capacidade da Suite");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
              
            int contador = 0;
            foreach(Pessoa pessoas in Hospedes){
                contador ++;
            }

            return contador;
        }

        public decimal CalcularValorDiaria()
        {
            
            decimal valor = 0;
            valor = Suite.ValorDiaria * DiasReservados;
            if (DiasReservados >= 10)
            {
               
                valor = valor * 0.90M;
            }

            return valor;
        }
    }
}