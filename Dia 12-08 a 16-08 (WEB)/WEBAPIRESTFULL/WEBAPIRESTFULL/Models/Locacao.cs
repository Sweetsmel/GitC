namespace WEBAPIRESTFULL.Models
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Locacao")]
    public partial class Locacao : UserControls
    {
        public int Id { get; set; }

        public int Livro { get; set; }

        public int Usuario { get; set; }

        public int Tipo { get; set; }

        public DateTime Devolucao { get; set; }

        [JsonIgnore]
        public virtual Livros Livros { get; set; }
        [JsonIgnore]
        public virtual Usuarios Usuarios { get; set; }
        [JsonIgnore]
        public virtual Usuarios Usuarios1 { get; set; }
        [JsonIgnore]
        public virtual Usuarios Usuarios2 { get; set; }
    }
}
