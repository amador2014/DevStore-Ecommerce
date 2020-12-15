using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace DevStore.WebApi.Models
{
    public partial class dbDevStoreContext : DbContext
    {
        public dbDevStoreContext()
        {
        }

        public dbDevStoreContext(DbContextOptions<dbDevStoreContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Adress> Adresses { get; set; }
        public virtual DbSet<CartItem> CartItems { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Discount> Discounts { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<PerfilUser> PerfilUsers { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=dbDevStore;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<Adress>(entity =>
            {
                entity.ToTable("Adress");

                entity.Property(e => e.Bairro)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Cep)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cidade)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Complemento)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Ddd)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("DDD")
                    .IsFixedLength(true);

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Logradouro)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Adresses)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__Adress__UserId__5441852A");
            });

            modelBuilder.Entity<CartItem>(entity =>
            {
                entity.HasKey(e => e.CartId)
                    .HasName("PK__CartItem__51BCD7B79BBA55CE");

                entity.ToTable("CartItem");

                entity.Property(e => e.ProductQuantity).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.CartItems)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK__CartItem__Produc__4AB81AF0");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.CartItems)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__CartItem__UserId__4BAC3F29");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("Category");

                entity.HasIndex(e => e.CategoryName, "UQ__Category__8517B2E005F0C1A5")
                    .IsUnique();

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Discount>(entity =>
            {
                entity.ToTable("Discount");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.NewPrice).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.Discounts)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK__Discount__Produc__412EB0B6");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.Property(e => e.AmountPaid).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.MobileNumber)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.OrderDate).HasColumnType("datetime");

                entity.Property(e => e.PaymentType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Cart)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.CartId)
                    .HasConstraintName("FK__Orders__CartId__5165187F");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__Orders__UserId__5070F446");
            });

            modelBuilder.Entity<PerfilUser>(entity =>
            {
                entity.HasKey(e => e.IdPerfil)
                    .HasName("PK__PerfilUs__C7BD5CC12378CC7F");

                entity.ToTable("PerfilUser");

                entity.Property(e => e.PerfilType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Product");

                entity.HasIndex(e => e.ProductName, "UQ__Product__DD5A978AF39CFAE6")
                    .IsUnique();

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.IsAvaliable).HasDefaultValueSql("((1))");

                entity.Property(e => e.PricePerUnity).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ProductImage).IsRequired();

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK__Product__Categor__3D5E1FD2");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasIndex(e => e.Email, "UQ__Users__A9D105348DA2B515")
                    .IsUnique();

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProfileImage).IsRequired();

                entity.HasOne(d => d.IdPerfilNavigation)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.IdPerfil)
                    .HasConstraintName("FK__Users__IdPerfil__46E78A0C");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
