using System;
using System.Collections.Generic;

#nullable disable

namespace Senai_CZBooks.Domains
{
    public partial class Instituicao
    {
        public Instituicao()
        {
            Livros = new HashSet<Livro>();
        }

        public int IdInstituicao { get; set; }
        public int? IdTiposUsuarios { get; set; }
        public string NomeInstituicao { get; set; }

        public virtual TiposUsuario IdTiposUsuariosNavigation { get; set; }
        public virtual ICollection<Livro> Livros { get; set; }
    }
}
