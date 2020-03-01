using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductosProveedores.Models
{
    public class GestorProveedores
    {
        private static List<Proveedor> proveedores;

        public List<Proveedor> Proveedores
        {
            get
            {
                if (proveedores == null)
                {
                    proveedores = new List<Proveedor>();
                }
                return proveedores;
            }
        }

        public void AgregarProveedor(Proveedor proveedor)
        {
            Proveedores.Add(proveedor);
        }

        public Proveedor ObtenerProveedor(int id)
        {
            foreach (var proveedor in Proveedores)
            {
                if (proveedor.ID == id)
                {
                    return proveedor;
                }
            }
            return null;
        }

        public void EliminarProveedor(int id)
        {
            foreach (Proveedor proveedor in Proveedores)
            {
                if (proveedor.ID == id)
                {
                    Proveedores.Remove(proveedor);
                    break;
                }
            }
        }

        public List<Proveedor> EditarProveedor(int Id, Proveedor proveedor)
        {
            var id = Proveedores.FindIndex(x => x.ID == Id);
            Proveedores[id] = proveedor;
            return Proveedores;
        }
    }
}
