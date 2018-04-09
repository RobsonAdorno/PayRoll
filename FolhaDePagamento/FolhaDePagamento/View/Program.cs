using System;
using FolhaDePagamento.Model;
using FolhaDePagamento.DAL;
using FolhaDePagamento.View;

namespace FolhaDePagamento
{
    class Program
    {
        static void Main(string[] args)
        {
            String op;

            do
            {
               
                Console.Clear();
                Console.ReadKey();
                Console.WriteLine("Digite a opção desejada abaixo:");
                Console.WriteLine("----------------------------------");
                Console.WriteLine("1) Cadastrar Funcionário");
                Console.WriteLine("----------------------------------");
                Console.WriteLine("2) Cadastrar Folha de Pagamento");
                Console.WriteLine("----------------------------------");
                Console.WriteLine("3) Consultar Folha de Pagamento");
                Console.WriteLine("----------------------------------");
                Console.WriteLine("4) Listar Folhas de Pagamento");
                Console.WriteLine("----------------------------------");
                Console.WriteLine("0) Sair");
                Console.WriteLine("----------------------------------");
                op = Console.ReadLine();
                switch (op)
                {
                    case "1":
                        FuncionarioView.Cadastrar();
                        break;

                    case "2":
                        PayRollView.Exibir();
                        break;

                    case "3":
                        Console.WriteLine("Digite o CPF do funcionário!");
                        string cpf = Console.ReadLine();
                        PayRoll pr = new PayRoll();

                        if(FolhaDePagamentoDAO.CadastrationPayRoll(pr).Equals(cpf)){
                            foreach (PayRoll item in FolhaDePagamentoDAO.ShowTheRoll())
                            {
                                Console.WriteLine("O nome: " + item.Funcionario.nome + "/nCPF:" +item.Funcionario.cpf + "Ano da folha: " + item.anoAtual +
                                                  "Mes da folha: " + item.mesAtual);
                            }
                        }
                        break;

                    default:
                        Console.WriteLine("Opção Inválida!");
                        break;
                }
            } while (op != "0");


        }
    }
}
