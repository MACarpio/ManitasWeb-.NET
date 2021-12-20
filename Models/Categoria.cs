using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace ManitasWeb.Models
{
    [Table("t_categoria")]
    public class Categoria
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id")]
        public int Id { get; set; }
        public String NomCategoria { get; set; }
        public Byte[] Imagen { get; set; }
    }
}