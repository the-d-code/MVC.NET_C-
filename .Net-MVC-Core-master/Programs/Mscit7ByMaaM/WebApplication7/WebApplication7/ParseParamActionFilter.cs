using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication7
{
    public class ParseParameterActionFilter : Attribute, IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext context)
        {
            object param;
            if (context.ActionArguments.TryGetValue("param", out param))
                context.ActionArguments["param"] = param.ToString().ToUpper();
            else
                context.ActionArguments.Add("param", "I come from action filter");
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            //context.ActionArguments.Add("param", "Helloworld");
        }
    }
}
