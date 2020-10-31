using System;
using System.ComponentModel.DataAnnotations;

namespace Chop_ing_API.EF.Tables
{
    public class BaseTable
    {
        [Required]
        public DateTime CreadoEn { get; set; }

        [Required]
        public DateTime ModificadoEn { get; set; }

        [Required, StringLength(20)]
        public string ModificadoPor { get; set; }
    }
}
