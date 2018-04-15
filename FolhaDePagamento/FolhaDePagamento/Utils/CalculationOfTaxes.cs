using System;
using FolhaDePagamento.Model;
namespace FolhaDePagamento.Utils
{
    public class CalculationOfTaxes
    {
        public static double grossSalary;

        public static double deducion;

        public static double GrossSalary(int horasTrabalhadas, double valorHorasTrabalhadas)
        {
            int currentYear = DateTime.Now.Year;
            int currentMouth = DateTime.Now.Month;

            int daysInMouth = DateTime.DaysInMonth(currentYear, currentMouth);

            grossSalary = (horasTrabalhadas * valorHorasTrabalhadas) * daysInMouth;

            return grossSalary;

        }

        public static double IncomeTax(){
            double tax = 0.0;
            double netSalaryOfIT = 0.0;
           
            if(grossSalary <= 1903.98){

                deducion = grossSalary;
            }

            if (grossSalary >= 1903.99 && grossSalary <= 2826.65)
            {
                tax = (grossSalary * 0.75);
                netSalaryOfIT = (grossSalary - tax);
                deducion = tax - 142.80;

            }
            if (grossSalary >= 2826.66 && grossSalary <= 3751.05)
            {
                tax = (grossSalary * 0.15);
                netSalaryOfIT = (grossSalary - tax);
                deducion = tax - 354.80;
            }
            if (grossSalary >= 3751.06 && grossSalary <= 4664.68)
            {
                tax = (grossSalary * 0.225);
                netSalaryOfIT = (grossSalary - tax);
                deducion = tax - 636.13;
            }
            if (grossSalary > 4664.68)
            {
                tax = (grossSalary * 0.275);
                netSalaryOfIT = (grossSalary - tax);
                deducion = tax - 869.36;
            }
            return deducion;

        }

        public static double INSS(){
            double tax = 0.0;
            double netSalaryOfINSS;

            if (grossSalary <= 1659.38 )
            {
                tax = (grossSalary * 0.8);
                netSalaryOfINSS = (grossSalary - tax);
            }

            if (grossSalary >= 1659.39 && grossSalary <= 2765.66)
            {
                tax = (grossSalary * 0.9);
                netSalaryOfINSS = (grossSalary - tax);
            }

            if (grossSalary >= 2765.67 && grossSalary <= 5531.31)
            {
                tax = (grossSalary * 0.11);
                netSalaryOfINSS = (grossSalary - tax);
            }

            if (grossSalary >= 5531.32)
            {
                tax = (grossSalary - 608.44);
                netSalaryOfINSS = (grossSalary - tax);
            }
            return tax;
        }

        public static double ExtractionFGTS(){
            double tax = 0.0;
        
            tax = (grossSalary * 0.8);
            return tax;
        }

        public static double ShowNetSalary(double netSalaryOfIT,double netSalaryOfINSS){
            double NetSalary = netSalaryOfINSS - netSalaryOfIT ;

            return NetSalary;
        }
    }
}
