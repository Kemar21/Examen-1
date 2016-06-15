using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalMachines
{
    class Productos
    {
        private int codigo_articulo;
        private string nombre_articulo;
        private string tipo;
        private int fecha_vencimiento;
        private string nombre_proveedor;
        private int posicion_estante;
        private int precio;
        public double tamanno;

        private struct Productos
        {
            public int codigo_articulo;
            public string nombre_articulo;
            public string tipo;
            public int fecha_vencimiento;
            public string nombre_proveedor;
            public int posion_estante;
            public int precio;

        };

        private static Productos[] producto;
        
        
        public Productos() {

            codigo_articulo = 0;
            nombre_articulo = "";
            tipo = "";
            fecha_vencimiento = 0;
            posicion_estante = 0;
            precio = 0;

           }

        public Productos(int codigo_articulo, string nombre_articulo, string tipo, int fecha_vencimiento,string nombre_proveedor, int posicion_estante, int precio)
        {
            this.codigo_articulo = codigo_articulo;
            this.nombre_articulo = nombre_articulo;
            this.tipo = tipo;
            this.fecha_vencimiento = fecha_vencimiento;
            this.nombre_proveedor = nombre_proveedor;
            this.posicion_estante = posicion_estante;
            this.precio = precio;
        }

        public void setCodigoArticulo(int codigo_articulo)
        {
            this.codigo_articulo = codigo_articulo;
        }

        public int getCodigoArticulo()
        {
            return codigo_articulo;

        }


        public void setNombreArticulo(string nombre_articulo)
        {
            this.nombre_articulo = nombre_articulo;
        }

        public string getNombreArticulo()
        {
            return nombre_articulo;
        }

        public void setTipo(string tipo)
        {
            this.tipo = tipo;
        }

        public string getTipo()
        {
            return tipo;
        }

        public void setFechaVencimiento(int fecha_vencimiento)
        {
            this.fecha_vencimiento = fecha_vencimiento;
        }

        public int getFechaVencimiento()
        {
            return fecha_vencimiento;
        }

        public void setNombreProveedor(string nombre_proveedor)
        {
            this.nombre_proveedor = nombre_proveedor;
        }

        public string getNombreProveedor()
        {
            return nombre_proveedor;
        }

        public void setPosicionEstante(int posicion_estante)
        {
            this.posicion_estante=posicion_estante;
        }

        public int getPosicionEstante()
        {
            return posicion_estante;
        }

        public void setPrecio(int precio)
        {
            this.precio = precio;
        }

        public int getPrecio()
        {
            return precio;
        }

        public void setTamanno(int Tamanno)
        {
            tamanno = Tamanno;
            producto = new Productos[Tamanno];
        }

       

        //public void Registro ()
        //{
        //    for(int i = 0; i < producto.Length; i++){

        //        producto[i].codigo_articulo = 0;
        //        producto[i].nombre_articulo = " ";
        //        producto[i].tipo = "";
        //        producto[i].fecha_vencimiento = 0;
        //        producto[i].nombre_proveedor = "";
        //        producto[i].posion_estante = 0;
        //        producto[i].precio = 0;

        //    }

        //}
      
       
        public bool ingresoProducto(Productos Producto)
            {

            int i=0;
                for (i = 0; i < producto.Length; i++)
                {
                    if (producto[i].codigo_articulo == 0)
                    {
                        break;
                    }
                }

                if (i < producto.Length)
                {
                    producto[i].codigo_articulo= codigo_articulo;
                    producto[i].nombre_articulo = nombre_articulo;
                    producto[i].tipo = tipo;
                    producto[i].fecha_vencimiento=fecha_vencimiento;
                    producto[i].nombre_proveedor = nombre_proveedor;
                    producto[i].posion_estante = posicion_estante;
                    producto[i].precio = precio;

                    return true;
                }
                else
                {
                    return false;
                }
            }

        //metodo par buscar los articulos 
          public bool buscarArticulo(int record)
            {
                int i;
                for (i = 0; i <  producto.Length; i++)
                {
                    if (producto[i].codigo_articulo == record)
                    {
                        break;
                    }
                }

                if (i < producto.Length)
                {
                    producto[i].codigo_articulo= codigo_articulo;
                    producto[i].nombre_articulo = nombre_articulo;
                    producto[i].tipo = tipo;
                    producto[i].fecha_vencimiento=fecha_vencimiento;
                    producto[i].nombre_proveedor = nombre_proveedor;
                    producto[i].posion_estante = posicion_estante;
                    producto[i].precio = precio;
                    return true;
                }
                else
                {
                    return false;
                }
            }

        public bool modificarArticulo(int articulo)
            {
                int i;
                for (i = 0; i <  producto.Length; i++)
                {
                    if (producto[i].codigo_articulo == articulo)
                    {
                        break;
                    }
                }

                if (i < producto.Length)
                {
                    producto[i].codigo_articulo= codigo_articulo;
                    producto[i].nombre_articulo = nombre_articulo;
                    producto[i].tipo = tipo;
                    producto[i].fecha_vencimiento=fecha_vencimiento;
                    producto[i].nombre_proveedor = nombre_proveedor;
                    producto[i].posion_estante = posicion_estante;
                    producto[i].precio = precio;
                    return true;
                }
                else
                {
                    return false;
                }
            }
        public bool borrarArticulo(int articulo)
            {
                int i;
                for (i = 0; i <  producto.Length; i++)
                {
                    if (producto[i].codigo_articulo == articulo)
                    {
                        break;
                    }
                }

                if (i < producto.Length)
                {
                    producto[i].codigo_articulo= codigo_articulo;
                    producto[i].nombre_articulo = nombre_articulo;
                    producto[i].tipo = tipo;
                    producto[i].fecha_vencimiento=fecha_vencimiento;
                    producto[i].nombre_proveedor = nombre_proveedor;
                    producto[i].posion_estante = posicion_estante;
                    producto[i].precio = precio;
                    return true;
                }
                else
                {
                    return false;
                }
            }

        public void imprimirRegistro(int print)
        {
            codigo_articulo = producto[print].codigo_articulo;
            nombre_articulo =producto[print].nombre_articulo;
            tipo = producto[print].tipo;
            fecha_vencimiento = producto[print].fecha_vencimiento;
            nombre_proveedor = producto[print].nombre_proveedor;
            posicion_estante = producto[print].posion_estante;
            precio = producto[print].precio;

        }
        ~Productos()
        {

        }
    }
}
