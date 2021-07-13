using System;
using System.Collections.Generic;

#nullable disable

namespace Senai_CZBooks.Domains
{
    public partial class Usuario
    {
        public Usuario()
        {
            Autors = new HashSet<Autor>();
        }

        public int IdUsuarios { get; set; }
        public int? IdTiposUsuarios { get; set; }
        public string NomeUsuario { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        public virtual TiposUsuario IdTiposUsuariosNavigation { get; set; }
        public virtual ICollection<Autor> Autors { get; set; }
    }
}
