using Kambao.Data.Configuration;
using Kambao.Core;
using Kambao.Data;
using NHibernate.Context;
using Restfulie.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace Kambao.Controllers
{
    [ActAsRestfulie]
    public partial class EquipesController : CrudController<Equipe>
    {
        public EquipesController()
        {

        }

        public EquipesController(CrudData<Equipe> data)
            : base(data)
        {

        }

        public string ListAll()
        {
            string json = new JavaScriptSerializer().Serialize(Data.List());
            return json;
        }
    }
}
