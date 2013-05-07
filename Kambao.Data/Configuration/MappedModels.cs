using FluentNHibernate.Automapping;
using System;

namespace Kambao.Data.Configuration
{
    public class MappedModels : DefaultAutomappingConfiguration
    {
        public override bool ShouldMap(Type type)
        {
            return type.Namespace == "Kambao.Core";
               
        }        
    }
}