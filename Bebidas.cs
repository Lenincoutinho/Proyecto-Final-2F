/* Instituto Tecnológico Superior de Cintalapa
 * Ingeniería Informática
 * Programación Orientada a Objetos
 * Jorge Iván Bermúdez Rodríguez
 * 2 Semestre grupo F
 * Darwin Amaury Nataren Arellano
 * Geovanna Belén Abarca Clemente
 * Ezequiel Sarmiento Morales
 * Lenin Coutiño Lázaro
 * Proyecto final
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final
{
    public class Bebidas : Almacén
    {
        public Bebidas(string nombre, string marca, string categoria, double precio, uint cantidad)
        {
            Nombre = nombre;
            Marca = marca;
            Categoria = categoria;
            Precio = precio;
            Unidad = cantidad;

        }
        public Bebidas(string marca, string nombre)
        {
            Marca = marca; Nombre = nombre;
        }
        public Bebidas(string nombre, double precio)
        {
            Precio = precio; Nombre = nombre;
        }
        public Bebidas(double precio, uint cantidad)
        {
            Precio = precio; Unidad = cantidad;
        }
        public Bebidas(string categoria, uint cantidad)
        {
            Categoria = categoria; Unidad = cantidad;

        }
    }
}