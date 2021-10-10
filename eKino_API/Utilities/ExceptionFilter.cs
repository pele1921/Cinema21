using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Net.Http;
using System.Web.Http.Filters;

namespace eKino_API.Utilities
{
    public class ExceptionFilter : ExceptionFilterAttribute
    {
        public override void OnException(HttpActionExecutedContext actionExecutedContext)
        {
            if (actionExecutedContext.Exception is NotImplementedException)
            {
                HttpResponseMessage msg = new HttpResponseMessage()
                {
                    StatusCode = System.Net.HttpStatusCode.PaymentRequired,
                    ReasonPhrase = "ReasonPhrase",
                    Content = new StringContent("Content")
                };

                actionExecutedContext.Response = msg;
            }
            else
                base.OnException(actionExecutedContext);
        }
    }
}