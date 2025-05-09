namespace Dsw2025Ej10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* A partir de la lista de productos que se obtiene de Producto.CrearListaDeEjemplo()
             * Resolver:
             * 1. El primer producto 
             * 2. El último producto
             * 3. La suma de precios
             * 4. El promedio de precios
             * 5. Listar los productos con Id mayor a 15
             * 6. Obtener una lista de cada producto con su nombre y el precio en formato moneda, luego mostrar los elementos
             * 7. El producto con el precio más alto
             * 8. El producto con el precio más bajo
             * 9. Obtener y mostrar los productos cuyo precio sea mayor al promedio
             * 10. Listar los productos ordenados por descripción de forma descendente
             * Cada punto se debe realizar en un método distinto, en una nueva clase llamada Solucion
             */
            Solucion solucion = new Solucion();
            Console.WriteLine("1. Primer Producto: ");
            Console.WriteLine($"{solucion.GetPrimerProducto().Descripcion} - {solucion.GetPrimerProducto().Precio:C}");
            Console.WriteLine("\n2. Último producto:");
            Console.WriteLine($"{solucion.GetUltimoProducto().Descripcion} - {solucion.GetUltimoProducto().Precio:C}");

            Console.WriteLine("\n3. Suma de precios:");
            Console.WriteLine($"{solucion.GetSumaPrecios():C}");

            Console.WriteLine("\n4. Promedio de precios:");
            Console.WriteLine($"{solucion.GetPromedioPrecios():C}");

            Console.WriteLine("\n5. Productos con ID mayor a 15:");
            foreach (var producto in solucion.GetProductosConIdMayorA15())
            {
                Console.WriteLine($"{producto.Id}: {producto.Descripcion} - {producto.Precio:C}");
            }
            Console.WriteLine("\n6. Productos con precio formateado:");
            foreach (var producto in solucion.GetProductosconPrecioFormateado())
            {
                Console.WriteLine(producto);
            }

            Console.WriteLine("\n7. Producto más caro:");
            Console.WriteLine($"{solucion.GetProductoMasCaro().Descripcion} - {solucion.GetProductoMasCaro().Precio:C}");

            Console.WriteLine("\n8. Producto más barato:");
            Console.WriteLine($"{solucion.GetProductoMasBarato().Descripcion} - {solucion.GetProductoMasBarato().Precio:C}");

            Console.WriteLine("\n9. Productos con precio mayor al promedio:");
            foreach (var producto in solucion.GetProductosConPrecioMayorAlPromedio())
            {
                Console.WriteLine($"{producto.Descripcion} - {producto.Precio:C}");
            }

            Console.WriteLine("\n10. Productos ordenados por descripción descendente:");
            foreach (var producto in solucion.GetProductosOrdenadosPorDescripcionDescendente())
            {
                Console.WriteLine($"{producto.Descripcion} - {producto.Precio:C}");
            }

        }
    } 
}
