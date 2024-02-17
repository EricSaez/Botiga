using System.Net.Http.Headers;
using System.Runtime;
using System.Text.Json;

namespace Botiga_Virtual
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nEl = 0;
            string[] producte = {"", "", "", "", ""};
            double[] preu = new double[5];
            string[] productesTotal = { "", "", "", "", "" };
            double[] preusTotal = new double[5];
            int sumatotalpreu = 0;
            Console.WriteLine(MenuPrincipal());
            MenuLlistat(ref producte, ref preu, ref nEl, ref productesTotal, ref preusTotal);

            // MENÚS PRINCIPALS PER ESCOLLIR CARACTERÍSTIQUES DE BOTIGA O DE CISTELLA
            static void Return(ref string[] producte, ref double[] preu, ref int nEl, ref string[] productesTotal, ref double[] preusTotal)
            {
                int i = 5;
                while (i != 0)
                {
                    Console.Write("\r");
                    Console.Write($"Tornant al menu {i}s");
                    Thread.Sleep(1000);
                    i--;
                }
                Console.WriteLine(MenuPrincipal());
                MenuLlistat(ref producte, ref preu, ref nEl, ref productesTotal, ref preusTotal);
            }
            static string MenuPrincipal()
            {
                string MenuPrincipal =
                   "╔══════════════════════════════════════════════════╗\n" +
                   "║                   * Benvingut *                  ║ \n" +
                   "╠══════════════════════════════════════════════════╣ \n" +
                   "║      1) Anar a característiques de la botiga     ║ \n" +
                   "║      2) Anar a característiques de la cistella   ║ \n" +
                   "║      q) Sortir                                   ║ \n" +
                   "╚══════════════════════════════════════════════════╝ \n";
                return MenuPrincipal;

            }
            static void MenuLlistat(ref string[] producte, ref double[] preu, ref int nEl, ref string[] productesTotal, ref double[] preusTotal)
            {
                char opcio;
                do
                {
                    Console.Clear();
                    Console.WriteLine(MenuPrincipal());
                    Console.Write("Escull una opcio: ");
                    opcio = Convert.ToChar(Console.ReadLine());
                    switch (opcio)
                    {
                        case '1':
                            Console.Clear();
                            Console.WriteLine(MenuBotiga());
                            MenuEscollirBotiga(ref producte, ref preu, ref nEl, ref productesTotal, ref preusTotal);
                            break;
                        case '2':
                            Console.Clear();
                            Console.WriteLine(MenuCistella());
                            MenuEscollirCistella(ref producte, ref preu, ref nEl, ref productesTotal, ref preusTotal);
                            break;
                        case 'q':
                            break;
                        case 'Q':
                            break;
                    }
                } while (opcio != 'Q' && opcio != 'q');

            }
            // PRIMER MENÚ DE BOTIGA
            static string MenuBotiga()
            {
                string TextMenu =
                   "╔══════════════════════════════════════════════════╗\n" +
                   "║                   * Botiga *                     ║ \n" +
                   "╠══════════════════════════════════════════════════╣ \n" +
                   "║              1) Afegir producte                  ║ \n" +
                   "║              2) Afegir producteS                 ║ \n" +
                   "║              3) Ampliar tenda                    ║ \n" +
                   "║              4) Modificar preu                   ║ \n" +
                   "║              5) Modificar producte               ║ \n" +
                   "║              6) Ordenar producte                 ║ \n" +
                   "║              7) Ordenar preus                    ║ \n" +
                   "║              8) Mostrar                          ║ \n" +
                   "║              9) BotigaToString                   ║ \n" +
                   "║              T) Anar a menu anterior             ║ \n" +
                   "║                                                  ║ \n" +
                   "║              q) Sortir                           ║ \n" +
                   "╚══════════════════════════════════════════════════╝ \n";

                return TextMenu;
            }
            // ESCULL L'OPCIÓ QUE VOLGUIS DE LA BOTIGA
            static void MenuEscollirBotiga(ref string[] producte, ref double[] preu, ref int nEl, ref string[] productesTotal, ref double[] preusTotal)
            {
                char opcio;
                do
                {
                    Console.Clear();
                    Console.Write(MenuBotiga());
                    Console.WriteLine("(Ara la botiga té " + nEl + " productes afegits i té " + producte.Length + " de capacitat màxima" + ". Ho has de tenir en compte a l'hora d'afegir productes. Si vol ampliar la tenda premi 3)");
                    Console.Write("Escull una opcio: ");
                    opcio = Convert.ToChar(Console.ReadLine());
                    switch (opcio)
                    {
                        case '1':
                            Console.Clear();
                            AfegirProducte(ref producte, ref preu, ref nEl, ref productesTotal, ref preusTotal);
                            break;
                        case '2':
                            Console.Clear();
                            AfegirProducteS(ref producte, ref preu, ref nEl, ref productesTotal, ref preusTotal);
                            break;
                        case '3':
                            Console.Clear();
                            AmpliarTenda(ref producte, ref preu, ref nEl, ref productesTotal, ref preusTotal);
                            break;
                        case '4':
                            Console.Clear();
                            ModificarPreu(ref producte, ref preu, ref nEl, ref productesTotal, ref preusTotal);
                            break;
                        case '5':
                            Console.Clear();
                            ModificarProducte(ref producte, ref preu, ref nEl, ref productesTotal, ref preusTotal);
                            break;
                        case '6':
                            Console.Clear();
                            OrdenarProducte(ref producte, ref preu, ref nEl, ref productesTotal, ref preusTotal);
                            break;
                        case '7':
                            Console.Clear();
                            OrdenarPreu(ref producte, ref preu, ref nEl, ref productesTotal, ref preusTotal);
                            break;
                        case '8':
                            Console.Clear();
                            Mostrar(ref producte, ref preu, ref nEl, ref productesTotal, ref preusTotal);
                            break;
                        case '9':
                            Console.Clear();
                            BotigaToString(ref producte, ref preu, ref nEl, ref productesTotal, ref preusTotal);
                            break;
                        case 'T':
                            Console.Clear();
                            Console.WriteLine(MenuPrincipal());
                            MenuLlistat(ref producte, ref preu, ref nEl, ref productesTotal, ref preusTotal);
                            break;
                        case 't':
                            Console.Clear();
                            Console.WriteLine(MenuPrincipal());
                            MenuLlistat(ref producte, ref preu, ref nEl, ref productesTotal, ref preusTotal);
                            break;
                        case 'q':
                            break;
                        case 'Q':
                            break;

                    }
                } while (opcio != 'Q' && opcio != 'q');

            }
            // MÉTODES BOTIGA
            static void AfegirProducte(ref string[] producte, ref double[] preu, ref int nEl, ref string[] productesTotal, ref double[] preusTotal)
            {
                Console.WriteLine("Introdueix el nom del producte a afegir");
                producte[nEl] = Console.ReadLine();
                Console.WriteLine("Introdueix el preu de " + producte[nEl]);
                preu[nEl] = Convert.ToDouble(Console.ReadLine());
                nEl++;
                Console.WriteLine("Producte afegit amb éxit!");
                Return(ref producte, ref preu, ref nEl, ref productesTotal, ref preusTotal);
            }
            static void AfegirProducteS(ref string[] producte, ref double[] preu, ref int nEl, ref string[] productesTotal, ref double[] preusTotal)
            {
                Console.WriteLine("Per deixar d'afegir productes escriu -1");
                string afegit = " ";
                Console.WriteLine("Introdueix el nom del producte a afegir");
                afegit = Console.ReadLine();
                for (int i = 0; (i < producte.Length || afegit != "-1"); i++)
                {
                    if (afegit == "-1") return;
                    producte[i] = afegit;
                    Console.WriteLine("Introdueix el preu de " + producte[i]);
                    preu[i] = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Introdueix el nom del producte a afegir");
                    afegit = Console.ReadLine();
                    if (preu[i] == -1) return;
                    nEl++;
                }
                Return(ref producte, ref preu, ref nEl, ref productesTotal, ref preusTotal);
            }
            static void AmpliarTenda(ref string[] productes, ref double[] preus, ref int nEl, ref string[] productesTotal, ref double[] preusTotal)
            {
                int numero;
                Console.WriteLine("La tenda ara mateix té una capacitat de " + productes.Length + " producte/s.");
                Console.WriteLine("Quants elements vols ampliar la cistella?");
                numero = Convert.ToInt32(Console.ReadLine());
                string[] aux = new string[productes.Length + numero];
                double[] auxpreus = new double[productes.Length + numero];
                for (int i = 0; i < productes.Length; i++)
                {
                    aux[i] = productes[i];
                    auxpreus[i] = preus[i];
                }
                productes = aux;
                preus = auxpreus;
                Return(ref productes, ref preus, ref nEl, ref productesTotal, ref preusTotal);
            }
            static void OrdenarProducte(ref string[] productes, ref double[] preus, ref int nEl, ref string[] productesTotal, ref double[] preusTotal)
            {
                int nEle = productes.Length;

                for (int i = 0; i < nEl - 1; i++)
                {
                    for (int j = i + 1; j < nEl; j++)
                    {
                        if (productes[i].CompareTo(productes[j]) > 0)
                        {
                            string tempProducte = productes[i];
                            productes[i] = productes[j];
                            productes[j] = tempProducte;

                            double tempPreu = preus[i];
                            preus[i] = preus[j];
                            preus[j] = tempPreu;
                        }
                    }
                }
                Console.WriteLine("Productes per ordre alfabétic ordenats correctament");
                Return(ref productes, ref preus, ref nEl, ref productesTotal, ref preusTotal);
            }
            static void OrdenarPreu(ref string[] productes, ref double[] preus, ref int nEl, ref string[] productesTotal, ref double[] preusTotal)
            {
                bool intercanvi;
                int nEle = productes.Length;
                do
                {
                    intercanvi = false;
                    for (int i = 0; i < nEle - 1; i++)
                    {
                        if (preus[i] > preus[i + 1])
                        {
                            string posicioproducte = productes[i];
                            productes[i] = productes[i + 1];
                            productes[i + 1] = posicioproducte;

                            double posiciopreu = preus[i];
                            preus[i] = preus[i + 1];
                            preus[i + 1] = posiciopreu;

                            intercanvi = true;
                        }
                    }
                    nEle--;
                } while (intercanvi);
                Console.WriteLine("Productes per preu ordenats correctament");
                Return(ref productes, ref preus, ref nEl, ref productesTotal, ref preusTotal);
            }
            static void ModificarPreu(ref string[] productes, ref double[] preu, ref int nEl, ref string[] productesTotal, ref double[] preusTotal)
            {
                string nom;
                Console.WriteLine("El preu de quin producte vols modificar?");
                for (int i = 0; i < productes.Length; i++)
                {
                    Console.Write(productes[i] + "  ");
                }
                Console.WriteLine();
                nom = Console.ReadLine();
                for (int i = 0; i < productes.Length; i++)
                {
                    if (productes[i] == nom)
                    {
                        Console.WriteLine("El preu original era de: " + preu[i]);
                        Console.WriteLine("Quin preu vols afegir ara?");
                        preu[i] = Convert.ToInt32(Console.ReadLine());
                    }
                }
                Return(ref productes, ref preu, ref nEl, ref productesTotal, ref preusTotal);
            }
            static void ModificarProducte(ref string[] productes, ref double[] preu, ref int nEl, ref string[] productesTotal, ref double[] preusTotal)
            {
                string nom;
                Console.WriteLine("El nom de quin producte vols modificar?");
                for (int i = 0; i < productes.Length; i++)
                {
                    Console.Write(productes[i] + "  ");
                }
                Console.WriteLine();
                nom = Console.ReadLine();
                for (int i = 0; i < productes.Length; i++)
                {
                    if (productes[i] == nom)
                    {
                        Console.WriteLine("Quin nom vols que tingui ara?");
                        productes[i] = Console.ReadLine();
                        Console.WriteLine(nom + " ha pasat a ser " + productes[i]);
                    }
                }
                Return(ref productes, ref preu, ref nEl, ref productesTotal, ref preusTotal);
            }
            static void Mostrar(ref string[] producte, ref double[] preu, ref int nEl, ref string[] productesTotal, ref double[] preusTotal)
            {
                Console.WriteLine("Llistat de productes i preus");
                for (int i = 0; i < producte.Length; i++)
                {
                    if (producte[i] != "")
                    {
                        Console.Write("{0} ", "Nom: " + producte[i] + "   Preu: " + preu[i]);
                        Console.WriteLine();
                    }
                }
                Return(ref producte, ref preu, ref nEl, ref productesTotal, ref preusTotal);
            }
            static void BotigaToString(ref string[] producte, ref double[] preu, ref int nEl, ref string[] productesTotal, ref double[] preusTotal)
            {
                Console.WriteLine("Llistat de productes i preus");
                for (int i = 0; i < producte.Length; i++)
                {
                    Console.Write("{0} ", "Nom: " + producte[i] + "   Preu: " + preu[i]);
                    Console.WriteLine();
                }
                Console.WriteLine("Actualment tenim " + nEl + " a la botiga");
                Console.WriteLine("Encara podem emplenar la nostra botiga amb: " + (producte.Length - nEl));
                Return(ref producte, ref preu, ref nEl, ref productesTotal, ref preusTotal);
            }
            // MENU CISTELLA
            static string MenuCistella()
            {
                string TextMenu =
                "╔══════════════════════════════════════════════════╗\n" +
                "║                   * Cistella *                   ║ \n" +
                "╠══════════════════════════════════════════════════╣ \n" +
                "║              1) Comprar Producte                 ║ \n" +
                "║              2) Comprar ProducteS                ║ \n" +
                "║              3) Ordenar Cistella                 ║ \n" +
                "║              4) Mostrar Cistella                 ║ \n" +
                "║              4) CistellaToString                 ║ \n" +
                "║              T) Tornar a menu anterior           ║ \n" +
                "║                                                  ║ \n" +
                "║              q) Sortir                           ║ \n" +
                "╚══════════════════════════════════════════════════╝ \n";
                return TextMenu;
            }
            // ESCULL OPCIÓ CISTELLA
            static void MenuEscollirCistella(ref string[] producte, ref double[] preu, ref int nEl, ref string[] productesTotal, ref double[] preusTotal)
            {
                char opcio;
                do
                {
                    Console.Clear();
                    Console.Write(MenuCistella());
                    Console.Write("Escull una opcio: ");
                    opcio = Convert.ToChar(Console.ReadLine());
                    switch (opcio)
                    {
                        case '1':
                            Console.Clear();
                            ComprarProducte(ref producte, ref preu, ref nEl, ref productesTotal, ref preusTotal);
                            break;
                        case '2':
                            Console.Clear();
                            ComprarProducteS(ref producte, ref preu, ref nEl, ref productesTotal, ref preusTotal);
                            break;
                        case '3':
                            Console.Clear();
                            OrdenarCistella(ref producte, ref preu, ref nEl, ref productesTotal, ref preusTotal);
                            break;
                        case '4':
                            Console.Clear();
                            //CistellaToString();
                            break;
                        case '5':
                            Console.Clear();
                            //CompraTotal(ref producte, ref preu, ref nEl);
                            break;
                        case 'T':
                            Console.Clear();
                            Console.WriteLine(MenuPrincipal());
                            MenuLlistat(ref producte, ref preu, ref nEl, ref productesTotal, ref preusTotal);
                            break;
                        case 't':
                            Console.Clear();
                            Console.WriteLine(MenuPrincipal());
                            MenuLlistat(ref producte, ref preu, ref nEl, ref productesTotal, ref preusTotal);
                            break;
                        case 'q':
                            break;
                        case 'Q':
                            break;

                    }
                } while (opcio != 'Q' && opcio != 'q');
            }
            // METODES CISTELLA
            static void ComprarProducte(ref string[] producte, ref double[] preu, ref int nEl, ref string[] productesTotal, ref double[] preustotal, ref int sumatotal)
            {
                MostrarAux(ref producte, ref preu, ref nEl);
                Console.WriteLine("Quin producte vols afegir a la cistella?");
                string opcio = Console.ReadLine();
                for (int i = 0; i < nEl; i++)
                {
                    if (producte[i] == opcio)
                    {
                        Console.WriteLine("Producte afegit a la cistella: " + producte[i]);
                        productesTotal[i] = producte[i];
                        preustotal[i] = 
                    }
                }
                Return(ref producte, ref preu, ref nEl, ref productesTotal, ref preustotal);
            }
            // Aquest auxiliar només està fet per que quan cridem Mostrar desde ComprarProducte no salti el Return
            static void MostrarAux(ref string[] producte, ref double[] preu, ref int nEl)
            {
                Console.WriteLine("Llistat de productes i preus");
                for (int i = 0; i < producte.Length; i++)
                {
                    if (producte[i] != "")
                    {
                        Console.Write("{0} ", "Nom: " + producte[i] + "   Preu: " + preu[i]);
                        Console.WriteLine();
                    }
                }
            }
            static void ComprarProducteS(ref string[] producte, ref double[] preu, ref int nEl, ref string[] productesTotal, ref double[] preusTotal)
            {
                MostrarAux(ref producte, ref preu, ref nEl);
                Console.WriteLine("Per deixar d'afegir productes escriu -1");
                string afegit = " ";
                Console.WriteLine("Introdueix el nom del producte a afegir");
                afegit = Console.ReadLine();
                for (int i = nEl; (i < producte.Length && afegit != "-1"); i++)
                {
                    if (afegit == "-1") break;
                    producte[i] = afegit;
                    Console.WriteLine("Introdueix el preu de " + producte[i]);
                    preu[i] = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Introdueix el nom del producte a afegir");
                    afegit = Console.ReadLine();
                    if (preu[i] == -1) break;
                    nEl++;
                }
                Return(ref producte, ref preu, ref nEl, ref productesTotal, ref preusTotal);
            }
            static void OrdenarCistella(ref string[] producte, ref double[] preu, ref int nEl, ref string[] productesTotal, ref double[] preusTotal)
            {
                for (int i = 0; i < nEl - 1; i++)
                {
                    for (int j = i + 1; j < nEl; j++)
                    {
                        if (producte[i].CompareTo(producte[j]) > 0)
                        {
                            string tempProducte = producte[i];
                            producte[i] = producte[j];
                            producte[j] = tempProducte;

                            double tempPreu = preu[i];
                            preu[i] = preu[j];
                            preu[j] = tempPreu;
                        }
                    }
                }
                Console.WriteLine("Productes per ordre alfabétic ordenats correctament");
                Return(ref producte, ref preu, ref nEl, ref productesTotal, ref preusTotal);
            }
            static void CompraTotal(string[] productesCistella, double[] preusCistella, int nElCistella)
            {
                Console.WriteLine("Cistella:");
                for (int i = 0; i < nElCistella; i++)
                {
                    Console.WriteLine("Producte: " + productesCistella[i] + "  Preu: " + preusCistella[i]);
                }
                Console.WriteLine("Preu Total: ");
            }


        }

    }
}
