using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LearnNotes.Controllers
{
    public class LoginController : ApiController
    {
        [HttpGet]
        [Route("api/login/savelogininfo/{loginname}/{password}")]
        public HttpResponseMessage SaveLoginInfo(string LoginName ,string PassWord)
        {

            return Request.CreateResponse(HttpStatusCode.OK, LoginName + PassWord);
        }
    }
}
