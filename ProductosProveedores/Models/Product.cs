using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProductosProveedores.Models
{
    public class Product
    {
        [Required]
        public int ID { get; set; }
        public string NOMBRE { get; set; }
        public string DESCRIPCION { get; set; }
        [DataType(DataType.Date)]
        public DateTime FECHA_VEN { get; set; }
        public int ID_PROVEEDOR { get; set; }
    }
}
