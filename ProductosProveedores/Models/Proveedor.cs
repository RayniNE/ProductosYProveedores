using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProductosProveedores.Models
{
    public class Proveedor
    {
        public int ID { get; set; }
        public string NOMBRE { get; set; }
        public string DIRECCION { get; set; }
        public string NUM_TELEF { get; set; }
    }
}
