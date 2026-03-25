class Logement
{
    protected string reference;
    protected string adresse;
    protected int surface;
    protected double loyerBase;
    protected bool disponible;

    public string GetReference()
    {
        return this.reference;
    }
    public string GetAdresse()
    {
        return this.adresse;
    }
    public int GetSurface()
    {
        return this.surface;
    }
    public double GetLoyerBase()
    {
        return this.loyerBase;
    }
    public bool GetDisponible()
    {
        return this.disponible;
    }

    public void SetReference(string reference)
    {
        this.reference = reference;
    }
    public void SetAdresse(string adresse)
    {
        this.adresse = adresse;
    }
    public void SetSurface(int surface)
    {
        this.surface = surface;
        if (this.surface < 0)
        {
            Console.WriteLine("\n| ! | la surface ne peut pas être négative, elle sera automatiquement remis à 0 | ! |\n");
            this.surface = 0;
        }
    }
    public void SetLoyerBase(double loyerBase)
    {
        this.loyerBase = loyerBase;
        if (this.loyerBase < 0)
        {
            Console.WriteLine("\n| ! | le loyer ne peut pas être négative, il sera automatiquement remis à 0 | ! |\n");
            this.loyerBase = 0;
        }
    }
    public void SetDisponible(bool disponible)
    {
        this.disponible = disponible;
    }

    public Logement(string reference, string adresse, int surface, double loyerBase, bool disponible)
    {
        this.reference = reference;
        this.adresse = adresse;
        this.surface = surface;
        this.loyerBase = loyerBase;
        this.disponible = disponible;
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

    public Logement()
    {
        this.reference = "pas de référence";
        this.adresse = "0 rue 'SansRue' 'SansVille";
        this.surface = 0;
        this.loyerBase = 0;
        this.disponible = false;
    }

    public virtual void Afficher()
    {
        Console.WriteLine("\n------- Logement : -------");
        Console.WriteLine($"réference : {reference}");
        Console.WriteLine($"adresse : {adresse}");
        Console.WriteLine($"surface : {surface} m²");
        Console.WriteLine($"prix du loyer : {loyerBase} euro");
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

    public double CalculerLoyer()
    {
        return loyerBase;
    }
}