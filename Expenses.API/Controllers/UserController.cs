using ExpenseAPI.Repository.UserRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace ExpensesProject.Controllers
{
    public class UserController : ApiController
    {
        IUserRepository _userRepositroy;
        public UserController()
        {
 
        }

        public UserController(IUserRepository userRepository)
        {
            _userRepositroy = userRepository;
        }

        // GET api/<controller>
        [HttpGet]
        public async Task<IHttpActionResult> Get()
        {
            return Ok(_userRepositroy.UsersList());
        }
        [HttpPost]
        public async Task<IHttpActionResult> SaveUser(User user)
        {
             _userRepositroy.SaveUser(user);
             return Ok();
        }
        [HttpGet]
        public async Task<IHttpActionResult> EditUser(int userId)
        {
            return Ok(_userRepositroy.EditUser(userId));
        }

        [HttpPut]
        public async Task<IHttpActionResult> UpdateUser(User user)
        {
            _userRepositroy.UpdateUser(user);
            return Ok();
        }

        [HttpDelete]
        public async Task<IHttpActionResult> DeleteUser(int userId)
        {
            _userRepositroy.DeleteUser(userId);
            return Ok();
        }

    }
}