using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Senai_CZBooks.Domains;

#nullable disable
//Documentação EF Core
//https://docs.microsoft.com/pt-br/ef/core/managing-schemas/scaffolding

/*
    Dependências do EF Core

Microsoft.EntityFrameworkCore.SqlServer
Microsoft.EntityFrameWorkCore.SqlServer.Design
Microsoft.EntityFrameworkCore.Tools


 */



namespace Senai_CZBooks.Contexts
{
    public partial class senai_czbooks : DbContext
    {
        public senai_czbooks()
        {
        }

        public senai_czbooks(DbContextOptions<senai_czbooks> options)
            : base(options)
        {
        }

        public virtual DbSet<Autor> Autors { get; set; }
        public virtual DbSet<Categoria> Categorias { get; set; }
        public virtual DbSet<Instituicao> Instituicaos { get; set; }
        public virtual DbSet<Livro> Livros { get; set; }
        public virtual DbSet<TiposUsuario> TiposUsuarios { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source = DESKTOP-HG70OI1\\SQLEXPRESS; Initial Catalog = senai_czbooks; user Id=sa; pwd = sa132;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<Autor>(entity =>
            {
                entity.HasKey(e => e.IdAutor)
                    .HasName("PK__autor__9AE8206ACC76BAFC");

                entity.ToTable("autor");

                entity.HasIndex(e => e.NomeAutor, "UQ__autor__5D4F965E00E5C14E")
                    .IsUnique();

                entity.Property(e => e.IdAutor).HasColumnName("idAutor");

                entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");

                entity.Property(e => e.NomeAutor)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("nomeAutor");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Autors)
                    .HasForeignKey(d => d.IdUsuario)
                    .HasConstraintName("FK__autor__idUsuario__46E78A0C");
            });

            modelBuilder.Entity<Categoria>(entity =>
            {
                entity.HasKey(e => e.IdCategoria)
                    .HasName("PK__categori__8A3D240CDC99BD68");

                entity.ToTable("categorias");

                entity.HasIndex(e => e.NomeCategoria, "UQ__categori__8FC1D7377FC43873")
                    .IsUnique();

                entity.Property(e => e.IdCategoria).HasColumnName("idCategoria");

                entity.Property(e => e.NomeCategoria)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("nomeCategoria");
            });

            modelBuilder.Entity<Instituicao>(entity =>
            {
                entity.HasKey(e => e.IdInstituicao)
                    .HasName("PK__institui__8EA7AB001B8FCF6E");

                entity.ToTable("instituicao");

                entity.HasIndex(e => e.NomeInstituicao, "UQ__institui__E28517EAE58380F3")
                    .IsUnique();

                entity.Property(e => e.IdInstituicao).HasColumnName("idInstituicao");

                entity.Property(e => e.IdTiposUsuarios).HasColumnName("idTiposUsuarios");

                entity.Property(e => e.NomeInstituicao)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("nomeInstituicao");

                entity.HasOne(d => d.IdTiposUsuariosNavigation)
                    .WithMany(p => p.Instituicaos)
                    .HasForeignKey(d => d.IdTiposUsuarios)
                    .HasConstraintName("FK__instituic__idTip__00200768");
            });

            modelBuilder.Entity<Livro>(entity =>
            {
                entity.HasKey(e => e.IdLivros)
                    .HasName("PK__livros__D8159A3F0DC2180D");

                entity.ToTable("livros");

                entity.HasIndex(e => e.NomeLivro, "UQ__livros__8BE40C82BBFC8ADB")
                    .IsUnique();

                entity.HasIndex(e => e.Sinopse, "UQ__livros__C5DC17F2D97391A8")
                    .IsUnique();

                entity.Property(e => e.IdLivros).HasColumnName("idLivros");

                entity.Property(e => e.DataPublicacao)
                    .HasColumnType("date")
                    .HasColumnName("dataPublicacao");

                entity.Property(e => e.IdAutor).HasColumnName("idAutor");

                entity.Property(e => e.IdCategoria).HasColumnName("idCategoria");

                entity.Property(e => e.IdInstituicao).HasColumnName("idInstituicao");

                entity.Property(e => e.NomeLivro)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("nomeLivro");

                entity.Property(e => e.Preco)
                    .HasColumnType("smallmoney")
                    .HasColumnName("preco");

                entity.Property(e => e.Sinopse)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("sinopse");

                entity.HasOne(d => d.IdAutorNavigation)
                    .WithMany(p => p.Livros)
                    .HasForeignKey(d => d.IdAutor)
                    .HasConstraintName("FK__livros__idAutor__05D8E0BE");

                entity.HasOne(d => d.IdCategoriaNavigation)
                    .WithMany(p => p.Livros)
                    .HasForeignKey(d => d.IdCategoria)
                    .HasConstraintName("FK__livros__idCatego__04E4BC85");

                entity.HasOne(d => d.IdInstituicaoNavigation)
                    .WithMany(p => p.Livros)
                    .HasForeignKey(d => d.IdInstituicao)
                    .HasConstraintName("FK__livros__idInstit__06CD04F7");
            });

            modelBuilder.Entity<TiposUsuario>(entity =>
            {
                entity.HasKey(e => e.IdTipoUsuario)
                    .HasName("PK__tiposUsu__03006BFFB9B56FB3");

                entity.ToTable("tiposUsuarios");

                entity.HasIndex(e => e.TituloTiposUsuario, "UQ__tiposUsu__8DDB81C399C7650A")
                    .IsUnique();

                entity.Property(e => e.IdTipoUsuario).HasColumnName("idTipoUsuario");

                entity.Property(e => e.TituloTiposUsuario)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tituloTiposUsuario");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuarios)
                    .HasName("PK__usuarios__3940559ADA58F69E");

                entity.ToTable("usuarios");

                entity.HasIndex(e => e.NomeUsuario, "UQ__usuarios__8C9D1DE5E09B6913")
                    .IsUnique();

                entity.HasIndex(e => e.Email, "UQ__usuarios__AB6E61647E5ECC2A")
                    .IsUnique();

                entity.HasIndex(e => e.Senha, "UQ__usuarios__D8D98E82059412A0")
                    .IsUnique();

                entity.Property(e => e.IdUsuarios).HasColumnName("idUsuarios");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.IdTiposUsuarios).HasColumnName("idTiposUsuarios");

                entity.Property(e => e.NomeUsuario)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("nomeUsuario");

                entity.Property(e => e.Senha)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("senha");

                entity.HasOne(d => d.IdTiposUsuariosNavigation)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.IdTiposUsuarios)
                    .HasConstraintName("FK__usuarios__idTipo__4316F928");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
