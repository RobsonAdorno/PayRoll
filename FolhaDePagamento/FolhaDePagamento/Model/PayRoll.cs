using System;
namespace FolhaDePagamento.Model
{
    public class PayRoll
    {
        public Funcionario cpfFuncionario { get; set; }
        public int mesAtual { get; set; }
        public int anoAtual { get; set; }
        public int horasTrabalhadas { get; set; }
        public double valorHorasTrabalhadas { get; set; }
    }
}
