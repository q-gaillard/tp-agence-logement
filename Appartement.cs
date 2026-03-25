class Appartement : Logement
{
    protected int nombreDePieces;

    public int GetNombreDePiece()
    {
        return this.nombreDePieces;
    }
    
    public void SetNombreDePiece(int nombreDePieces)
    {
        this.nombreDePieces = nombreDePieces;
        if (this.nombreDePieces < 0)
        {
            Console.WriteLine("\n| ! | le nombre de pièces ne peut pas être négative, il sera automatiquement remis à 1 | ! |\n");
            this.nombreDePieces = 1;
        }
        else if (this.nombreDePieces == 0)
        {
            Console.WriteLine("\n| ! | un apartement dois obligatoirement avoir au moins 1 pièce, le nombre de pièce sera automatiquement remis à 1 | ! |\n");
            this.nombreDePieces = 1;
        }
    }

    public Appartement(string reference, string adresse, int surface, double loyerBase, bool disponible, int nombreDePieces) : base(reference, adresse, surface, loyerBase, disponible)
    {
        this.reference = reference;
        this.adresse = adresse;
        this.surface = surface;
        this.loyerBase = loyerBase;
        this.disponible = disponible;
        this.nombreDePieces = nombreDePieces;
        if (this.surface < 0)
        {
            Console.WriteLine("\n| ! | la surface ne peut pas être négative, elle sera automatiquement remis à 0 | ! |\n");
            this.surface = 0;
        }
        if (this.loyerBase < 0)
        {
            Console.WriteLine("\n| ! | le loyer ne peut pas être négative, il sera automatiquement remis à 0 | ! |\n");
            this.loyerBase = 0;
        }
        if (this.nombreDePieces < 0)
        {
            Console.WriteLine("\n| ! | le nombre de pièces ne peut pas être négative, il sera automatiquement remis à 1 | ! |\n");
            this.nombreDePieces = 1;
        }
        else if (this.nombreDePieces == 0)
        {
            Console.WriteLine("\n| ! | un apartement dois obligatoirement avoir au moins 1 pièce, le nombre de pièce sera automatiquement remis à 1 | ! |\n");
            this.nombreDePieces = 1;
        }
    }

    public Appartement() : base()
    {
        this.reference = "pas de référence";
        this.adresse = "0 rue 'SansRue' 'SansVille";
        this.surface = 0;
        this.loyerBase = 0;
        this.disponible = false;
        this.nombreDePieces = 0;
    }

    public override void Afficher()
    {
        Console.WriteLine("\n------- Appartement : -------");
        Console.WriteLine($"réference : {reference}");
        Console.WriteLine($"adresse : {adresse}");
        Console.WriteLine($"surface : {surface} m²");
        Console.WriteLine($"prix du loyer : {loyerBase} euro");
        Console.WriteLine($"nombre de pièce : {nombreDePieces}");
        if (disponible)
        {
            Console.WriteLine("status : disponible");
        }
        else
        {
            Console.WriteLine("status : indisponile");
        }
        Console.WriteLine("--------------------------\n");
    }

    public override double CalculerLoyer()
    {
        return loyerBase + (100*nombreDePieces);
    }
}