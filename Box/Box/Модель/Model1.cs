namespace Box
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Город> Город { get; set; }
        public virtual DbSet<Заказ_изделия> Заказ_изделия { get; set; }
        public virtual DbSet<Заказ_материала> Заказ_материала { get; set; }
        public virtual DbSet<Пользователь> Пользователь { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Город>()
                .Property(e => e.Название)
                .IsUnicode(false);

            modelBuilder.Entity<Заказ_изделия>()
                .Property(e => e.Заказчик)
                .IsUnicode(false);

            modelBuilder.Entity<Заказ_изделия>()
                .Property(e => e.Стоимость)
                .IsUnicode(false);

            modelBuilder.Entity<Заказ_изделия>()
                .Property(e => e.Статус)
                .IsUnicode(false);

            modelBuilder.Entity<Заказ_материала>()
                .Property(e => e.Заказчик)
                .IsUnicode(false);

            modelBuilder.Entity<Заказ_материала>()
                .Property(e => e.Стоимость)
                .IsUnicode(false);

            modelBuilder.Entity<Заказ_материала>()
                .Property(e => e.Статус)
                .IsUnicode(false);

            modelBuilder.Entity<Пользователь>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Пользователь>()
                .Property(e => e.Пароль)
                .IsUnicode(false);

            modelBuilder.Entity<Пользователь>()
                .Property(e => e.Фамилия)
                .IsUnicode(false);

            modelBuilder.Entity<Пользователь>()
                .Property(e => e.Имя)
                .IsUnicode(false);

            modelBuilder.Entity<Пользователь>()
                .Property(e => e.Отчество)
                .IsUnicode(false);

            modelBuilder.Entity<Пользователь>()
                .Property(e => e.Роль)
                .IsUnicode(false);

            modelBuilder.Entity<Пользователь>()
                .Property(e => e.Пол)
                .IsUnicode(false);

            modelBuilder.Entity<Пользователь>()
                .Property(e => e.Страна)
                .IsUnicode(false);

            modelBuilder.Entity<Пользователь>()
                .Property(e => e.Телефон)
                .IsUnicode(false);

            modelBuilder.Entity<Пользователь>()
                .HasMany(e => e.Заказ_изделия)
                .WithRequired(e => e.Пользователь)
                .HasForeignKey(e => e.Заказчик)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Пользователь>()
                .HasMany(e => e.Заказ_материала)
                .WithRequired(e => e.Пользователь)
                .HasForeignKey(e => e.Заказчик)
                .WillCascadeOnDelete(false);
        }
    }
}
