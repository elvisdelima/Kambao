﻿using FluentNHibernate.Automapping;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using Kambao.Core;

namespace Kambao.Data.Configuration
{
    public class AutoMapper
    {
        public ISessionFactory GetSessionFactory()
        {
            const string connectionString = @"Data Source=ELVIS\SQLEXPRESS;Initial Catalog=Kambao;User ID=sa;Password=sa";
            const string context = "web";

            var conventions = AutoMap.Assemblies(new MappedModels(), typeof(Tarefa).Assembly).IgnoreBase<Quadro>();
 
            var factory = Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2008.ConnectionString(connectionString))
                .CurrentSessionContext(context)
                .Mappings(m => m.AutoMappings.Add(conventions))
                .ExposeConfiguration(UpdateDatabase)
                .BuildSessionFactory();

            return factory;
        }

        private void UpdateDatabase(NHibernate.Cfg.Configuration configuration)
        {
            new SchemaUpdate(configuration).Execute(false, true);
        }
    }
}