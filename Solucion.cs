using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsw2025Ej10
{
    public class Solucion
    {
        private List<Producto> productos;

        public Solucion()
        {
            productos = Producto.CrearListaDeEjemplo();
        }

        //El primer producto
        // 1. El primer producto
        internal Producto GetPrimerProducto()
        {
            //Aqui uso LINQ
            //LINQ (Language Integrated Query) es una característica de C#
            //que te permite hacer consultas sobre colecciones de objetos (como listas,
            //arrays, bases de datos, XML, etc.) usando una sintaxis parecida a SQL,
            //pero integrada en el lenguaje.
            return productos.First();
        }

        // 2. El último producto
        internal Producto GetUltimoProducto()
        {
            //Aqui uso LINQ
            return productos.Last();
        }

        // 3. La suma de precios
        internal decimal GetSumaPrecios()
        {
            //Aqui uso LINQ
            return productos.Sum(p => p.Precio);
        }

        // 4. El promedio de precios
        internal decimal GetPromedioPrecios()
        {
            //Aqui uso LINQ
            return productos.Average(p => p.Precio);
        }

        // 5. Listar los productos con Id mayor a 15
        internal List<Producto> GetProductosConIdMayorA15()
        {
            //Aqui uso LINQ
            return productos.Where(p => p.Id > 15).ToList();
        }

        // 6. Obtener una lista de cada producto con su nombre y el precio en formato moneda, luego mostrar los elementos
        internal List<string> GetProductosconPrecioFormateado()
        {
            return productos.Select(p => $"{p.Descripcion} - ${p.Precio}").ToList();
        }

        // 7. El producto con el precio más alto
        internal Producto GetProductoMasCaro()
        {
            return productos.OrderByDescending(p => p.Precio).First();
        }

        // 8. El producto con el precio más bajo
        internal Producto GetProductoMasBarato()
        {
            return productos.OrderBy(p => p.Precio).First();
        }

        // 9. Obtener y mostrar los productos cuyo precio sea mayor al promedio
        internal List<Producto> GetProductosConPrecioMayorAlPromedio()
        {
            decimal promedio = GetPromedioPrecios();
            return productos.Where(p => p.Precio > promedio).ToList();
        }

        // 10. Listar los productos ordenados por descripción de forma descendente
        internal List<Producto> GetProductosOrdenadosPorDescripcionDescendente()
        {
            return productos.OrderByDescending(p => p.Descripcion).ToList();
        }
    }
}
