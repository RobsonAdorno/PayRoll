using System;
using FolhaDePagamento.Model;
using FolhaDePagamento.DAL;
using FolhaDePagamento.View;
using FolhaDePagamento.Utils;

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
                        PayRoll pr = new PayRoll();

                        Console.WriteLine("Digite o CPF do funcionário!");
                        pr.Funcionario.cpf = Console.ReadLine();


                        if ( FolhaDePagamentoDAO.CallInformation(pr.Funcionario.cpf, pr.mesAtual, pr.anoAtual)){

                            if (!FolhaDePagamentoDAO.CadastrationPayRoll(pr))
                            {
                                foreach (PayRoll item in FolhaDePagamentoDAO.ShowTheRoll())
                                {
                                    Console.WriteLine(item.ToString());
                                     
                                }
                            }
                        }else{

                            Console.WriteLine("Folha de pagamento não encontrada na base de dados!");

                        }

                       
                        Console.WriteLine("Pressione algum botão para voltar ao menu");
                        Console.ReadKey();
                        break;
                    case "4":
                        Console.WriteLine("Digite o mês da folha de pagamento");
                        int mesAtual = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Digite o ano da folha de pagamento");
                        int anoAtual = Convert.ToInt32(Console.ReadLine());

                        if (FolhaDePagamentoDAO.CheckingData(mesAtual, anoAtual) != null){

                            Console.WriteLine("Dados encontrados na base de dados!");

                            foreach (PayRoll item in FolhaDePagamentoDAO.CheckingData(mesAtual, anoAtual))
                            {
                                Console.WriteLine(item.ToString());
                            }
                        }else{
                            Console.WriteLine("Dados incorretos!");
                        }
                        Console.WriteLine("Pressione algum botão para voltar ao menu");
                        Console.ReadKey();

                        break;

                    case "0":
                        Console.WriteLine("Encerrando...");
                        break;

                    default:
                        Console.WriteLine("Opção Inválida!");
                        break;
                }
            } while (op != "0");


        }
    }
}
