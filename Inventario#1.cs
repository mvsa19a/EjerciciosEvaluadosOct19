using System;
using System.Collections.Generic;

namespace InventarioTienda
{
    internal class Inventario
    {
        public static void Main(string[] args)
        {
            List<Tuple<string, string, int, decimal>> inventario = new List<Tuple<string, string, int, decimal>>();
            int opcion;

            do
            {
                Console.WriteLine("\n--- Menu de opciones ---");
                Console.WriteLine("1. Agregar producto");
                Console.WriteLine("2. Eliminar producto");
                Console.WriteLine("3. Modificar producto");
                Console.WriteLine("4. Consultar producto");
                Console.WriteLine("5. Mostrar todos los productos");
                Console.WriteLine("6. Salir");
                Console.Write("Seleccione una opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        AgregarProducto(inventario);
                        break;
                    case 2:
                        EliminarProducto(inventario);
                        break;
                    case 3:
                        ModificarProducto(inventario);
                        break;
                    case 4:
                        ConsultarProducto(inventario);
                        break;
                    case 5:
                        MostrarProductos(inventario);
                        break;
                    case 6:
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        Console.WriteLine("Opción no valida, intente nuevamente.");
                        break;
                }
            } while (opcion != 6);
        }

        public static void AgregarProducto(List<Tuple<string, string, int, decimal>> inventario)
        {
            Console.Write("Introduzca el codigo del producto: ");
            string codigo = Console.ReadLine();
            Console.Write("Introduzca el nombre del producto: ");
            string nombre = Console.ReadLine();
            Console.Write("Introduzca la cantidad del producto: ");
            int cantidad = int.Parse(Console.ReadLine());
            Console.Write("Introduzca el precio del producto: ");
            decimal precio = decimal.Parse(Console.ReadLine());

            inventario.Add(new Tuple<string, string, int, decimal>(codigo, nombre, cantidad, precio));
            Console.WriteLine("Producto agregado exitosamente.");
        }

        public static void EliminarProducto(List<Tuple<string, string, int, decimal>> inventario)
        {
            Console.Write("Introduzca el codigo del producto a eliminar: ");
            string codigo = Console.ReadLine();

            var producto = inventario.Find(p => p.Item1 == codigo);

            if (producto != null)
            {
                inventario.Remove(producto);
                Console.WriteLine("Producto eliminado exitosamente.");
            }
            else
            {
                Console.WriteLine("Producto no encontrado.");
            }
        }

        public static void ModificarProducto(List<Tuple<string, string, int, decimal>> inventario)
        {
            Console.Write("Introduzca el codigo del producto a modificar: ");
            string codigo = Console.ReadLine();

            var producto = inventario.Find(p => p.Item1 == codigo);

            if (producto != null)
            {
                Console.Write("Introduzca el nuevo nombre del producto: ");
                string nombre = Console.ReadLine();
                Console.Write("Introduzca la nueva cantidad del producto: ");
                int cantidad = int.Parse(Console.ReadLine());
                Console.Write("Introduzca el nuevo precio del producto: ");
                decimal precio = decimal.Parse(Console.ReadLine());

                inventario.Remove(producto);
                inventario.Add(new Tuple<string, string, int, decimal>(codigo, nombre, cantidad, precio));

                Console.WriteLine("Producto modificado exitosamente.");
            }
            else
            {
                Console.WriteLine("Producto no encontrado.");
            }
        }

        public static void ConsultarProducto(List<Tuple<string, string, int, decimal>> inventario)
        {
            Console.Write("Introduzca el codigo del producto a consultar: ");
            string codigo = Console.ReadLine();

            var producto = inventario.Find(p => p.Item1 == codigo);

            if (producto != null)
            {
                Console.WriteLine($"Codigo: {producto.Item1}, Nombre: {producto.Item2}, Cantidad: {producto.Item3}, Precio: {producto.Item4}");
            }
            else
            {
                Console.WriteLine("Producto no encontrado.");
            }
        }

        public static void MostrarProductos(List<Tuple<string, string, int, decimal>> inventario)
        {
            if (inventario.Count > 0)
            {
                Console.WriteLine("\n--- Inventario de productos ---");
                foreach (var producto in inventario)
                {
                    Console.WriteLine($"Codigo: {producto.Item1}, Nombre: {producto.Item2}, Cantidad: {producto.Item3}, Precio: {producto.Item4}");
                }
            }
            else
            {
                Console.WriteLine("No hay productos en el inventario.");
            }
        }
    }
}
