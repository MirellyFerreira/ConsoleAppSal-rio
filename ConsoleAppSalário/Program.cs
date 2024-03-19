using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSalário
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double s = 0;
            Console.WriteLine(" Qual a sua forma de contratação? Assalariado, Comissionado ou Horista: ");
            string fc = Console.ReadLine();

            switch (fc)
            {
                case ("Assalariado"):
                    Console.WriteLine("Qual o valor do seu salário bruto?: ");
                    double sb = double.Parse(Console.ReadLine());
                    Console.WriteLine("Qual o valor do desconto?: ");
                    double vd = double.Parse(Console.ReadLine());

                    s = sb - vd;
                    Console.WriteLine("o valor do seu salário é: "+ s);
                    break;

                case ("Comissionado"):
                    Console.WriteLine("Qual a quantidade de peças que você vendeu?: ");
                    double qp = double.Parse(Console.ReadLine());
                    Console.WriteLine("Qual o valor da comissão por peças?: ");
                    double cp = double.Parse(Console.ReadLine());

                    s = qp * cp;
                    Console.WriteLine("o valor do seu salário é: ",+ s);
                    break;

                case ("Horista"):
                    Console.WriteLine("Quanto você ganha por hora?: ");
                    double gp = double.Parse(Console.ReadLine());
                    Console.WriteLine("Quantas horas extras você fez?: ");
                    double he = double.Parse(Console.ReadLine());

                    s = gp * he;
                    Console.WriteLine("o valor do seu salário é: " + s);
                    break;

                    if (s <= 2000)
                    {
                        double sa = s - 7.5 / 100;
                        double ir = s - sa;
                        Console.WriteLine("Seu salário é: " + sa + " o valor do desconto é de: " + ir);
                    }
                    else if (s > 2000 && s <= 4000)
                    {
                        double sa = s - 12 / 100;
                        double ir = s - sa;
                        Console.WriteLine("Seu salário é: " + sa + " o valor do desconto é de: " + ir);
                    }
                    else 
                    {
                        double sa = s - 15 / 100;
                        double ir = s - sa;
                        Console.WriteLine("Seu salário é: " + sa + " o valor do desconto é de: " + ir);
                    }
              Console.ReadKey();
                     
                    
            }
        }


    }
}
