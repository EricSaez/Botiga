using System.Net.Http.Headers;
using System.Runtime;

namespace Botiga_Virtual
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MenuPrincipal());
            MenuLlistat();
        }
        // MENÚS PRINCIPALS PER ESCOLLIR CARACTERÍSTIQUES DE BOTIGA O DE CISTELLA
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
        static void MenuLlistat()
        {
            int opcio;
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
                        MenuEscollirBotiga();
                        break;
                    case '2':
                        Console.Clear();
                        Console.WriteLine(MenuCistella());
                        MenuEscollirCistella();
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
        static void MenuEscollirBotiga()
        {
            int opcio;
            int nEl = 0;
            string[] producte = new string[5];
            double[] preu = new double[5];
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
                        AfegirProducte(producte, ref preu, ref nEl);
                        break;
                    case '2':
                        Console.Clear();
                        AfegirProducteS(producte, ref preu, ref nEl);
                        break;
                    case '3':
                        Console.Clear();
                        AmpliarTenda(ref producte, ref preu);
                        break;
                    case '4':
                        Console.Clear();
                        ModificarPreu(producte, ref preu);
                        break;
                    case '5':
                        Console.Clear();
                        ModificarProducte(producte);
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
                    case '9':
                        Console.Clear();
                        //BotigaToString();
                        break;
                    case 'T':
                        Console.Clear();
                        Console.WriteLine(MenuPrincipal());
                        MenuLlistat();
                        break;
                    case 't':
                        Console.Clear();
                        Console.WriteLine(MenuPrincipal());
                        MenuLlistat();
                        break;
                    case 'q':
                        break;
                    case 'Q':
                        break;

                }
            } while (opcio != 'Q' && opcio != 'q');

        }
        // MÉTODES BOTIGA
        static void AfegirProducte(string[] producte, ref double[] preu, ref int nEl)
        {
            Console.WriteLine("Introdueix el nom del producte a afegir");
            producte[nEl] = Console.ReadLine();
            Console.WriteLine("Introdueix el preu de " + producte[nEl]);
            preu[nEl] = Convert.ToDouble(Console.ReadLine());
            nEl++;
        }
        static void AfegirProducteS(string[] producte, ref double[] preu, ref int nEl)
        {
            Console.WriteLine("Per deixar d'afegir productes escriu -1");
            for (int i = 0; i < producte.Length; i++)
            {
                Console.WriteLine("Introdueix el nom del producte a afegir");
                producte[i] = Console.ReadLine();
                if (producte[i] == "-1") break;
                Console.WriteLine("Introdueix el preu de " + producte[i]);
                preu[i] = Convert.ToDouble(Console.ReadLine());
                if (preu[i] == -1) break;
                nEl++;
            }
        }
        static void Mostrar(string[] producte, double[] preu)
        {
            Console.WriteLine("Llistat de productes i preus");
            for (int i = 0; i < producte.Length; i++)
            {
                Console.Write("{0} ", "Nom: " + producte[i] + "Preu: " + preu[i]);
                Console.WriteLine();
            }
            Thread.Sleep(5000);
        }
        static void AmpliarTenda(ref string[] productes, ref double[] preus)
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
        }
        static void ModificarPreu(string[] productes, ref double[] preu)
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
        }
        static void ModificarProducte(string[] productes)
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
        static void MenuEscollirCistella()
        {
            int opcio;
            int nEl = 5;
            string[] producte = new string[nEl];
            double[] preu = new double[nEl];
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
                        ComprarProducte(producte, preu);
                        break;
                    case '2':
                        Console.Clear();
                        //ComprarProducteS();
                        break;
                    case '3':
                        Console.Clear();
                        //OrdenarCistella();
                        break;
                    case '4':
                        Console.Clear();
                        //CistellaToString();
                        break;
                    case 'T':
                        Console.Clear();
                        Console.WriteLine(MenuPrincipal());
                        MenuLlistat();
                        break;
                    case 't':
                        Console.Clear();
                        Console.WriteLine(MenuPrincipal());
                        MenuLlistat();
                        break;
                    case 'q':
                        break;
                    case 'Q':
                        break;

                }
            } while (opcio != 'Q' && opcio != 'q');
        }
        // METODES CISTELLA
        static void ComprarProducte(string[] producte, double[] preu)
        {
            Mostrar(producte, preu);
            string opcio = "";
            Console.WriteLine("Quin producte vols afegir");
            for (int i = 0; i < producte.Length; i++)
            {

            }
        }
    }
}