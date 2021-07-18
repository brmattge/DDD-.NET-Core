using Restaurante.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurante.Dominio.Interfaces.Repositorios
{
    public interface IRepositorioBase<TEntidade>
        where TEntidade : EntidadeBase
    {
        IEnumerable<TEntidade> SelecionarTodos();
        TEntidade SelecionarPorId(int id);
        int Incluir(TEntidade entidade);
        void Alterar(TEntidade entidade);
        void ExcluirPorId(int id);
    }
}
