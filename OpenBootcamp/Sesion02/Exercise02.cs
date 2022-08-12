namespace Sesion02
{
    public class Exercise02
    {
        struct Coche
        {
            public int puertas;
            public int ruedas;
            public string marca;
            public bool itv;
        }

        struct Mesa
        {
            public double peso;
            public double largo;
            public string material;
            public string color;
        }

        public void PrintData()
        {
            var coche = new Coche() { puertas = 4, ruedas = 4, marca = "Nissan", itv = true };
            Mesa mesa = new Mesa() { peso = 20.00, largo = 100, material = "Madera", color = "Marron" };
            Console.WriteLine("Coche con {0} puertas, {1} ruedas, de marca {2} y con la ITV: {3}",
                                coche.puertas, coche.ruedas, coche.marca, coche.itv);
        }
    }
}
