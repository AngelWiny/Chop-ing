using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Chop_ing_API.EF.Tables
{
    public class Articulo : BaseTable
    {
        [Required, Key, StringLength(15)]
        public string Articulo_Id { get; set; }

        [Required, StringLength(100)]
        public string Articulo_Nombre { get; set; }

        [Required, StringLength(2000)]
        public string Articulo_Descripcion { get; set; }

        [Required, Column(TypeName = "money")]
        public decimal Articulo_Precio { get; set; }
    }
}
