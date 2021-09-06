namespace Box
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Город
    {
        [Key]
        [StringLength(60)]
        public string Название { get; set; }
    }
}
