using System;
using FolhaDePagamento.Model;
using FolhaDePagamento.DAL;
using FolhaDePagamento.Utils;

namespace FolhaDePagamento.View
{
    public class FuncionarioView
    {


        public static void Cadastrar()
        {
            Funcionario func = new Funcionario();
            Console.WriteLine("Digite o seu nome");
            func.nome = Console.ReadLine();
            Console.WriteLine("Digite o seu CPF");
            func.cpf = Console.ReadLine();
            // Aqui estamos fazendo uma dupla verificação.O metodo "Cpf()" retorna true ou false.Se for true quer dizer que o seu cpf esta correto. 
            //Mas logo depois ele entra no método "Cadastrar()" e verifica se já não tem um CPF igual na Lista q esta na FuncionarioDAO
            if (ValidadorDeCPF.Cpf(func.cpf))
            {
                if (VendedorDAO.Cadastrar(func))
                {
                    Console.WriteLine("Cadastro efetuado com sucesso!");
                    //Se der boa nas duas verificações ele entra aqui.
                }else{
                    Console.WriteLine("Erro! CPF já cadastrado!");
                    //Aqui está especificando o erro, mas por medidas de segurança não é recomendado, mas para debugar é melhor...
                }
                   
                }else{
                    Console.WriteLine("CPF Inválido!");
                }
           
            Console.WriteLine("CLique para voltar ao menu!");
            Console.ReadKey();
            }

        }
    }

