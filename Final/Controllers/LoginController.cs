using Final.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace Final.Controllers
{
    [RoutePrefix("api/users")]
    public class LoginController : ApiController
    {
        [BasicAuthentication]
        public string Get()
        {
            return "WebAPI Method Called";
        }

    }
}
