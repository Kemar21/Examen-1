using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalMachines
{
    class Program
    {

        static Productos producto = new Productos();

        static int opcion = 0;
        static int tamanno = 6;
        [Flags]
        enum ProductosNivel
        {
            nivelAlto = 1,
            nivelMedioAlto = 2,
            nivelMedio = 3,
            nivelMedioBajo = 4,
            nivelBajo = 5,
        };


        static void ingresoProducto()
        {

            int i = 0;
            int j = 0;
            while (i != 0)
            {
                Console.Clear();
                if (i < producto.tamanno)
                {
                    Console.WriteLine("Ingreso de productos...");
                    Console.WriteLine("Ingrese el codigo del procuto");
                    producto.setCodigoArticulo(int.Parse(Console.ReadLine()));
                    Console.WriteLine("Ingrese el nombre del producto");
                    producto.setNombreArticulo(Console.ReadLine());
                    Console.WriteLine("Ingrese el tipo del producto");
                    producto.setTipo(Console.ReadLine());
                    Console.WriteLine("Ingrese la fecha de vencimiento del producto");
                    producto.setFechaVencimiento(int.Parse(Console.ReadLine()));
                    Console.WriteLine("Ingrese el proveedor del producto");
                    producto.setNombreProveedor(Console.ReadLine());
                    Console.WriteLine("Ingrese la posicion del producto");
                    Console.WriteLine(ProductosNivel.nivelAlto + "    " + (int)ProductosNivel.nivelAlto + "\n"
                    + ProductosNivel.nivelMedioAlto + "   " + (int)ProductosNivel.nivelMedioAlto + "\n" +
                    ProductosNivel.nivelMedio + "   " + (int)ProductosNivel.nivelMedio + "\n" +
                    ProductosNivel.nivelMedioBajo + "" + (int)ProductosNivel.nivelMedioBajo + "\n" +
                    ProductosNivel.nivelBajo + "" + (int)ProductosNivel.nivelBajo + "\n");
                    producto.setPosicionEstante(int.Parse(Console.ReadLine()));
                    if (producto.ingresoProducto(producto) == true)
                    {
                        Console.WriteLine("El producto ha sido agregado");
                    }
                    else
                    {
                        Console.WriteLine("El producto no se ha agregado correctamente ");
                        i = int.Parse(Console.ReadLine());
                        j++;
                        Console.ReadKey();
                    }
                }


            }

        }
        static void modificarProducto()
        {
            int reg = 0;
            int r = 1;
            while (r != 1)
            {
                Console.Clear();
                Console.WriteLine("Digite el ID del libro que desea modificar");
                int codigoProducto = int.Parse(Console.ReadLine());
                while (r != 2)
                {


                    if (producto.buscarArticulo(codigoProducto) == true)
                    {
                        Console.WriteLine("Digite el nuevo ID del libro");
                        int newCodigo = int.Parse(Console.ReadLine());

                        reg = codigoProducto;
                        Console.WriteLine("Registro: " + reg);
                        Console.WriteLine("Codigo:       " + newCodigo);
                        Console.WriteLine("Nombre:     " + producto.getNombreArticulo());
                        Console.WriteLine("Tipo:     " + producto.getTipo());
                        Console.WriteLine("Fecha de Vencimiento     " + producto.getFechaVencimiento());
                        Console.WriteLine("Nombre del proveedor     " + producto.getNombreProveedor());
                        Console.WriteLine("Posicion estante     " + producto.getPosicionEstante());
                        Console.WriteLine("Precio:   " + producto.getPrecio());
                        Console.WriteLine("Desea buscar otro libro (1)Sí (2)No");
                        r = 2;
                    }
                    else
                    {
                        Console.WriteLine("No se encontro ese ID");
                        Console.WriteLine("Desea buscar otro libro 0-Sí 1-No");
                        r = int.Parse(Console.ReadLine());
                    }
                }
            } Console.ReadKey();
        }

        static void eliminarProducto()
        {
            int reg = 0;
             int r = 1;
            while (r != 1)
            {
                Console.Clear();
                Console.WriteLine("-* Librería el Buen Lector  *-*");
                Console.WriteLine("Modificacion de libros.           ");
                Console.WriteLine("Digite el ID del libro que desea eliminar");
                int codigoProducto= int.Parse(Console.ReadLine());
                while (r != 2)
                {
                    if (producto.borrarArticulo(codigoProducto)== true)
                    {
                        codigoProducto = 0;
                        //reg = codigoProducto;
                        Console.WriteLine("Registro: " + reg);
                        Console.WriteLine("Codigo:       " + codigoProducto);
                        Console.WriteLine("Nombre:     " + producto.getNombreArticulo());
                        Console.WriteLine("Tipo:     " + producto.getTipo());
                        Console.WriteLine("Fecha de Vencimiento     " + producto.getFechaVencimiento());
                        Console.WriteLine("Nombre del proveedor     " + producto.getNombreProveedor());
                        Console.WriteLine("Posicion estante     " + producto.getPosicionEstante());
                        Console.WriteLine("Precio:   " + producto.getPrecio());
                    
                        Console.WriteLine("Desea buscar otro libro 0-Sí 1-No");
                        r = 2;
                    }
                    else
                    {
                        Console.WriteLine("No se encontro ese ID");
                        Console.WriteLine("Desea buscar otro libro 0-Sí 1-No");
                        r = int.Parse(Console.ReadLine());
                    }
                }
            } Console.ReadKey();
        }

      

        static void buscarProducto()
        {

            int reg = 0; 
            int  i = 0;
            while (i != 1)
            {
                Console.Clear();
              
                Console.WriteLine("Ingrese el codigo del producto");
                int codigoProducto = int.Parse(Console.ReadLine());
                while (i != 2)
                {
                    if (producto.buscarArticulo(codigoProducto) == true)
                    {
                        reg = codigoProducto;
                        Console.WriteLine("Registro: " + reg);
                        Console.WriteLine("Codigo del procuto:     " + producto.getCodigoArticulo());
                        Console.WriteLine("Nombre:     " + producto.getNombreArticulo());
                        Console.WriteLine("Tipo:     " + producto.getTipo());
                        Console.WriteLine("Fecha de Vencimiento     " + producto.getFechaVencimiento());
                        Console.WriteLine("Nombre del proveedor     " + producto.getNombreProveedor());
                        Console.WriteLine("Posicion estante     " + producto.getPosicionEstante());
                        Console.WriteLine("Precio:   " + producto.getPrecio());

                        i = 1;
                    }
                    else
                    {
                        Console.WriteLine("No se encontro ese codigo");
                        Console.WriteLine("Desea buscar otro libro \n 1(Sí) 2(No)");
                        i = int.Parse(Console.ReadLine());
                    }
                }
            } Console.ReadKey();
        }

        static void listadoProductos()
        {
            int reg = 0;
            int i;
            Console.Clear();

            Console.WriteLine("Listado de libros");
            for (i = 0; i < producto.tamanno; i++)
            {
                producto.imprimirRegistro(i);
                reg = i + 1;
                Console.WriteLine("Reg: " + reg);
                Console.WriteLine("Codigo del procuto:     " + producto.getCodigoArticulo());
                Console.WriteLine("Nombre:     " + producto.getNombreArticulo());
                Console.WriteLine("Tipo:     " + producto.getTipo());
                Console.WriteLine("Fecha de Vencimiento     " + producto.getFechaVencimiento());
                Console.WriteLine("Nombre del proveedor     " + producto.getNombreProveedor());
                Console.WriteLine("Posicion estante     " + producto.getPosicionEstante());
                Console.WriteLine("Precio:   " + producto.getPrecio());
            }
            Console.ReadKey();
        }
        static void Main()
        {
            //inicializar el objeto
            producto.setPrecio(tamanno);
            //producto.Registro();

            // PrintInvoice();

            do
            {
                Console.Clear();
                Console.WriteLine("-* Librería el Buen Lector  *-*");
                Console.WriteLine("1. Ingreso de libros.");
                Console.WriteLine("2. Modificación de libros.");
                Console.WriteLine("3. Eliminación de libros.");
                Console.WriteLine("4. Búsquedad de libros.");
                Console.WriteLine("5. Listado de libros.");
                Console.WriteLine("6. Venta de libros.");
                Console.WriteLine("7. Salir.");
                Console.WriteLine("Selecciones una opción");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        {
                            ingresoProducto();
                            break;
                        }
                    case 2:
                        {
                            modificarProducto();
                            //Modificar la información
                            break;
                        }
                    case 3:
                        {
                            eliminarProducto();
                            //Eliminar información dejando campos en 0 o vacío
                            break;
                        }
                    case 4:
                        {
                            buscarProducto();
                            break;
                        }
                    case 5:
                        {
                            listadoProductos();
                            break;
                        }
                    case 6:
                        {
                            //Venta similar a tarea1
                            break;
                        }
                    case 7:
                        
                        break;
                    default:
                        {
                            Console.WriteLine("Seleccione inválida..");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                }
            } while (opcion != 7);

            Console.ReadKey();
        }

        
    }
}

        











//        static void Main(string[] args)
//        {

//        }
//    }
//}
