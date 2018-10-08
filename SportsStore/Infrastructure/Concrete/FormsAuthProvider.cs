using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using SportsStore.Infrastructure.Abstract;

namespace SportsStore.Infrastructure.Concrete
{
    public class FormsAuthProvider : IAuthProvider
    {
        public Boolean Authenticate(String userName, String password)
        {
            Boolean result = FormsAuthentication.Authenticate(userName, password);
            if (result)
            {
                FormsAuthentication.SetAuthCookie(userName,false);
            }
            return result;
        }
    }
}