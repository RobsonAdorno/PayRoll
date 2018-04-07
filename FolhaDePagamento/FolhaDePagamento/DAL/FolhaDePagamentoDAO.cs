using System;
using FolhaDePagamento.Model;
using FolhaDePagamento.DAL;
using System.Collections.Generic;

namespace FolhaDePagamento.DAL
{
    public class FolhaDePagamentoDAO
    {

        private static List<PayRoll> ListOfPayRoll = new List<PayRoll>();

        Funcionario funcio = new Funcionario();
        VendedorDAO ahh = new VendedorDAO();

        public static PayRoll CallThePayRoll(PayRoll pr)
        {

            foreach (PayRoll item in ListOfPayRoll)
            {

                if (item.anoAtual.Equals(pr.anoAtual) || item.mesAtual.Equals(pr.mesAtual) || item.Funcionario.cpf.Equals(pr.Funcionario.cpf))
                {
                    Console.WriteLine(item);
                    return item;

                }

            }
            return null;
        }



        public static bool CadastrationPayRoll(PayRoll p)
        {

            if (CallThePayRoll(p) != null)
            {
                return false;
            }
            ListOfPayRoll.Add(p);
            return true;

        }

        public static List<PayRoll> ShowTheRoll(){
            return ListOfPayRoll;
        }
    }
}
