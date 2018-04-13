﻿using System;
using FolhaDePagamento.Model;
using FolhaDePagamento.DAL;
using System.Collections.Generic;

namespace FolhaDePagamento.DAL
{
    public class FolhaDePagamentoDAO
    {

        private static HashSet<PayRoll> ListOfPayRoll = new HashSet<PayRoll>();


        VendedorDAO ahh = new VendedorDAO();

        public static void CadastrarCPF(PayRoll cpf){
            ListOfPayRoll.Add(cpf);
        }

        public static PayRoll CallThePayRoll(PayRoll pr)
        {
            Funcionario funcio = new Funcionario();
            foreach (PayRoll item in ListOfPayRoll)
            {   
                if (item.anoAtual.Equals(pr.anoAtual) || item.mesAtual.Equals(pr.mesAtual) || item.Funcionario.cpf.Equals(pr.Funcionario.cpf))
                {

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

        public static HashSet<PayRoll> ShowTheRoll(){
            return ListOfPayRoll;
        }
    }
}
