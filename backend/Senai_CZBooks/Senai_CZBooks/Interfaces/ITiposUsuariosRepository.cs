using Senai_CZBooks.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai_CZBooks.Interfaces
{
    /// <summary>
    /// Interface responsável pelo repositório TiposUsuarioRepository
    /// </summary>
    interface ITiposUsuariosRepository
    {
        //Definição dos métodoss, seguem a estrutura:
        //tipoRetorno nomeMetodo(tipoParâmetros nomeParametro);

        /// <summary>
        /// Lista todos os tipos de usuários 
        /// </summary>
        /// <returns>Uma lista de tipos de usuários</returns>
        List<TiposUsuario> ListarTodos();


        /// <summary>
        /// Busca um tipo de evento através do seu ID
        /// </summary>
        /// <param name="id">ID do tipo de usuario que será buscado</param>
        /// <returns>um tipo de evento encontrado</returns>
        TiposUsuario BuscarPorId(int id);

        /// <summary>
        /// cadastra um tipo de usuário
        /// </summary>
        /// <param name="novoTipoUsuario">Objeto novo tipo de usuario que será cadastrado</param>
        void Cadastrar(TiposUsuario novoTipoUsuario);

        /// <summary>
        /// Atualiza um tipo de Usuario existente
        /// </summary>
        /// <param name="id">Id do tipo de usuario que será atualizado</param>
        /// <param name="tipoUsuarioAtualizado">Objeto tipo de UsuarioAtualizado com as novas informações</param>
        void Atualizar(int id, TiposUsuario tipoUsuarioAtualizado);

        /// <summary>
        /// Deleta um tipo de usuario existente
        /// </summary>
        /// <param name="id">ID do tipo de usuario a ser deletado</param>
        void Deletar(int id);
    }

    
}
