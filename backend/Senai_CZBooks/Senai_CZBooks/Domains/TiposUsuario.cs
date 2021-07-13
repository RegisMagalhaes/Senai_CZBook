using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Senai_CZBooks.Domains
{
    /// <summary>
    /// Classe que representa a entidade (tabela) de tipos de Usuários
    /// </summary>
    public partial class TiposUsuario
    {
        public TiposUsuario()
        {
            Instituicaos = new HashSet<Instituicao>();
            Usuarios = new HashSet<Usuario>();
        }

        public int IdTipoUsuario { get; set; }

        [Required(ErrorMessage ="O título do tipo de Usuário é obrigatorio - Ex: Administrador, Cliente, Autor"]
        public string TituloTiposUsuario { get; set; }

        public virtual ICollection<Instituicao> Instituicaos { get; set; }
        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
