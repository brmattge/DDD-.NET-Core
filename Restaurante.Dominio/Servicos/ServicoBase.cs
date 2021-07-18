using Restaurante.Dominio.Entidades;
using Restaurante.Dominio.Interfaces.Repositorios;
using Restaurante.Dominio.Interfaces.Servicos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurante.Dominio.Servicos
{
    public class ServicoBase<TEntidade> : IServicoBase<TEntidade>
        where TEntidade: EntidadeBase
    {
        protected readonly IRepositorioBase<TEntidade> repositorio;

        public ServicoBase(IRepositorioBase<TEntidade> repositorio)
        {
            this.repositorio = repositorio;
        }

        public IEnumerable<TEntidade> SelecionarTodos()
        {
            return repositorio.SelecionarTodos();
        }

        public TEntidade SelecionarPorId(int id)
        {
            return repositorio.SelecionarPorId(id);
        }

        public int Incluir(TEntidade entidade)
        {
            return repositorio.Incluir(entidade);
        }

        public void Alterar(TEntidade entidade)
        {
            repositorio.Alterar(entidade);
        }

        public void ExcluirPorId(int id)
        {
            repositorio.ExcluirPorId(id);
        }
    }
}
