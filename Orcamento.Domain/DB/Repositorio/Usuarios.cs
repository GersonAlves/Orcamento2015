﻿using Orcamento.Domain.Gerenciamento;
using System.Linq;
using System.Collections.Generic;

namespace Orcamento.Domain.DB.Repositorio
{
    public class Usuarios : BaseRepository
    {
        public virtual Usuario ObterAcesso(string login, string senha)
        {
            return Session.QueryOver<Usuario>().Where(x => x.Login == login).And(y => y.Senha == senha).SingleOrDefault();
        }

        public virtual List<Usuario> ObterPor(Departamento departamento)
        {
            return Session.QueryOver<Usuario>().JoinQueryOver(d => d.Departamentos).Where(u => u.ToList().Any(ui => ui.Id == departamento.Id)).List<Usuario>().ToList();
        }

        public virtual Usuario ObterUsuarioPorId(int id)
        {
            return Session.QueryOver<Usuario>().Where(x => x.Id == id).SingleOrDefault();
        }

        public virtual List<Usuario> TodosPor(TipoUsuario tipo)
        {
            return Session.QueryOver<Usuario>().Where(u => u.TipoUsuario == tipo).List<Usuario>().ToList();
        }

        public virtual void Deletar(List<Usuario> roots)
        {
            var transaction = Session.BeginTransaction();
            try
            {

                foreach (var root in roots)
                {
                    Session.Delete(root);
                }

                transaction.Commit();
            }
            catch (System.Exception ex)
            {
                transaction.Rollback();
                throw ex;
            }


        }
    }


}