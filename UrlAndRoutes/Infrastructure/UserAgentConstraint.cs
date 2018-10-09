using System;
using System.Web;
using System.Web.Routing;

namespace UrlAndRoutes.Infrastructure
{
    public class UserAgentConstraint : IRouteConstraint
    {
        private String requiredUserAgent;

        public UserAgentConstraint(String agentParam)
        {
            this.requiredUserAgent = agentParam;
        }

        public Boolean Match(HttpContextBase httpContext, Route route, string parameterName, RouteValueDictionary values, RouteDirection routeDirection)
        {
            return httpContext.Request.UserAgent != null &&
                   httpContext.Request.UserAgent.Contains(this.requiredUserAgent);
        }
    }
}