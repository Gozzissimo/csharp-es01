using System; 
    //riferimento alla libreria di base

namespace MyApp 
    // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args) //entry point
            //main è importante che ci sia, facendo doppio click sul file .exe fa lavorare il Main
        {   
            //namespace, classe, metodo
            System.Console.WriteLine("Programma che, inserendo due numeri, ne da il prodotto");

            //dobbiamo chiedere all'utente di inserire un primo numero
            Console.WriteLine("Inserisci il primo numero:");

            string sPrimoNumero;
            sPrimoNumero = Console.ReadLine();

            //dobbiamo chidere all'utente di inserire un secondo numero
            Console.WriteLine("Inserisci il secondo numero:");

            string sSecondoNumero;
            sSecondoNumero = Console.ReadLine();

            Console.WriteLine("Hai Inserito {0} e {1}", sPrimoNumero,
                   sSecondoNumero);

            //dobbiamo eseguire la moltiplicazione
            int iDivisione;
            int iPrimoNumero = Convert.ToInt32(sPrimoNumero);

            int iSecondoNumero = Convert.ToInt32(sSecondoNumero);

            iDivisione = iPrimoNumero * iSecondoNumero;

            //dobbiamo visualizzare a schermo il risultato ottenuto

            Console.WriteLine("Risultato: {0}", iDivisione);
            //int.TryParse(Console.ReadLine(), out iDivisione);
            //Environment.Exit(1);
        }
    }
}
