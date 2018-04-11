using System;
using FolhaDePagamento.DAL;
using FolhaDePagamento.Model;

namespace FolhaDePagamento.View
{
    public class PayRollView
    {

        public static void Exibir() {
        
            Funcionario func = new Funcionario();
            PayRoll pr = new PayRoll();

            Console.WriteLine("Digite o CPF do funcionário!");
            string cpfs = Console.ReadLine();
            //Esse metodo "CadastrationCPF()" apenas serve para verificar se o CPF já existe na base de dados
            if (VendedorDAO.CadastrationCPF(cpfs))
            {
                foreach (Funcionario v in VendedorDAO.Mostrar())
                {
                    Console.WriteLine("Seguinte CPF já está cadastrado: " + v.cpf + "\nCujo nome do Funcionário é: " + v.nome);
                    pr.Funcionario.cpf = v.cpf;
                    pr.Funcionario.nome = v.nome;
                }
                
                pr.mesAtual = DateTime.Now.Month;
                pr.anoAtual = DateTime.Now.Year;
                Console.WriteLine("Digite as horas trabalhadas do funcionário, por favor!");
                pr.horasTrabalhadas = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Digite o valor da hora trabalhada do funcionário, por favor!");
                pr.valorHorasTrabalhadas = Convert.ToInt32(Console.ReadLine());
                FolhaDePagamentoDAO.CadastrationPayRoll(pr);

                if (FolhaDePagamentoDAO.CadastrationPayRoll(pr))
                {

                    Console.WriteLine("Folha de pagamento registrada com sucesso!");
                }
                else
                {
                    Console.WriteLine("Houve algum problema ao cadastrar a folha de pagamento!");
                }

            }
            else
            {
                Console.WriteLine("Usuário não encontrado na base de dados!");
            }
        
        }

       
    }
}
