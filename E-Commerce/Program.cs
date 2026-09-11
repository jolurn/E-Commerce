string respuesta = "";
decimal total = 0;

do
{
    Console.WriteLine("¿Deseas agregar un producto al carrito? (si/no)");
    respuesta = Console.ReadLine().ToLower();

    switch (respuesta)
    {
        case "si":
            Console.WriteLine("¿Cuál es el nombre del producto?");
            string nombreProducto = Console.ReadLine();

            Console.WriteLine("¿Cuál es el precio del producto?");
            decimal precioProducto = decimal.Parse(Console.ReadLine());

            Console.WriteLine("¿Cuál es la cantidad del producto?");
            int cantidadProducto = int.Parse(Console.ReadLine());

            if(cantidadProducto % 1 == 0)
            {
                decimal subtotal = precioProducto * cantidadProducto;
                total = total + subtotal;

                Console.WriteLine($"Producto: {nombreProducto} | Subtotal: {subtotal} | Total acumulado: {total}");
                Console.WriteLine();
            }
            
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

Console.WriteLine();
Console.WriteLine($"TOTAL A PAGAR: {total}");