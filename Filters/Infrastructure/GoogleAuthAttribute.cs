using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Filters;
using System.Web.Routing;

namespace Filters.Infrastructure
{
    public class GoogleAuthAttribute : FilterAttribute, IAuthenticationFilter
    {
        public void OnAuthentication(AuthenticationContext filterContext)
        {
            HttpContext context = HttpContext.Current;
            
            IIdentity ident = filterContext.Principal.Identity;
            if (ident.IsAuthenticated || !ident.Name.EndsWith("@google.com"))
            {
                filterContext.Result = new HttpUnauthorizedResult();
            }
            //throw new NotImplementedException();
        }

        public void OnAuthenticationChallenge(AuthenticationChallengeContext filterContext)
        {
            if (filterContext.Result == null || filterContext.Result is HttpUnauthorizedResult)
            {
                filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary() { { "controller", "googleAccount" }, { "action", "Login" }, { "returnUrl", filterContext.HttpContext.Request.RawUrl } });
            }
            //throw new NotImplementedException();
        }

    }
}