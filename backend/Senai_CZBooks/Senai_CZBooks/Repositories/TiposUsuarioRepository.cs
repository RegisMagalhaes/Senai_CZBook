using Senai_CZBooks.Contexts;
using Senai_CZBooks.Domains;
using Senai_CZBooks.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai_CZBooks.Repositories
{
    /// <summary>
    /// Classe responsável pelo repositório dos tipos de usuarios
    /// </summary>
    public class TiposUsuarioRepository : ITiposUsuariosRepository
    {
        /// <summary>
        /// Objeto Contexto por onde serão chamados os métodos do EF Core
        /// </summary>
        senai_czbooks ctx = new senai_czbooks();
        /// <summary>
        /// Atualiza um tipo de Usuario existente
        /// </summary>
        /// <param name="id">Id do tipo de usuario que será atualizado</param>
        /// <param name="tipoUsuarioAtualizado">Objeto tipo de UsuarioAtualizado com as novas informações</param>
        public void Atualizar(int id, TiposUsuario tipoUsuarioAtualizado)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Busca um tipo de evento através do seu ID
        /// </summary>
        /// <param name="id">ID do tipo de usuario que será buscado</param>
        /// <returns>um tipo de evento encontrado</returns>
        public TiposUsuario BuscarPorId(int id)
        {
            senai_czbooks ctx = new senai_czbooks();
            throw new NotImplementedException();
        }
        /// <summary>
        /// cadastra um tipo de usuário
        /// </summary>
        /// <param name="novoTipoUsuario">Objeto novo tipo de usuario que será cadastrado</param>
        public void Cadastrar(TiposUsuario novoTipoUsuario)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Deleta um tipo de usuario existente
        /// </summary>
        /// <param name="id">ID do tipo de usuario a ser deletado</param>
        public void Deletar(int id)
        {
            
            throw new NotImplementedException();
        }

     
        /// <summary>
        /// Lista todos os tipos de usuários 
        /// </summary>
        /// <returns>Uma lista de tipos de usuários</returns>
        public List<TiposUsuario> ListarTodos()
        {

            return ctx.TiposUsuarios.ToList();
        }
    }
}
