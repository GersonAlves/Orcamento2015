﻿using FluentNHibernate.Mapping;
using Orcamento.Domain.Entities.Monitoramento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orcamento.Domain.Mapping.Entities
{
    public class CargaMap : ClassMap<Carga>
    {
        public  CargaMap()
        {
            Id(x => x.Id).GeneratedBy.Guid();
            Map(x => x.DataCriacao);
            Map(x => x.DataFim);
            Map(x => x.DataInicio);
            Map(x => x.Diretorio);
            References(x => x.Usuario);
            HasMany(x => x.Detalhes).Cascade.AllDeleteOrphan().LazyLoad();
        }
    }
}
