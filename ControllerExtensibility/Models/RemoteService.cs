using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;

namespace ControllerExtensibility.Models
{
    public class RemoteService
    {
        public String GetRemotrData()
        {
            Thread.Sleep(2000);
            return "Hello from the other side of the world";

        }
    }
}