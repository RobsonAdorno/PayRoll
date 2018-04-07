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

        public static bool CallThePayRoll(PayRoll pr)
        {

            if ((funcio.cpf) || (pr.anoAtual) || (pr.mesAtual) != null){


            }
        }



        public static void CalculatePayRoll(PayRoll p){


            ListOfPayRoll.Add(p);

        }
    }
}
