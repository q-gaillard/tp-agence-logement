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
        Studio studio1 = new Studio("Studio des fous", "67 rue Untitled Street à FouVille", 1500, 1220, false, true);
        studio1.Afficher();
        Appartement appart1 = new Appartement("magnifique est sonptueux appartement de 5m²", "quelque perdu dans Paris", 5, 122, true, 2);
        appart1.Afficher();
        Maison maison1 = new Maison("la Maison de rêve de Barbie", "0 rue de la Rue à Rueville", 900, 10, false, -5);
        maison1.Afficher();

        //afficher les loyers
        Console.WriteLine("*** prix des loyer : ***");
        Console.WriteLine(log1.CalculerLoyer());
        Console.WriteLine(studio1.CalculerLoyer());
        Console.WriteLine(appart1.CalculerLoyer());
        Console.WriteLine(maison1.CalculerLoyer());
        Console.WriteLine("*****");
    }
}
