namespace tp_heritage3;

class Program
{
    static void Main(string[] args)
    {
        // création de logement classique
        Logement log1 = new Logement("ref 01", "122 rue de la saussice à CrevetteVille", 600, 1200, true);
        log1.Afficher();
        Logement log2 = new Logement("ref 02", "3.14 rue QuelquePart à MachinVille", -122, -122, false);
        log2.Afficher();

        // création de logement spéciaux
        Studio studio1 = new Studio("Studio des fous", "67 rue Untitled Street à FouVille", 1500, 1220, true, true);
        studio1.Afficher();
        Appartement appart1 = new Appartement("magnifique et sonptueux appartement de 5m²", "quelque perdu dans Paris", 5, 122, false, 2);
        appart1.Afficher();
        Maison maison1 = new Maison("la Maison de rêve de Barbie", "0 rue de la Rue à Rueville", 900, 10, true, -5);
        maison1.Afficher();

        //afficher les loyers
        Console.WriteLine("*** prix des loyer : ***");
        Console.WriteLine(log1.CalculerLoyer());
        Console.WriteLine(studio1.CalculerLoyer());
        Console.WriteLine(appart1.CalculerLoyer());
        Console.WriteLine(maison1.CalculerLoyer());
        Console.WriteLine("*****");

        //polymorphisme
        List<Logement> logements = new List<Logement>
        {
            new Studio("Studio des fous", "67 rue Untitled Street à FouVille", 1500, 1220, false, true),
            new Appartement("magnifique et sonptueux appartement de 5m²", "quelque perdu dans Paris", 5, 122, true, 2),
            new Maison("la Maison de rêve de Barbie", "0 rue de la Rue à Rueville", 900, 10, false, -5)
        };

        Console.WriteLine("liste des logements :");
        foreach (Logement logement in logements)
        {
            logement.Afficher();
            Console.WriteLine($"pirix du loyer de {logement.GetReference()} est de {logement.CalculerLoyer()} euro");
        }

        // création de locataire
        Locataire loc1 = new Locataire(1, "Shrek", "06 06 06 06 06");
        Locataire loc2 = new Locataire(2, "quelqu'un", "06 05 04 03 21");
        Locataire loc3 = new Locataire(3, "gandalf", "06 12 21 22 12");
        
        loc1.Afficher();
        loc2.Afficher();
        loc3.Afficher();

        // crée des contrats de location
        ContratLocation contrat1 = new ContratLocation(1, loc2, studio1, 20);
        ContratLocation contrat2 = new ContratLocation(2, loc1, maison1, 20);
        
        ContratLocation contrat3 = new ContratLocation(3, loc3, log1, 0);
        ContratLocation contrat4 = new ContratLocation(4, loc3, log2, 1);

        contrat1.Afficher();
        contrat2.Afficher();
        contrat3.Afficher();
        contrat4.Afficher();

        //crée des agences
        Agence agence1 = new Agence("l'agence des gens bizarres", new List<Locataire>{loc1, loc2, loc3, loc1}, new List<Logement>{log1, log2, studio1, appart1, maison1}, new List<ContratLocation>());
        agence1.Afficher();

        agence1.AddLocataire(new Locataire(4, "Spider man", "06 67 23 67 67"));
        agence1.AddLogement(maison1);
        agence1.AddLogement(new Maison("la maison blanche", "1600 rue Pennsylvania Avenue NW à Washington D.C", 73000, 9999999, true, 600));
        agence1.AddContratLocation( new ContratLocation(5, agence1.GetLocataires()[3], agence1.GetLogements()[4], 122));
        agence1.Afficher();
    }
}
