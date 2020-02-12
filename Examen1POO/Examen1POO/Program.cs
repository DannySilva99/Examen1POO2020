using System;

namespace Examen1POO
{
    class Program
    {
        static void Main(string[] args)
        {
            string NombreCompleto, GradoAcadem;
            double NumProf,Faltas,HrsDeClase;


            Console.WriteLine("Numero del profesor: ");
            NumProf = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nombre del profesor: ");
            NombreCompleto = Console.ReadLine();
            Console.WriteLine("Grado academico: ");
            GradoAcadem = Console.ReadLine();
            Console.WriteLine("Faltas a la quincena: ");
            Faltas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Horas de clase: ");
            HrsDeClase = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("------------------------------------------------------------------------------------");
            Console.WriteLine("                                  Recibo de pago                                    ");
            Console.WriteLine("------------------------------------------------------------------------------------");
            Console.WriteLine("Numero del profesor: " + NumProf);
            Console.WriteLine("Nombre completo: " + NombreCompleto);
            Console.WriteLine("Grado academico: " + GradoAcadem);
            Console.WriteLine("Faltas: " + Faltas);
            Console.WriteLine("Horas de clase: " + HrsDeClase);
            Sueldo(1, 2, 3);
            if(Faltas<(HrsDeClase)*.50)
            {
                Console.WriteLine("Pase por su cheque a coordinacion ");
               
            }
            else
            {
                Console.WriteLine("Su cheque sera retenido consecuente de las faltas que registra");
            }
            Console.ReadKey();

        }
        static double Sueldo(double PagoXHora, double HDCXQuin, double falta)
        {
            double SueldoFinal;
            Console.WriteLine("Horas de clase tiene a la quincena: ");
            HDCXQuin = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Salario por hora: ");
            PagoXHora = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Faltas a la quincena: ");
            falta = Convert.ToDouble(Console.ReadLine());
            falta = falta * 100;
            SueldoFinal = (HDCXQuin * PagoXHora) - falta;
            Console.WriteLine("Su sueldo final es de: --------------------------------------------------- " + SueldoFinal + "$");
            return SueldoFinal;
        }
        
    }
}
