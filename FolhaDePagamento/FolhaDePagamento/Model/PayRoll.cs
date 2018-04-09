using System;
namespace FolhaDePagamento.Model
{
    public class PayRoll
    {

        public PayRoll(){
            Funcionario = new Funcionario();
        }

        public Funcionario Funcionario { get; set; }
        public int mesAtual { get; set; }
        public int anoAtual { get; set; }
        public int horasTrabalhadas { get; set; }
        public double valorHorasTrabalhadas { get; set; }

        public override string ToString(){
            

            return "Nome: " + Funcionario.nome +
            "\nCPF: " + Funcionario.cpf + "\nMês Atual:" + mesAtual + "\nAno Atual: " + anoAtual;

        }
    }
}
