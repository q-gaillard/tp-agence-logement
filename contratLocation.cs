class ContratLocation
{
    private int numero;
    private Locataire locataire;
    private Logement logement;
    private int nombreJour;
    private double tarifJournalier;

    public int GetNumero()
    {
        return this.numero;
    }
    public Locataire GetLocataire()
    {
        return this.locataire;
    }
    public Logement GetLogement()
    {
        return this.logement;
    }
    public int GetNombreJour()
    {
        return this.nombreJour;
    }
    public double GetTarifJournalier()
    {
        return this.tarifJournalier;
    }

    public void SetNumero(int numero)
    {
        this.numero = numero;
    }
    public void SetLocataire(Locataire locataire)
    {
        this.locataire = locataire;
    }
    public void SetLogement(Logement logement)
    {
        this.logement = logement;
        if (!this.logement.GetDisponible())
        {
            Console.WriteLine("\n| ! | le logement que vous essayer d'intégré à ce contrat n'est pas disponible | ! |\n");
            this.logement = new Logement();
        }
    }
    public void SetNombreJour(int nombreJour)
    {
        this.nombreJour = nombreJour;
        if (this.nombreJour < 1)
        {
            Console.WriteLine("\n| ! | le nombre de jour dois être strictement positif, il sera automatiquement remis à 1 | ! |\n");
            this.nombreJour = 1;
        }
    }

    public ContratLocation(int numero, Locataire locataire, Logement logement, int nombreJour)
    {
        if (logement.GetDisponible())
        {
            this.numero = numero;
            this.locataire = locataire;
            this.logement = logement;
            this.nombreJour = nombreJour;
            this.tarifJournalier = this.logement.CalculerLoyer();
            this.logement.SetDisponible(false);
            if (this.nombreJour < 1)
            {
                Console.WriteLine("\n| ! | le nombre de jour dois être strictement positif, il sera automatiquement remis à 1 | ! |\n");
                this.nombreJour = 1;
            }
        }
        else
        {
            Console.WriteLine("\n| ! | le logement que vous essayer d'intégré à ce contrat n'est pas disponible | ! |\n");
            this.numero = 0;
            this.locataire = new Locataire();
            this.logement = new Logement();
            this.nombreJour = 1;
            this.tarifJournalier = this.logement.CalculerLoyer();
        }
    }

    public ContratLocation()
    {
        this.numero = 0;
        this.locataire = new Locataire();
        this.logement = new Logement();
        this.nombreJour = 1;
        this.tarifJournalier = this.logement.CalculerLoyer();
        this.logement.SetDisponible(false);
    }

    public void Afficher()
    {
        Console.WriteLine($"\n----- contrat de logement de {locataire.GetNom()} ------\n");
        Console.WriteLine("info du locataire :");
        locataire.Afficher();
        Console.WriteLine("info du logement :");
        logement.Afficher();
        Console.WriteLine($"info complémentaire :\n\nnuméro : {numero}\nnombre de jour : {nombreJour}\ntarif journalier : {tarifJournalier}\n");
        Console.WriteLine("---------------------------------------------------------\n");
    }

    public double CalculerMontantTotal()
    {
        return tarifJournalier*nombreJour;
    }
}