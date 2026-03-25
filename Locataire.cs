class Locataire
{
    private int id;
    private string nom;
    private string telephone;

    public int GetId()
    {
        return this.id;
    }
    public string GetNom()
    {
        return this.nom;
    }
    public string GetTelephone()
    {
        return this.telephone;
    }

    public void SetId(int id)
    {
        this.id = id;
    }
    public void SetNom(string nom)
    {
        this.nom = nom;
    }
    public void SetTelephone(string telephone)
    {
        this.telephone = telephone;
    }

    public Locataire(int id, string nom, string telephone)
    {
        this.id = id;
        this.nom = nom;
        this.telephone = telephone;
    }

    public Locataire()
    {
        this.id = 0;
        this.nom = "sans nom";
        this.telephone = "00 00 00 00 00";
    }

    public void Afficher()
    {
        Console.WriteLine($"\n{nom} | id : {id} | tel : {telephone}\n");
    }
}