using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI_template.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        // GET: api/<UserController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            string strUserID = string.Empty;

            switch (id)
            {
                case 1:
                    strUserID = "User1";
                    break;

                case 2:
                    strUserID = "User2";
                    break;

                case 3:
                    strUserID = "User3";
                    break;

                case 4:
                    strUserID = "User4";
                    break;

                case 5:
                    strUserID = "User5";
                    break;
            }

            return strUserID;
        }

        // POST api/<UserController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // POST api/<UserController>
        [HttpPost]
        [Route("api/UserReg")]
        public ActionResult<User> Post([FromBody] User data)
        {
            return CreatedAtAction("Post", new User(data.strUserID));
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            string strRetMsg = string.Empty;

            switch (id)
            {
                case 1:
                    strRetMsg = "User1 이 삭제되었습니다.";
                    break;

                case 2:
                    strRetMsg = "User2 이 삭제되었습니다.";
                    break;

                case 3:
                    strRetMsg = "User3 이 삭제되었습니다.";
                    break;

                case 4:
                    strRetMsg = "User4 이 삭제되었습니다.";
                    break;

                case 5:
                    strRetMsg = "User5 이 삭제되었습니다.";
                    break;
            }

            return strRetMsg;
        }
    }
}
