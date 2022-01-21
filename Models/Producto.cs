using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ManitasWeb.Models
{
    [Table("t_producto")]
    public class Producto
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id")]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public Decimal Precio { get; set; }
        public String ImagenNom { get; set; }
        public Byte[] Imagen { get; set; }
        public Byte[] Imagen2 { get; set; }
        public Byte[] Imagen3 { get; set; }
        public DateTime Registro { get; set; }
        public String Estado { get; set; }
        [Column("CategId")]
        public Categoria Categ { get; set; }
        [Column("MaterId")]
        public Material Mater { get; set; }
        public string Home { get; set; }

        public Producto()
        {
            Registro = DateTime.Now;
        }
    }
}