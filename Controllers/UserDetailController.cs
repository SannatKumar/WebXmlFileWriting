using Create_Xml.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;

namespace Create_Xml.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserDetailController : ControllerBase
    {
        public List<User> userList = new List<User>();

        [HttpGet]
        public ActionResult<IEnumerable<User>> GetAllUser() => userList;
        
    }
}
