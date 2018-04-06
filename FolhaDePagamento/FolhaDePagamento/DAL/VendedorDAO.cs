using System;
using System.Collections.Generic;
using FolhaDePagamento.Model;

namespace FolhaDePagamento.DAL
{
    public class VendedorDAO
    {
        
        private static List<Funcionario> ListaFuncio = new List<Funcionario>();

        public static void Cadastrar(Funcionario c){

            ListaFuncio.Add(c);

        }

        public static List<Funcionario> Mostrar(){

            return ListaFuncio;
        }
    }
}
