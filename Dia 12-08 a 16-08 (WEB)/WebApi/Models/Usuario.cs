namespace WebApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Usuario
    {
        public int Id { get; set; }

        //[Column("Usuario")]
        [Required]
        [StringLength(100)]
        public string Usuario1 { get; set; }

        public bool Ativo { get; set; } = true;

        public int UsuInc { get; set; } = 0;

        public int UsuAlt { get; set; } = 0;

        public DateTime DatInc { get; set; } = DateTime.Now;

        public DateTime DatAlt { get; set; } = DateTime.Now;
    }
}
