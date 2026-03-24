namespace tp_heritage3;

class Program
{
    static void Main(string[] args)
    {
        Logement log1 = new Logement("ref 01", "122 rue de la saussice à CrevetteVille", 600, 1200, true);
        log1.Afficher();
        Logement log2 = new Logement("ref 02", "3.14 rue QuelquePart à MachinVille", -122, -122, false);
        log2.Afficher();
    }
}
