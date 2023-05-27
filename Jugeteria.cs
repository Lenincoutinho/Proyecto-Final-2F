using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Proyecto_Final
{
    internal class Jugueteria : Almacén
    {
        public Jugueteria(string nombre, string marca, string categoria, double precio, uint cantidad)
        {
            Nombre = nombre;
            Marca = marca;
            Categoria = categoria;
            Precio = precio;
            Unidad = cantidad;

        }
        public Jugueteria(string marca, string nombre)
        {
            Marca = marca; Nombre = nombre;
        }
        public Jugueteria(string nombre, double precio)
        {
            Precio = precio; Nombre = nombre;
        }
        public Jugueteria(double precio, uint cantidad)
        {
            Precio = precio; Unidad = cantidad;
        }
        public Jugueteria(string categoria, uint cantidad)
        {
            Categoria = categoria; Unidad = cantidad;

        }
    }
}