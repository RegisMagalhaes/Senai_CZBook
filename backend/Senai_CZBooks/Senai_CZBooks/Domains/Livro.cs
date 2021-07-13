using System;
using System.Collections.Generic;

#nullable disable

namespace Senai_CZBooks.Domains
{
    public partial class Livro
    {
        public int IdLivros { get; set; }
        public int? IdCategoria { get; set; }
        public int? IdAutor { get; set; }
        public int? IdInstituicao { get; set; }
        public string NomeLivro { get; set; }
        public string Sinopse { get; set; }
        public DateTime? DataPublicacao { get; set; }
        public decimal? Preco { get; set; }

        public virtual Autor IdAutorNavigation { get; set; }
        public virtual Categoria IdCategoriaNavigation { get; set; }
        public virtual Instituicao IdInstituicaoNavigation { get; set; }
    }
}
