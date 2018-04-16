using System;
using FolhaDePagamento.Model;
using FolhaDePagamento.DAL;
using System.Collections.Generic;

namespace FolhaDePagamento.DAL
{
    public class FolhaDePagamentoDAO
    {

        private static HashSet<PayRoll> ListOfPayRoll = new HashSet<PayRoll>();


        VendedorDAO ahh = new VendedorDAO();

        public static bool CallInformation(string cpf, int mesAtual, int anoAtual){
            foreach (PayRoll i in ListOfPayRoll)
            {
                if(cpf.Equals(i.Funcionario.cpf) || (mesAtual.Equals(i.mesAtual)) || (anoAtual.Equals(i.anoAtual))){

                    return true;
                }
            }
            return false;
        }

        public static PayRoll CallThePayRoll(PayRoll pr)
        {
            foreach (PayRoll item in ListOfPayRoll)
            {
                if (item.anoAtual.Equals(pr.anoAtual) || item.mesAtual.Equals(pr.mesAtual) || item.Funcionario.cpf.Equals(pr.Funcionario.cpf))
                {

                    return item;

                }

             

            }
            return null;
        }

        public static HashSet<PayRoll> CheckingData(int MesAtual, int AnoAtual){
            
            foreach (PayRoll p  in ListOfPayRoll)
            {
                if (p.mesAtual.Equals(MesAtual) && (p.anoAtual.Equals(AnoAtual))){

                    return ListOfPayRoll;

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
