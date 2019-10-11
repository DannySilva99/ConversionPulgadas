using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionPulgadas
{
    class Principal
    {
        double Valor, Valorf;
        Conversion Con = new Conversion();
        public void Menu()
        {
            int Opc;
            Console.WriteLine("Que operacion desea realizar? ");
            Console.WriteLine("1.-Milimetros a metros ");
            Console.WriteLine("2.-Metros a pulgadas ");
            Console.WriteLine("3.-Litros a mililitros ");
            Console.WriteLine("4.-Salir ");
            Opc = Convert.ToInt32(Console.ReadLine());
            if (Opc != 4) 
                {
                switch (Opc)
                {
                    case 1:
                        Console.WriteLine("Usted selecciono convertir milimetros a metros");
                        Console.WriteLine("ingrese los valores que desea convertir: ");
                        Valor = Convert.ToDouble(Console.ReadLine());
                        Con.Convertir(Valor);
                        Console.WriteLine(Valor.ToString() + " Cm= " + Valorf.ToString() + " Metros ");
                        break;
                    case 2:
                        Console.WriteLine("Usted selecciono convertir Metros a Pulgadas");
                        Console.WriteLine("ingrese los valores que desea convertir: ");
                        Valor = Convert.ToDouble(Console.ReadLine());
                        Valorf = Con.Convertir(Valor, Opc);
                        Console.WriteLine(Valor.ToString() + " Metros= " + Valorf.ToString() + " Pulgadas ");
                        break;
                    case 3:
                        Console.WriteLine("Usted selecciono convertir Litros a mililitros");
                        Console.WriteLine("ingrese los valores que desea convertir: ");
                        Valor = Convert.ToDouble(Console.ReadLine());
                        Valorf = Con.Convertir(Valor, Opc, Opc);
                        Console.WriteLine(Valor.ToString() + " Litros= " + Valorf.ToString() + " Mililitros ");
                        break;
                }
                Menu();
            }         
            Console.ReadKey();
        }
    }
}
