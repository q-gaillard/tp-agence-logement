class Studio : Logement
{
    protected bool meuble;

    public bool GetMeuble()
    {
        return this.meuble;
    }
    
    public void SetMeuble(bool meuble)
    {
        this.meuble = meuble;
    }

    public Studio(string reference, string adresse, int surface, double loyerBase, bool disponible, bool meuble) : base(reference, adresse, surface, loyerBase, disponible)
    {
        this.reference = reference;
        this.adresse = adresse;
        this.surface = surface;
        this.loyerBase = loyerBase;
        this.disponible = disponible;
        this.meuble = meuble;
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
    }

    public Studio() : base()
    {
        this.reference = "pas de référence";
        this.adresse = "0 rue 'SansRue' 'SansVille";
        this.surface = 0;
        this.loyerBase = 0;
        this.disponible = false;
        this.meuble = false;
    }

    public override void Afficher()
    {
        Console.WriteLine("\n------- Logement : -------");
        Console.WriteLine($"réference : {reference}");
        Console.WriteLine($"adresse : {adresse}");
        Console.WriteLine($"surface : {surface} m²");
        Console.WriteLine($"prix du loyer : {loyerBase} euro");
        if (disponible)
        {
            Console.Write("status : disponible");
        }
        else
        {
            Console.Write("status : indisponile");
        }
        if (meuble)
        {
            Console.WriteLine(" / avec meubles");
        }
        else
        {
            Console.WriteLine(" / sans meubles");
        }
        Console.WriteLine("--------------------------\n");
    }
}