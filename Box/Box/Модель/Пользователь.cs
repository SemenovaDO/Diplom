namespace Box
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Пользователь
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Пользователь()
        {
            Заказ_изделия = new HashSet<Заказ_изделия>();
            Заказ_материала = new HashSet<Заказ_материала>();
        }

        [Key]
        [StringLength(50)]
        public string Email { get; set; }

        [Required]
        [StringLength(50)]
        public string Пароль { get; set; }

        [Required]
        [StringLength(50)]
        public string Фамилия { get; set; }

        [Required]
        [StringLength(50)]
        public string Имя { get; set; }

        [StringLength(50)]
        public string Отчество { get; set; }

        [StringLength(50)]
        public string Роль { get; set; }

        [Required]
        [StringLength(10)]
        public string Пол { get; set; }

        [StringLength(50)]
        public string Страна { get; set; }

        [StringLength(50)]
        public string Телефон { get; set; }

        [Column("Дата рождения")]
        public DateTime? Дата_рождения { get; set; }

        [Column(TypeName = "image")]
        public byte[] Фотография { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Заказ_изделия> Заказ_изделия { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Заказ_материала> Заказ_материала { get; set; }
    }
}
