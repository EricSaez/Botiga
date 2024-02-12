namespace Botiga_Virtual
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nEL = 1;
            string[] productes = new string [1];
            int[] preu = new int[productes.Length];
            afegirproducte1(ref productes, ref preu);
            static void afegirproducte1 (ref string[] productes, ref int[] preu)
            {
                productes = new string[productes.Length];
                string nom = " ";
                Console.WriteLine("Escriu el nom del producte que vols afegir");
                nom = Console.ReadLine();
                productes[productes.Length - 1] = nom;
                Console.WriteLine("Escriu el preu del producte");
                preu = new int [productes.Length];
                preu[productes.Length - 1] = Convert.ToInt32(Console.ReadLine());
            }
            mostrar(productes, preu);
            static void mostrar(string[] productes, int[] preu)
            {
                for (int i = 0; i < productes.Length; i++) 
                {
                    Console.Write(productes[i] + ": " + preu[i] + "euros");
                    Console.WriteLine();
                }
            }
            modificarpreu(productes, ref preu);
            static void modificarpreu(string[] productes, ref int[]preu)
            {
                string nom;
                Console.WriteLine("El preu de quin producte vols modificar?");
                for (int i = 0;i < productes.Length;i++) 
                {
                    Console.Write(productes[i]+ "  ");
                }
                Console.WriteLine();
                nom = Console.ReadLine();
                for (int i = 0;i < productes.Length; i++) 
                { 
                    if (productes[i] == nom)
                    {
                        Console.WriteLine("El preu original era de: " + preu[i]);
                        Console.WriteLine("Quin preu vols afegir ara?");
                        preu[i] = Convert.ToInt32(Console.ReadLine());
                    }
                }
            }
            AmpliarTenda(ref productes, ref preu);
            static void AmpliarTenda(ref string[] productes, ref int[] preus)
            {
                int numero;
                Console.WriteLine("La tenda ara mateix té una capacitat de " + productes.Length + " producte/s.");
                Console.WriteLine("Quants elements vols ampliar la cistella?");
                numero = Convert.ToInt32(Console.ReadLine());
                string[] aux = new string[productes.Length + numero];
                int[] auxpreus = new int[productes.Length + numero];
                for (int i = 0; i < productes.Length; i++)
                {
                    aux[i] = productes[i];
                    auxpreus[i] = preus[i];
                }
                productes = aux;
                preus = auxpreus;
            }
        }
    }
}