Client client = new Client("Fran", 12345678, "Calle Piruleta", "email@hotmail.com", false);
Client client2 = client with { name = "Lola" };

Console.WriteLine(client.ToString());
Console.WriteLine(client2.ToString());

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

    public string name { get; set; }
    public int tel { get; set; }
    public string direction { get; set; }
    public string email { get; set; }
    public bool newClient { get; set; }


    public override string ToString() => $"El cliente {name} tiene el teléfono {tel}," +
        $" su dirección es {direction}, su email es {email} y es nuevo cliente: {newClient}";
}