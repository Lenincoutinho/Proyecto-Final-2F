using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final
{
    public class Higiene : Almacén
    {
        public Higiene(string nombre, string marca, string categoria, double precio, uint cantidad)
        {
            Nombre = nombre;
            Marca = marca;
            Categoria = categoria;
            Precio = precio;
            Unidad = cantidad;

        }
        public Higiene(string marca, string nombre)
        {
            Marca = marca; Nombre = nombre;
        }
        public Higiene(string nombre, double precio)
        {
            Precio = precio; Nombre = nombre;
        }
        public Higiene(double precio, uint cantidad)
        {
            Precio = precio; Unidad = cantidad;
        }
        public Higiene(string categoria, uint cantidad)
        {
            Categoria = categoria; Unidad = cantidad;

        }
    }
}