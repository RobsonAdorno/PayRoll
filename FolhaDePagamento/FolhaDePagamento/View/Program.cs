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
                        //Funcionario func = new Funcionario();
                        PayRoll pr = new PayRoll();


                        Console.WriteLine("Digite o CPF do funcionário!");
                        string cpfs = Console.ReadLine();
                        //Esse metodo "CadastrationCPF()" apenas serve para verificar se o CPF já existe na base de dados
                        if (VendedorDAO.CadastrationCPF(cpfs))
                        {
                            foreach (Funcionario v in VendedorDAO.Mostrar())
                            {
                                Console.WriteLine("Seguinte CPF já está cadastrado: " + v.cpf + "\nCujo nome do Funcionário é: " + v.nome);
                            }

                            pr.mesAtual = DateTime.Now.Month;
                            pr.anoAtual = DateTime.Now.Year;
                            Console.WriteLine("Digite as horas trabalhadas do funcionário, por favor!");
                            pr.horasTrabalhadas = Convert.ToInt16(Console.ReadLine());
                            Console.WriteLine("Digite o valor da hora trabalhada do funcionário, por favor!");
                            pr.valorHorasTrabalhadas = Convert.ToInt32(Console.ReadLine());
                            FolhaDePagamentoDAO.CadastrationPayRoll(pr);
                            if(pr.ToString() != null){
                                foreach (PayRoll item in FolhaDePagamentoDAO.ShowTheRoll())
                                {
                                    Console.WriteLine(item.anoAtual);
                                }
                            }
                                
                                Console.WriteLine("Houve algum problema!");
                            }else{
                            Console.WriteLine("Usuário não encontrado na base de dados!");
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
