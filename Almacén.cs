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
    public class Almacén
    {
        //Atributos en comun entre los productos de la tienda
        protected string Marca { get; set; }
        protected string Nombre { get; set; }
        protected string Categoria { get; set; }
        protected double Precio { get; set; }
        protected uint Unidad { get; set; }
        //constructor con todos los parametros
        public Almacén(string nombre, string marca, string categoria, double precio, uint cantidad)
        {
            Nombre = nombre;
            Marca = marca;
            Categoria = categoria;
            Precio = precio;
            Unidad = cantidad;

        }
        //contructor por defecto vacio
        public Almacén() { }
        //metodo override para imprimir la lista de productos, en base a el atributo y el valor que se le ha dado
        public override string ToString()
        {
            return $"Nombre: {Nombre}, Marca: {Marca}, Categoría: {Categoria}, Precio: {Precio:C}, Unidades: {Unidad}";
        }

    }
}