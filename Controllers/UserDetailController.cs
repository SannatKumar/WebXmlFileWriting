using Create_Xml.Models;
using Create_Xml.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using Microsoft.AspNetCore.Cors;

namespace Create_Xml.Controllers
{
    [EnableCors]
    [Route("api/")]
    [ApiController]
    public class UserDetailController : ControllerBase
    {
        public List<UserModel.User> UserList = new List<UserModel.User>();

        [Route("getuserdetail")]
        [HttpGet]
        public ActionResult<IEnumerable<UserModel.User>> GetAllUser()
        {
            return UserList;
        }

        [Route("userdetail")]
        [HttpPost]
        public ActionResult<IEnumerable<UserModel.User>> PostContentList(UserModel.User ContentList)
        {
            UserList.Add(ContentList);
            //UserModel.SaveUserList(UserList);
            System.Xml.Serialization.XmlSerializer mySerializeFile = new System.Xml.Serialization.XmlSerializer(typeof(UserModel.User));
            var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "//UserDetails.xml";
            System.IO.FileStream file = System.IO.File.Create(path);
            mySerializeFile.Serialize(file, ContentList);
            return UserList;

        }
    }
}
