Console.Write("--- Exercise 01 ---");
Console.Write("Introduce el nombre:");
string name = Console.ReadLine();
Console.Write("Introduce el email:");
string email = Console.ReadLine();
Console.Write("Introduce el cupon:");
int coupon = Convert.ToInt32(Console.ReadLine());

Client client = new Client(name, email, coupon);
//client.SetDiscountIfApplicable();
//Console.WriteLine(client.ToString());

Console.Write("--- Exercise 02 ---");
Exercise02 ex2 = new Exercise02();
ex2.SelectLanguage();



public struct Client
{
    public Client(string name, string email, int coupon)
    {
        this.name = name;
        this.email = email;
        this.coupon = coupon;
        this.price = 100;
    }

    public string name { get; private set; }
    public string email { get; private set; }
    public int coupon { get; private set; }
    public int price { get; private set; }

    public void SetDiscountIfApplicable()
    {
        if (coupon > 0)
            price -= coupon;
    }
    public override string ToString()
    {
        return coupon > 0 ? $"El cliente con nombre {name} e email: {email} tiene asignado un precio de {price} con un descuento del {coupon}" :
            $"El cliente con nombre {name} e email: {email} tiene asignado un precio de {price} sin descuento";
    }

}

public class Exercise02
{
    public void SelectLanguage()
    {
        string languageSelected;
        string selection;

        Console.WriteLine("Seleccione un lenguaje:\na) C#\nb) Java\nc) C++\nd) Python");
        selection = Console.ReadLine();

        switch (selection)
        {
            case "a":
                languageSelected = "C#";
                break;
            case "b":
                languageSelected = "Java";
                break;
            case "c":
                languageSelected = "C++";
                break;
            case "d":
                languageSelected = "Python";
                break;
            default:
                languageSelected = "";
                Console.WriteLine("Debe introducir a, b, c o d");
                break;
        }

        Console.WriteLine($"El lenguaje seleccionado es: {languageSelected}");
    }
}