using System;
using FolhaDePagamento.Model;
using FolhaDePagamento.DAL;

namespace FolhaDePagamento.View
{
    public class FuncionarioView
    {
        

        public static void Cadastrar()
        {
            Funcionario func = new Funcionario();
            func = new Funcionario();
            func = new Funcionario();
            Console.WriteLine("Digite o seu nome");
            func.nome = Console.ReadLine();
            Console.WriteLine("Digite o seu CPF");
            func.cpf = Console.ReadLine();
            VendedorDAO.Cadastrar(func);
            Console.WriteLine("CLique para voltar ao menu!");
            Console.ReadKey();
        }
       
    }
}
