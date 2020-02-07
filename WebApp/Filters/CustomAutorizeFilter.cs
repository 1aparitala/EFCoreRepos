using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
namespace WebApp.Filters
{
    public class CustomAutorizeFilter:Attribute,IAuthorizationFilter//, IActionFilter
    {

        public string Roles{ get; set; }

        //public void OnActionExecuted(ActionExecutedContext context)
        //{
        //    throw new NotImplementedException();
        //}

        //public void OnActionExecuting(ActionExecutingContext context)
        //{
        //    throw new NotImplementedException();
        //}

        public  void OnAuthorization(AuthorizationFilterContext context)
        {
            //if (context.HttpContext.User.Identity.IsAuthenticated)
            //{
            //    if (!context.HttpContext.User.IsInRole(Roles)) { 
            //    context.Result = new RedirectToActionResult("UnAutorize","Account",null);
            //    }
            //}
            //else
            //{
            //    context.Result = new RedirectToActionResult("Login","Account",null);
            //}
        }
    }
}
