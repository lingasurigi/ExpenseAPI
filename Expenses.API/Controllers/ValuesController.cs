using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ExpenseAPI.Common.Auth;
using ExpenseAPI.Models;

namespace ExpenseAPI.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get(HttpRequestMessage requestMessage)
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }

        [HttpPost, Route("api/account/login")]
        public HttpResponseMessage login(string UserName, string Password)
        {
            string returnedToken;
            //var result = new DataResult<LoginModel>();
            try
            {
                //Step 1: check from database using user id and password, is user is valid or not  
                //result = AccountService.login(UserName.ToLower().Trim(), Password.ToLower().Trim());
                //Step 2: if user is valid then generate token for him and return that token  
                //if (result.Success) result.Data.AccessToken = JwtManager.GenerateToken(result.Data.UserName);
                returnedToken  = JwtManager.GenerateToken(UserName);
                return Request.CreateResponse(HttpStatusCode.OK, returnedToken);
            }
            catch
            {
                //result.Errors.Add("Invalid username or password");
                //result.StatusCode = APIStatusCode.Unauthorized;
            }
            return Request.CreateResponse(HttpStatusCode.OK, "");
        }
    }
}
