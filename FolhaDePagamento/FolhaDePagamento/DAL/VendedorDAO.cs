using System;
using System.Collections.Generic;
using FolhaDePagamento.Model;

namespace FolhaDePagamento.DAL
{
    public class VendedorDAO
    {
        
        private static List<Funcionario> ListaFuncio = new List<Funcionario>();

        public static Funcionario CallEmployee(Funcionario func){
            foreach (Funcionario Emp  in ListaFuncio)
            {
                if (Emp.cpf.Equals(func.cpf))
                {
                    return Emp;
                }
            }
            return null;
        }


        public static bool Cadastrar(Funcionario c){
            if (CallEmployee(c) != null)
            {
                return false;
            }
            ListaFuncio.Add(c);
            return true;

        }

        public static List<Funcionario> Mostrar(){

            return ListaFuncio;
        }

        public static bool CadastrationCPF(string cpf){

            foreach (Funcionario func in ListaFuncio)
            {
                if (cpf.Equals(func.cpf)){
                    
                    return true;
                }
            }
            return false;
        }
    }
}
