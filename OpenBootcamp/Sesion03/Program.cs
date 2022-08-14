Client client = new Client("Fran", 12345678, "Calle Piruleta", "email@hotmail.com", false);

Console.WriteLine(client.ToString());

public struct Client
{
    public Client(string name, int tel, string direction, string email, bool newClient)
    {
        this.name = name;
        this.tel = tel;
        this.direction = direction;
        this.email = email;
        this.newClient = newClient;
    }

    public string name { get; }
    public int tel { get; }
    public string direction { get; }
    public string email { get; }
    public bool newClient { get; }


    public override string ToString() => $"El cliente {name} tiene el teléfono {tel}," +
        $" su dirección es {direction}, su email es {email} y es nuevo cliente: {newClient}";
}