using System;
using FolhaDePagamento.Model;
namespace FolhaDePagamento.Utils
{
    public class CalculationOfTaxes
    {
        public static double grossSalary;

        public static double deducion;
        public static double deducion2;

        public static double GrossSalary(int horasTrabalhadas, double valorHorasTrabalhadas)
        {
            int currentYear = DateTime.Now.Year;
            int currentMouth = DateTime.Now.Month;

            int daysInMouth = DateTime.DaysInMonth(currentYear, currentMouth);

            grossSalary = (horasTrabalhadas * valorHorasTrabalhadas) * daysInMouth;

            return grossSalary;

        }

        public static double IncomeTax(){
            if(grossSalary <= 1903.98){

                deducion = grossSalary;
            }

            if (grossSalary >= 1903.99 && grossSalary <= 2826.65)
            {
                deducion = (grossSalary * 0.075) - 142.80;
              
            }
            if (grossSalary >= 2826.66 && grossSalary <= 3751.05)
            {
                deducion = (grossSalary * 0.15) - 354.80;
            }
            if (grossSalary >= 3751.06 && grossSalary <= 4664.68)
            {
                deducion = (grossSalary * 0.225)- 636.13;
            }
            if (grossSalary > 4664.68)
            {
                deducion = (grossSalary * 0.275) - 869.36;
            }
            return deducion;

        }

        public static double INSS(){
           

            if (grossSalary <= 1659.38 )
            {
                deducion2 = (grossSalary * 0.08);

            }

            if (grossSalary >= 1659.39 && grossSalary <= 2765.66)
            {
                deducion2 = (grossSalary * 0.09);
            }

            if (grossSalary >= 2765.67 && grossSalary <= 5531.31)
            {
                deducion2 = (grossSalary * 0.11);
            }

            if (grossSalary >= 5531.32)
            {
                deducion2 = (grossSalary - 608.44);
              
            }
            return deducion2;
        }

        public static double ExtractionFGTS(){
            double tax = 0f;
        
            tax = (grossSalary * 0.08);
            return tax;
        }

        public static double ShowNetSalary(){
            double NetSalary = (grossSalary - deducion);
            NetSalary = (NetSalary - deducion2);

            return NetSalary;
        }
    }
}
