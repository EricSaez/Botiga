﻿using System.Runtime;

namespace Botiga_Virtual
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MenuLlistat());
            Menu();
        }
        static string MenuLlistat()
        {
            string TextMenu =
               "╔══════════════════════════════════════════════════╗\n" +
               "║                      * Botiga *                  ║ \n" +
               "╠══════════════════════════════════════════════════╣ \n" +
               "║              1) Afegir producte                  ║ \n" +
               "║              2) Afegir producteS                 ║ \n" +
               "║              3) Ampliar tenda                    ║ \n" +
               "║              4) Modificar preu                   ║ \n" +
               "║              5) Modificar producte               ║ \n" +
               "║              6) Ordenar producte                 ║ \n" +
               "║              7) Ordenar preus                    ║ \n" +
               "║              8) Mostrar                          ║ \n" +
               "║                                                  ║ \n" +
               "║              q) Sortir                           ║ \n" +
               "╚══════════════════════════════════════════════════╝ \n";

            return TextMenu;
        }
        static void Menu()
        {
            int opcio;
            int nEl = 5;
            string[] producte = new string[nEl];
            double[] preu = new double[nEl];
            do
            {
                Console.Clear();
                Console.Write(MenuLlistat());
                Console.WriteLine("(Recordem que la botiga té " + nEl + ". Ho ha de tenir en compter al hora d'afegir productes. Si vol ampliar la tenda premi 3)");
                Console.Write("Escull una opcio: ");
                opcio = Convert.ToChar(Console.ReadLine());
                switch (opcio)
                {
                    case '1':
                        Console.Clear();
                        Mostrar(producte, preu);
                        break;
                    case '2':
                        Console.Clear();
                        AfegirProducteS(producte, preu);
                        break;
                    case '3':
                        Console.Clear();
                        //AmpliarTenda(nEl);
                        break;
                    case '4':
                        Console.Clear();
                        //ModificarPreu();
                        break;
                    case '5':
                        Console.Clear();
                        //ModificarProducte();
                        break;
                    case '6':
                        Console.Clear();
                        //OrdenarProducte();
                        break;
                    case '7':
                        Console.Clear();
                        //OrdenarPreus();
                        break;
                    case '8':
                        Console.Clear();
                        Mostrar(producte, preu);
                        break;
                    case 'q':
                        break;
                    case 'Q':
                        break;

                }
            } while (opcio != 'Q' && opcio != 'q');

        }
        static void AfegirProducte(string producte, double preu)
        {
                Console.WriteLine("Introdueix el nom del producte a afegir");
                producte = Console.ReadLine();
                Console.WriteLine("Introdueix el preu de " + producte);
                preu = Convert.ToDouble(Console.ReadLine());
        }
        static void AfegirProducteS(string[] producte, double[] preu)
        {
            for (int i = 0; i < producte.Length; i++)
            {
                Console.WriteLine("Introdueix el nom del producte a afegir");
                producte[i] = Console.ReadLine();
                Console.WriteLine("Introdueix el preu de " + producte[i]);
                preu[i] = Convert.ToDouble(Console.ReadLine());
            }
        }
        static void Mostrar(string[] producte, double[] preu) 
        {
            Console.WriteLine("Llistat de productes i preus");
            for (int i = 0;i < producte.Length;i++)
            {
                Console.Write("{0} ", "Nom :" + producte[i] + "Preu:" + preu[i]);
                Console.WriteLine();
            }
        }
    }
}