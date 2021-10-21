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
    [EnableCors]
    [Route("api/")]
    [ApiController]
    public class UserDetailController : ControllerBase
    {
        public List<UserModel.User> userList = new List<UserModel.User>();

        [HttpGet]
        public ActionResult<IEnumerable<UserModel.User>> GetAllUser()
        {
            return userList;
        }

        [Route("userdetail")]
        [HttpPost]
        public ActionResult<IEnumerable<UserModel.User>> PostContentList(UserModel.User ContentList)
        {
            userList.Add(ContentList
                /*new UserModel.User{
                Id = 1,
                FirstName = "Raj",
                LastName = "Tiwari",
                Age = 32,
                CountryName = "Nepal",
                Address = "Finland",
                PhoneNumber = "0449427068",
                Email = "rajkumarmailuser@gmailc.om",
                Language = "Nepali",
                Gender = "Male",
            }*/
            );
            return userList;

        }
    }
}
