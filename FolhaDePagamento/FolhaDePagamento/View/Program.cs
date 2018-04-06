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
                        foreach (Funcionario func in VendedorDAO.Mostrar())
                        {
                            Console.WriteLine("CPF do funcionário: " + func.cpf);
                            Console.WriteLine("Nome do funcionário: " + func.nome);
                        }

                        break;

                    default:
                        Console.WriteLine("Opção Inválida!");
                        break;
                }
            } while (op.Equals("0"));


        }
    }
}
