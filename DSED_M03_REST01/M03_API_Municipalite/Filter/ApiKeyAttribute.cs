using M03_DAL_Municipalite;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace M03_API_Municipalite.Filter
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class ApiKeyAttribute : Attribute, IAsyncActionFilter
    {
        //const string clefValide = "59604896-66a4-4a9b-8f7b-94a5d16bbdaf";

        public async Task OnActionExecutionAsync(ActionExecutingContext p_context, ActionExecutionDelegate p_next)
        {
            ApplicationDbContext appContext = p_context.HttpContext.RequestServices.GetService<ApplicationDbContext>();
            DepotMunicipalitesSQL m_depotMunicipalitesSQL = new DepotMunicipalitesSQL(appContext);

            StringValues clefAPI;

            if (!p_context.HttpContext.Request.Headers.TryGetValue("clefAPI", out clefAPI))
            {
                p_context.Result = new UnauthorizedResult();
                return;
            }

            if (!m_depotMunicipalitesSQL.IsValidKey(Guid.Parse(clefAPI)))
            {
                p_context.Result = new UnauthorizedResult();
                return;
            }

            await p_next();
        }
    }
}
