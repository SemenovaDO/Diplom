namespace Box
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Заказ материала")]
    public partial class Заказ_материала
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Номер { get; set; }

        [Column("Дата заказа")]
        public DateTime Дата_заказа { get; set; }

        public int Артикул { get; set; }

        [Required]
        [StringLength(50)]
        public string Заказчик { get; set; }

        [Required]
        [StringLength(50)]
        public string Стоимость { get; set; }

        [Required]
        [StringLength(50)]
        public string Статус { get; set; }

        public virtual Пользователь Пользователь { get; set; }
    }
}
