class Maison : Logement
{
    protected int surfaceJardin;

    public int GetSurfaceJardin()
    {
        return this.surfaceJardin;
    }
    
    public void SetSurfaceJardin(int surfaceJardin)
    {
        this.surfaceJardin = surfaceJardin;
        if (this.surfaceJardin < 0)
        {
            Console.WriteLine("\n| ! | la surface du jardin ne peut pas être négative, elle sera automatiquement remis à 0 | ! |\n");
            this.surfaceJardin = 0;
        }
    }

    public Maison(string reference, string adresse, int surface, double loyerBase, bool disponible, int surfaceJardin) : base(reference, adresse, surface, loyerBase, disponible)
    {
        this.reference = reference;
        this.adresse = adresse;
        this.surface = surface;
        this.loyerBase = loyerBase;
        this.disponible = disponible;
        this.surfaceJardin = surfaceJardin;
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
        if (this.surfaceJardin < 0)
        {
            Console.WriteLine("\n| ! | la surface du jardin ne peut pas être négative, elle sera automatiquement remis à 0 | ! |\n");
            this.surfaceJardin = 0;
        }
    }

    public Maison() : base()
    {
        this.reference = "pas de référence";
        this.adresse = "0 rue 'SansRue' 'SansVille";
        this.surface = 0;
        this.loyerBase = 0;
        this.disponible = false;
        this.surfaceJardin = 0;
    }

    public override void Afficher()
    {
        Console.WriteLine("\n------- Logement : -------");
        Console.WriteLine($"réference : {reference}");
        Console.WriteLine($"adresse : {adresse}");
        Console.WriteLine($"surface : {surface} m²");
        Console.WriteLine($"prix du loyer : {loyerBase} euro");
        Console.WriteLine($"surface du jardin : {surfaceJardin}");
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
}