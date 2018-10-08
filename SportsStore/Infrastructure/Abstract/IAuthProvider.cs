﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsStore.Infrastructure.Abstract
{
    public interface IAuthProvider
    {
        Boolean Authenticate(String userName, String password);
    }
}
