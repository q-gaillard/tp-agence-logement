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
            Console.WriteLine("\n| ! | le nombre de pièces ne peut pas être négative, il sera automatiquement remis à 0 | ! |\n");
            this.surface = 0;
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
            Console.WriteLine("\n| ! | le nombre de pièces ne peut pas être négative, il sera automatiquement remis à 0 | ! |\n");
            this.surface = 0;
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
}