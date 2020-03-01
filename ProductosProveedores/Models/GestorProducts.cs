using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductosProveedores.Models;

namespace ProductosProveedores.Models
{
    public class GestorProducts

    {
        private static List<Product> productos;

        public List<Product> Productos
        {
            get
            {
                if(productos == null)
                {
                    productos = new List<Product>();
                }
                return productos;
            }
        }

        public void AgregarProducto(Product product)
        {
            Productos.Add(product);
        }

        public Product ObtenerProducto(int id)
        {
            foreach(var producto in Productos)
            {
                if(producto.ID == id)
                {
                    return producto;
                }
            }
            return null;
        }

        public void EliminarProducto(int id)
        {
            foreach(Product producto in Productos)
            {
                if(producto.ID == id)
                {
                    Productos.Remove(producto);
                    break;
                }
            }
        }

        public List<Product> EditarProducto(int Id, Product producto)
        {
            var id = Productos.FindIndex(x => x.ID == Id);
            Productos[id] = producto;
            return Productos;
        }
    }
}
