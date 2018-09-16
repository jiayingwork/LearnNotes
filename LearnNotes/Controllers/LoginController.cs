using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace LearnNotes.Controllers
{
    public class LoginController : ApiController
    {
        [HttpGet]
        [Route("api/login/savelogininfo/{loginname}/{password}")]
        public string SaveLoginInfo(string LoginName ,string PassWord)
        {

            //using (HttpClient client = new HttpClient())
            //{
            //    client.DefaultRequestHeaders.Accept.Clear();
            //    client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            //    Task<HttpResponseMessage> responT = client.get
            //}



                //先验证传过来的token
                //MD5签名对参数进行验证
                //时间戳验证
                //验证登陆信息
                string aa = JsonConvert.SerializeObject(LoginName + PassWord);
            return  aa;
        }
    }
}
