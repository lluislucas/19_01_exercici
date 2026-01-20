using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digues el nom del producte");
        string nom = Console.ReadLine();
        
        Console.WriteLine("Digues el preu del producte");
        double preu = double.Parse(Console.ReadLine());
        
        Console.WriteLine("Digues el descompte del producte");
        double descompte = double.Parse(Console.ReadLine());
        
        Console.WriteLine(CalcularPreuAmbIVA(preu));
        
        Console.WriteLine(CalcularPreuAmbDescompte(descompte, preu));
        
        Console.WriteLine(EsPreuSuperiorACinquanta(preu));

       MostrarInformacio(nom, preu, descompte); //no funciona

    }

    static double CalcularPreuAmbIVA(double preu)
    {
        return preu * 1.21;
        
        /* double preu_ambIVA = preu 1.21
         return preu_ambIVA;*/
    }

    static double CalcularPreuAmbDescompte(double descompte, double preu)
    {
        return preu * (1 - (descompte / 100)); 
    }

    static string EsPreuSuperiorACinquanta(double preu) // he modificat pq contesti si o no
    {

        //return preu > 50;

        bool es_superior = false;
        string resposta;
        
        if (preu > 50)
        {
            es_superior = true;
             resposta = "si";
        }
        else
        {
             resposta = "no";
        }

        return resposta;
    }
    

    static void MostrarInformacio(string nom, double preu, double descompte) //no funciona
    {
        Console.WriteLine("----Informació producte----");
        Console.WriteLine($"Nom: {nom}");
        Console.WriteLine($"Preu base: {preu}€");
        Console.WriteLine($"Preu amb IVA: {CalcularPreuAmbIVA(preu)}€");
        Console.WriteLine($"Preu amb descompte: {CalcularPreuAmbDescompte(descompte, preu)}€");
        Console.WriteLine($"El preu final del producte és superior a 50€: {EsPreuSuperiorACinquanta(preu)}");
        
    }
}

