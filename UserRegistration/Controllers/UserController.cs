using Microsoft.AspNetCore.Mvc;
using UserCore.Interface;
using UserModel.User;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UserRegistration.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserPost _userPost;
        private readonly IUserPut _userPut;
        private readonly IUserDelete _userDelete;
        private readonly IUserGet _userGet;

        public UserController
        (
            IUserPost userPost,
            IUserPut userPut,
            IUserDelete userDelete,
            IUserGet userGet
        )
        {
            _userPost = userPost;
            _userPut = userPut; 
            _userDelete = userDelete;
            _userGet = userGet;
        }

        // GET: api/<UserController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public UserRegistrationModel Get(int userId)
        {
            return _userGet.GetSingleUser(userId);
        }

        // POST api/<UserController>
        [HttpPost]
        public void Post([FromBody] UserRegistrationModel userRegistrationModel)
        {
            _userPost.PostUser(userRegistrationModel);
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public void Put(int userId, [FromBody] UserRegistrationModel userRegistrationModel)
        {
            _userPut.PutUser(userId, userRegistrationModel);
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public void Delete(int userId)
        {
            _userDelete.DeleteUser(userId);
        }
    }
}
