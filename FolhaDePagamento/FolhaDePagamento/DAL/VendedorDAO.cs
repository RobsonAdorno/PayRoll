using System;
using System.Collections.Generic;
using FolhaDePagamento.Model;

namespace FolhaDePagamento.DAL
{
    public class VendedorDAO
    {
        
        private static List<Funcionario> ListaFuncio = new List<Funcionario>();

        public static bool Cadastrar(Funcionario c){
            if (c.cpf.Contains(c.cpf))
            {
                return false;
            }
            ListaFuncio.Add(c);
            return true;

        }

        public static List<Funcionario> Mostrar(){

            return ListaFuncio;
        }
    }
}
