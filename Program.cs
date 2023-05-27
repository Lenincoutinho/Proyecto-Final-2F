/*Instituto Tecnológico Superior de Cintalapa
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
using System.Text.RegularExpressions;

namespace Proyecto_Final;

public class Program
{
    static List<Almacén> inventario = new List<Almacén>();

    static void Main(string[] args)
    {
        /*Construir una base de datos con algunos objetos ya definidos para el inventario, cada uno con parametros 
        diferentes para cada costructor
        */
        {
            Alimentos producto1 = new Alimentos("Manzanas", "Frutas Ricas", "Frutas", 2.99, 5);
            Alimentos producto2 = new Alimentos("Leche", "LecheFresca", "Lácteos", 1.99, 10);
            Alimentos producto3 = new Alimentos("Arroz", "Mariposa", "Cereales", 3.49, 3);
            Alimentos producto4 = new Alimentos("Pollo", "Delicioso", "Carnes", 8.99, 2);
            Alimentos producto5 = new Alimentos("Yogur", "Saludable", "Lácteos", 0.99, 8);
            Alimentos producto6 = new Alimentos("Pasta", "Deliciosa", "Cereales", 2.79, 4);
            Alimentos producto7 = new Alimentos("Atún", "Conservas", "Pescados", 1.49, 6);
            Alimentos producto8 = new Alimentos("Pan", "Fresco", "Panadería", 1.29, 12);
            Alimentos producto9 = new Alimentos("Queso", "Sabroso", "Lácteos", 3.99, 7);
            Alimentos producto10 = new Alimentos("Cereal", "Rico", "Cereales", 4.99, 9);

            Alimentos producto11 = new Alimentos("Manzanas", "Frutas Ricas");
            Alimentos producto12 = new Alimentos("Leche", "LecheFresca");
            Alimentos producto13 = new Alimentos("Arroz", "Mariposa");
            Alimentos producto14 = new Alimentos("Pollo", "Delicioso");
            Alimentos producto15 = new Alimentos("Yogur", "Saludable");
            Alimentos producto16 = new Alimentos("Pasta", "Deliciosa");
            Alimentos producto17 = new Alimentos("Atún", "Conservas");
            Alimentos producto18 = new Alimentos("Pan", "Fresco");
            Alimentos producto19 = new Alimentos("Queso", "Sabroso");
            Alimentos producto20 = new Alimentos("Cereal", "Rico");

            Alimentos producto21 = new Alimentos(2.99, 5);
            Alimentos producto22 = new Alimentos(1.99, 10);
            Alimentos producto23 = new Alimentos(3.49, 3);
            Alimentos producto24 = new Alimentos(8.99, 2);
            Alimentos producto25 = new Alimentos(0.99, 8);
            Alimentos producto26 = new Alimentos(2.79, 4);
            Alimentos producto27 = new Alimentos(1.49, 6);
            Alimentos producto28 = new Alimentos(1.29, 12);
            Alimentos producto29 = new Alimentos(3.99, 7);
            Alimentos producto30 = new Alimentos(4.99, 9);

            Alimentos producto31 = new Alimentos("Frutas", 5);
            Alimentos producto32 = new Alimentos("Lácteos", 10);
            Alimentos producto33 = new Alimentos("Cereales", 3);
            Alimentos producto34 = new Alimentos("Carnes", 2);
            Alimentos producto35 = new Alimentos("Lácteos", 8);
            Alimentos producto36 = new Alimentos("Cereales", 4);
            Alimentos producto37 = new Alimentos("Pescados", 6);
            Alimentos producto38 = new Alimentos("Panadería", 12);
            Alimentos producto39 = new Alimentos("Lácteos", 7);
            Alimentos producto40 = new Alimentos("Cereales", 9);
            //Añadir cada producto
            inventario.Add(producto1);
            inventario.Add(producto2);
            inventario.Add(producto3);
            inventario.Add(producto4);
            inventario.Add(producto5);
            inventario.Add(producto6);
            inventario.Add(producto7);
            inventario.Add(producto8);
            inventario.Add(producto9);
            inventario.Add(producto10);
            inventario.Add(producto11);
            inventario.Add(producto12);
            inventario.Add(producto13);
            inventario.Add(producto14);
            inventario.Add(producto15);
            inventario.Add(producto16);
            inventario.Add(producto17);
            inventario.Add(producto18);
            inventario.Add(producto19);
            inventario.Add(producto20);
            inventario.Add(producto21);
            inventario.Add(producto22);
            inventario.Add(producto23);
            inventario.Add(producto24);
            inventario.Add(producto25);
            inventario.Add(producto26);
            inventario.Add(producto27);
            inventario.Add(producto28);
            inventario.Add(producto29);
            inventario.Add(producto30);
            inventario.Add(producto31);
            inventario.Add(producto32);
            inventario.Add(producto33);
            inventario.Add(producto34);
            inventario.Add(producto35);
            inventario.Add(producto36);
            inventario.Add(producto37);
            inventario.Add(producto38);
            inventario.Add(producto39);
            inventario.Add(producto40);
        }
        {
            Deportes produc1 = new Deportes("Adidas", "Balon De Futbol");
            Deportes produc2 = new Deportes("Nike", "Raqueta De Tenis");
            Deportes produc3 = new Deportes("Jordan", "Tenis");
            Deportes produc4 = new Deportes("Charly", "Sudadera");
            Deportes produc5 = new Deportes("Pirma", "Balon De Basquet");
            Deportes produc6 = new Deportes("Adidas", "Pans De Corredor");
            Deportes produc7 = new Deportes("Nike", "Gorra");
            Deportes produc8 = new Deportes("Skechers", "Tenis");
            Deportes produc9 = new Deportes("Puma", "Balon");
            Deportes produc10 = new Deportes("Under Armour", "Playera De Presion");

            inventario.Add(produc1);
            inventario.Add(produc2);
            inventario.Add(produc3);
            inventario.Add(produc4);
            inventario.Add(produc5);
            inventario.Add(produc6);
            inventario.Add(produc7);
            inventario.Add(produc8);
            inventario.Add(produc9);
            inventario.Add(produc10);
        }
        {
            Higiene prodct1 = new Higiene("Asepcia", "Jabon AntiAcne");
            Higiene prodct2 = new Higiene("Colgate", "Paste Dental");
            Higiene prodct3 = new Higiene("Caprice", "Shampoo");
            Higiene prodct4 = new Higiene("Listerine", "Enjuague Bucal");
            Higiene prodct5 = new Higiene("Petalo", "Papel De Baño");
            Higiene prodct6 = new Higiene("Guillet", "Rastilo Corporal");
            Higiene prodct7 = new Higiene("Kotex", "Toallas Femeninas");
            Higiene prodct8 = new Higiene("Nivea", "Desodorante Corporal");
            Higiene prodct9 = new Higiene("OralB", "Cepillo De Dientes");
            Higiene prodct10 = new Higiene("Escudo", "Jabon ActiBacterial");

            inventario.Add(prodct1);
            inventario.Add(prodct2);
            inventario.Add(prodct3);
            inventario.Add(prodct4);
            inventario.Add(prodct5);
            inventario.Add(prodct6);
            inventario.Add(prodct7);
            inventario.Add(prodct8);
            inventario.Add(prodct9);
            inventario.Add(prodct10);
        }
        {
            Refacciones prdc1 = new Refacciones("Bulbula De Motor", 200.00);
            Refacciones prdc2 = new Refacciones("Cople", 800.00);
            Refacciones prdc3 = new Refacciones("Faros", 500.00);
            Refacciones prdc4 = new Refacciones("Bateria", 2500.00);
            Refacciones prdc5 = new Refacciones("Llantas", 599.99);
            Refacciones prdc6 = new Refacciones("Discos De Frenos", 600.00);
            Refacciones prdc7 = new Refacciones("Rodamientos", 780.00);
            Refacciones prdc8 = new Refacciones("Bujias", 299.99);
            Refacciones prdc9 = new Refacciones("Mangueras", 499.99);
            Refacciones prdc10 = new Refacciones("Bomba De Gasolina", 2500.00);

            inventario.Add(prdc1);
            inventario.Add(prdc2);
            inventario.Add(prdc3);
            inventario.Add(prdc4);
            inventario.Add(prdc5);
            inventario.Add(prdc6);
            inventario.Add(prdc7);
            inventario.Add(prdc8);
            inventario.Add(prdc9);
            inventario.Add(prdc10);
        }
        {
            Bebidas produ1 = new Bebidas("Refrescos", 5);
            Bebidas produ2 = new Bebidas("Jugos", 6);
            Bebidas produ3 = new Bebidas("Cerveza", 20);
            Bebidas produ4 = new Bebidas("Energuizantes", 7);
            Bebidas produ5 = new Bebidas("Ron", 3);
            Bebidas produ6 = new Bebidas("Leche", 4);
            Bebidas produ7 = new Bebidas("Vino", 2);
            Bebidas produ8 = new Bebidas("Te", 5);
            Bebidas produ9 = new Bebidas("Cafe", 4);
            Bebidas produ10 = new Bebidas("Agua", 3);

            inventario.Add(produ1);
            inventario.Add(produ2);
            inventario.Add(produ3);
            inventario.Add(produ4);
            inventario.Add(produ5);
            inventario.Add(produ6);
            inventario.Add(produ7);
            inventario.Add(produ8);
            inventario.Add(produ9);
            inventario.Add(produ10);
        }
        {
            Farmacia Prct1 = new Farmacia("Aspirina", 84.99);
            Farmacia Prct2 = new Farmacia("Paracetamol", 94.99);
            Farmacia Prct3 = new Farmacia("Ibuprofeno", 120.00);
            Farmacia Prct4 = new Farmacia("Amoxicilina", 63.00);
            Farmacia Prct5 = new Farmacia("Omeprazol", 285.00);
            Farmacia Prct6 = new Farmacia("Loratarina", 31.00);
            Farmacia Prct7 = new Farmacia("Albuterol", 473.00);
            Farmacia Prct8 = new Farmacia("Simvastatina", 247.00);
            Farmacia Prct9 = new Farmacia("Metformina", 107.00);
            Farmacia Prct10 = new Farmacia("Ciprofloxacina", 186.00);

            inventario.Add(Prct1);
            inventario.Add(Prct2);
            inventario.Add(Prct3);
            inventario.Add(Prct4);
            inventario.Add(Prct5);
            inventario.Add(Prct6);
            inventario.Add(Prct7);
            inventario.Add(Prct8);
            inventario.Add(Prct9);
            inventario.Add(Prct10);
        }
        {
            Electrodomesticos proc1 = new Electrodomesticos("Refrigerador", 15000);
            Electrodomesticos proc2 = new Electrodomesticos("Television", 9000);
            Electrodomesticos proc3 = new Electrodomesticos("Lavadora", 15000);
            Electrodomesticos proc4 = new Electrodomesticos("Secadora De Ropa", 7500);
            Electrodomesticos proc5 = new Electrodomesticos("Honor Electrico", 5000);
            Electrodomesticos proc6 = new Electrodomesticos("Microndas", 5300);
            Electrodomesticos proc7 = new Electrodomesticos("Licuadora", 2000);
            Electrodomesticos proc8 = new Electrodomesticos("Cafetera", 3400);
            Electrodomesticos proc9 = new Electrodomesticos("Aspiradora", 7800);
            Electrodomesticos proc10 = new Electrodomesticos("Ventilador", 4000);

            inventario.Add(proc1);
            inventario.Add(proc2);
            inventario.Add(proc3);
            inventario.Add(proc4);
            inventario.Add(proc5);
            inventario.Add(proc6);
            inventario.Add(proc7);
            inventario.Add(proc8);
            inventario.Add(proc9);
            inventario.Add(proc10);
        }
        {
            Mascotas prt1 = new Mascotas("Shampoo Antipulgas", 119.00);
            Mascotas prt2 = new Mascotas("Croquetas", 40.00);
            Mascotas prt3 = new Mascotas("Aliemento Humedo Para Gatos", 25.00);
            Mascotas prt4 = new Mascotas("Cama Acolchonada Para Peroos", 150.00);
            Mascotas prt5 = new Mascotas("Rascador De Gatos", 67.00);
            Mascotas prt6 = new Mascotas("Jaula De Metal Para Pajaros", 250.00);
            Mascotas prt7 = new Mascotas("Acuario De Vidrio", 450.00);
            Mascotas prt8 = new Mascotas("Arenero Con Pala Para Gatos", 89.00);
            Mascotas prt9 = new Mascotas("Correa Para Perros", 35.00);
            Mascotas prt10 = new Mascotas("Collar Antipulgas", 159.00);

            inventario.Add(prt1);
            inventario.Add(prt2);
            inventario.Add(prt3);
            inventario.Add(prt4);
            inventario.Add(prt5);
            inventario.Add(prt6);
            inventario.Add(prt7);
            inventario.Add(prt8);
            inventario.Add(prt9);
            inventario.Add(prt10);
        }
        {
            Jugueteria prodt1 = new Jugueteria("Figura De Accion", "Max Steel");
            Jugueteria prodt2 = new Jugueteria("Figura De Accion", "Barbie");
            Jugueteria prodt3 = new Jugueteria("Casa De Muñecas", "Poolie Poket");
            Jugueteria prodt4 = new Jugueteria("Coche De Control Remoto", "Hasbro");
            Jugueteria prodt5 = new Jugueteria("Set De Construccion Creativa", "Lego");
            Jugueteria prodt6 = new Jugueteria("Juego De Mesa", "Monopoly");
            Jugueteria prodt7 = new Jugueteria("Pelota De Futbol", "Vans");
            Jugueteria prodt8 = new Jugueteria("Set De Plastlinas", "Playdoo");
            Jugueteria prodt9 = new Jugueteria("Juego De Quimica", "Mi Alegria");
            Jugueteria prodt10 = new Jugueteria("Peluche Animal De Compañia", "Pokemon");

            inventario.Add(prodt1);
            inventario.Add(prodt2);
            inventario.Add(prodt3);
            inventario.Add(prodt4);
            inventario.Add(prodt5);
            inventario.Add(prodt6);
            inventario.Add(prodt7);
            inventario.Add(prodt8);
            inventario.Add(prodt9);
            inventario.Add(prodt10);

        }
        {
            Ropa pct1 = new Ropa("Chamarra Invernal", 699.99);
            Ropa pct2 = new Ropa("Falda De Niña", 189.00);
            Ropa pct3 = new Ropa("Sueter Caballero", 450.00);
            Ropa pct4 = new Ropa("Short Dama", 119.99);
            Ropa pct5 = new Ropa("Pantalon De Mesclilla Unisex", 268.00);
            Ropa pct6 = new Ropa("Cinturon Caballero", 109.99);
            Ropa pct7 = new Ropa("Botas Dama", 799.99);
            Ropa pct8 = new Ropa("Playera Juvenil", 130.00);
            Ropa pct9 = new Ropa("Playera Tipo Polo", 268.00);
            Ropa pct10 = new Ropa("Blusa Dama", 129.99);
            inventario.Add(pct1);
            inventario.Add(pct2);
            inventario.Add(pct3);
            inventario.Add(pct4);
            inventario.Add(pct5);
            inventario.Add(pct6);
            inventario.Add(pct7);
            inventario.Add(pct8);
            inventario.Add(pct9);
            inventario.Add(pct10);


        }
        //Construir el menu
        bool salir = false;
        while (!salir)
        {
            //preguntar que desea hacer el usuario
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("=== Menú ===");
            Console.WriteLine("1. Ingresar producto");
            Console.WriteLine("2. Imprimir inventario");
            Console.WriteLine("0. Salir");
            Console.Write("Ingrese una opción: ");
            int opcion = Convert.ToInt32(Console.ReadLine());
            Console.ResetColor();
            switch (opcion)
            {
                case 1:
                    //añadir un objeto nuevo
                    Console.WriteLine("=== Ingresar Producto ===");
                    Console.Write("Nombre: ");
                    string nombre = Console.ReadLine();
                    Console.Write("Marca: ");
                    string marca = Console.ReadLine();
                    Console.Write("Categoría: ");
                    string categoria = Console.ReadLine();
                    Console.WriteLine("Numero de Unidades:");
                    uint cantidad = Convert.ToUInt32(Console.ReadLine());
                    Console.Write("Precio: ");
                    double precio = Convert.ToDouble(Console.ReadLine());
                    //enviar los parametros al constructor
                    Almacén producto = new Almacén(nombre, marca, categoria, precio, cantidad);
                    inventario.Add(producto);

                    Console.WriteLine("Producto ingresado exitosamente.\n\n");
                    break;
                case 2:
                    //imprimir los productos ya previamente construidos y los recien ingresados
                    Console.WriteLine("=== Inventario ===");
                    if (inventario.Count == 0)
                    {
                        Console.WriteLine("El inventario está vacío.");
                    }
                    else
                    {
                        foreach (Almacén item in inventario)
                        {
                            Console.WriteLine(item.ToString());
                        }
                        Console.WriteLine("\n\n");
                    };
                    break;
                case 0:
                    salir = true;
                    break;
                default:
                    Console.WriteLine("Opción inválida. Por favor, ingrese una opción válida.");
                    break;
            }
        }

    }
}