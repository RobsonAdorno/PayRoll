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
                        // Funcionario func = new Funcionario();

                        Console.WriteLine("Digite o CPF do funcionário!");
                        string cpfs = Console.ReadLine();

                        if (VendedorDAO.CadastrationCPF(cpfs))
                        {
                            Console.WriteLine("Seguinte CPF já está cadastrado: " + cpfs + "\nCujo nome do Funcionário é: ");
                        }
                        else
                        {
                            Console.WriteLine("Usuário não cadastrado!");
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
