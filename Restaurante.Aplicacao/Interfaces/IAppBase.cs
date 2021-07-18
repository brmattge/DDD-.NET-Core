using Restaurante.Aplicacao.DTO;
using Restaurante.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurante.Aplicacao.Interfaces
{
    public interface IAppBase<TEntidade, TEntidadeDTO>
        where TEntidade : EntidadeBase
        where TEntidadeDTO : DTOBase
    {
        IEnumerable<TEntidadeDTO> SelecionarTodos();
        TEntidadeDTO SelecionarPorId(int id);
        int Incluir(TEntidadeDTO entidade);
        void Alterar(TEntidadeDTO entidade);
        void ExcluirPorId(int id);
    }
}
