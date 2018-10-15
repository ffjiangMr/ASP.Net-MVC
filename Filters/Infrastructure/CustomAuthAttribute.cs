using System;
using System.Web;
using System.Web.Mvc;

namespace Filters.Infrastructure
{
    public class CustomAuthAttribute : AuthorizeAttribute
    {

        private Boolean localAllowed;

        public CustomAuthAttribute(Boolean allowedParam)
        {
            this.localAllowed = allowedParam;
        }

        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            if (httpContext.Request.IsLocal)
            {
                return this.localAllowed;
            }
            else
            {
                return true;
            }
            //return base.AuthorizeCore(httpContext);
        }

    }
}