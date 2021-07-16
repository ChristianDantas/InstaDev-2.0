using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using InstaDev_WebApi.Domains;

#nullable disable

namespace InstaDev_WebApi.Contexts
{
    public partial class InstaDevContext : DbContext
    {
        public InstaDevContext()
        {
        }

        public InstaDevContext(DbContextOptions<InstaDevContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Publicacao> Publicacaos { get; set; }
        public virtual DbSet<TipoUsuario> TipoUsuarios { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=LAB08DESK2301\\SqlExpress; Initial Catalog= InstaDev;user=sa ; password=sa@132");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<Publicacao>(entity =>
            {
                entity.HasKey(e => e.IdPublicacao)
                    .HasName("PK__Publicac__0473E74B0B079923");

                entity.ToTable("Publicacao");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("descricao");

                entity.Property(e => e.ImagemPub).HasColumnType("image");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Publicacaos)
                    .HasForeignKey(d => d.IdUsuario)
                    .HasConstraintName("FK__Publicaca__IdUsu__3E52440B");
            });

            modelBuilder.Entity<TipoUsuario>(entity =>
            {
                entity.HasKey(e => e.IdTipo)
                    .HasName("PK__TipoUsua__9E3A29A5D8C60B3B");

                entity.ToTable("TipoUsuario");

                entity.Property(e => e.NomeTipo)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario)
                    .HasName("PK__Usuario__5B65BF972F5559F5");

                entity.ToTable("Usuario");

                entity.HasIndex(e => e.Indentificacao, "UQ__Usuario__7FFCFC8A56ABB3AD")
                    .IsUnique();

                entity.HasIndex(e => e.Email, "UQ__Usuario__A9D105341166FBF3")
                    .IsUnique();

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FotoPerfil)
                    .HasColumnType("image")
                    .HasColumnName("fotoPerfil");

                entity.Property(e => e.Indentificacao)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NomeUsuario)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Senha)
                    .IsRequired()
                    .HasMaxLength(24)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdTipoNavigation)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.IdTipo)
                    .HasConstraintName("FK__Usuario__IdTipo__3B75D760");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
