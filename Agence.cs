using System.Runtime.InteropServices;

class Agence
{
    private string nom;
    private List<Locataire> locataires;
    private List<Logement> logements;
    private List<ContratLocation> contratLocations;

    public string Getnom()
    {
        return this.nom;
    }
    public List<Locataire> GetLocataires()
    {
        return this.locataires;
    }
    public List<Logement> GetLogements()
    {
        return this.logements;
    }
    public List<ContratLocation> GetContratLocations()
    {
        return this.contratLocations;
    }

    public void SetNom(string nom)
    {
        this.nom = nom;
    }
    public void SetLocataire(List<Locataire> locataires)
    {
        this.locataires = locataires;
    }
    public void SetLogement(List<Logement> logements)
    {
        this.logements = logements;
    }
    public void SetContratLocation(List<ContratLocation> contratLocations)
    {
        this.contratLocations = contratLocations;
    }

    public Agence(string nom, List<Locataire> locataires, List<Logement> logements, List<ContratLocation> contratLocations)
    {
        this.nom = nom;
        this.locataires = new List<Locataire>();
        this.logements = new List<Logement>();
        this.contratLocations = new List<ContratLocation>();
        for (int i = 0; i < locataires.Count(); i++)
        {
            AddLocataire(locataires[i]);
        }
        for (int i = 0; i < logements.Count(); i++)
        {
            AddLogement(logements[i]);
        }
        for (int i = 0; i < contratLocations.Count(); i++)
        {
            AddContratLocation(contratLocations[i]);
        }
    }

    public Agence()
    {
        this.nom = "sans nom d'agence";
        this.locataires = new List<Locataire>();
        this.logements = new List<Logement>();
        this.contratLocations = new List<ContratLocation>();
    }

    public void AddLocataire(Locataire locataire)
    {
        bool peutAjouter = true;
        foreach (Locataire elt in locataires)
        {
            if (elt.GetId() == locataire.GetId())
            {
                peutAjouter = false;
            }
        }
        if (peutAjouter)
        {
            locataires.Add(locataire);
        }
        else
        {
            Console.WriteLine("\n| ! | ce locataire possède un ID identique à un autre déjà enregistré, il est donc impossible de l'ajouter | ! |\n");
        }
    }

    public void AddLogement(Logement logement)
    {
        bool peutAjouter = true;
        foreach (Logement elt in logements)
        {
            if (elt.GetReference() == logement.GetReference())
            {
                peutAjouter = false;
            }
        }
        if (peutAjouter)
        {
            logements.Add(logement);
        }
        else
        {
            Console.WriteLine("\n| ! | ce logement possède une reférence identique à un autre déjà enregistré, il est donc impossible de l'ajouter | ! |\n");
        }
    }

    public void AddContratLocation(ContratLocation contratLocation)
    {
        if (!locataires.Contains(contratLocation.GetLocataire()))
        {
            Console.WriteLine("\n| ! | ce contrat de location de contient pas un de nos locataire, il est donc impossible de l'ajouter | ! |\n");
            contratLocation.GetLocataire().Afficher();
        }
        else
        {
            if (!logements.Contains(contratLocation.GetLogement()))
            {
                Console.WriteLine("\n| ! | ce contrat de location de contient pas un de nos logement, il est donc impossible de l'ajouter | ! |\n");
            }
            else
            {
                contratLocations.Add(contratLocation);
            }
        }
    }

    public void AfficherLocatiares()
    {
        if (locataires.Count() == 0)
        {
            Console.WriteLine("-> cette agence ne possède aucun locataire !");
        }
        else
        {
            Console.WriteLine($"\nliste des locataires de l'agence ''{nom}'' :");
            foreach (Locataire locataire in locataires)
            {
                locataire.Afficher();
            }
            Console.WriteLine("");
        }
    }

    public void AfficherLogements()
    {
        if (logements.Count() == 0)
        {
            Console.WriteLine("-> cette agence ne possède aucun logement !");
        }
        else
        {
            Console.WriteLine($"\nliste des logements de l'agence ''{nom}'' :");
            foreach (Logement logement in logements)
            {
                logement.Afficher();
            }
            Console.WriteLine("");
        }
    }

    public void AfficherContratLocations()
    {
        if (contratLocations.Count() == 0)
        {
            Console.WriteLine("-> cette agence ne possède aucun contrat de location !");
        }
        else
        {
            Console.WriteLine($"\nliste des contrats de location de l'agence ''{nom}'' :");
            foreach (ContratLocation contratLocation in contratLocations)
            {
                contratLocation.Afficher();
            }
            Console.WriteLine("");
        }
    }

    public void Afficher()
    {
        Console.WriteLine($"\n[ _____ Agence ''{nom}'' ______ ]");
        AfficherLocatiares();
        AfficherLogements();
        AfficherContratLocations();
    }
}