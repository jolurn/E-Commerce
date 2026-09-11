class Program
{    
    static string respuesta = "";
    static decimal total = 0;
    static int cantidadProductos = 0;

    static void Main(string[] args)
    {
        do
        {
            MostrarMenu();
            respuesta = Console.ReadLine().ToLower();

            switch (respuesta)
            {
                case "si":
                    AgregarProducto();
                    break;

                case "no":
                    Console.WriteLine("Cerrando el carrito...");
                    break;

                default:
                    Console.WriteLine("Respuesta no válida. Escribe 'si' o 'no'.");
                    Console.WriteLine();
                    break;
            }

        } while (respuesta != "no");

        MostrarTotal();
    }
        
    static void MostrarMenu()
    {
        Console.WriteLine("¿Deseas agregar un producto al carrito? (si/no)");
    }
        
    static void AgregarProducto()
    {
        Console.WriteLine("¿Cuál es el nombre del producto?");
        string nombreProducto = Console.ReadLine();

        Console.WriteLine("¿Cuál es el precio del producto?");
        decimal precioProducto = decimal.Parse(Console.ReadLine());

        Console.WriteLine("¿Cuál es la cantidad del producto?");
        int cantidadProducto = int.Parse(Console.ReadLine());

        if (cantidadProducto % 1 == 0)
        {
            decimal subtotal = precioProducto * cantidadProducto;
            total = total + subtotal;
            cantidadProductos++;

            Console.WriteLine($"Producto: {nombreProducto} | Subtotal: {subtotal} | Total acumulado: {total}");
            Console.WriteLine();
        }
    }

    static void MostrarTotal()
    {
        Console.WriteLine();
        Console.WriteLine($"Cantidad de productos agregados: {cantidadProductos}");
        Console.WriteLine($"TOTAL A PAGAR: {total}");
    }
}