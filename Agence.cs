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
        this.locataires = locataires;
        this.logements = logements;
        this.contratLocations = contratLocations;
    }

    public Agence()
    {
        this.nom = "sans nom d'agence";
        this.locataires = new List<Locataire>();
        this.logements = new List<Logement>();
        this.contratLocations = new List<ContratLocation>();
    }
}