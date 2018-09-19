using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading;
using System.Threading.Tasks;
using System.Net.Http;

namespace LanguageFeatures.Models
{
    public class MyAsyncMethods
    {
        public static Task<Int64?> GetPageLength()
        {
            HttpClient client = new HttpClient();
            var httpTask = client.GetAsync("http://apress.com");
            return httpTask.ContinueWith((antecedent) =>
            {
                return antecedent.Result.Content.Headers.ContentLength;
            });
        }
    }
}