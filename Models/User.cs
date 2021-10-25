using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Create_Xml.Models
{
    public class UserModel
    {
        public List<User> UserList { get; set; }



        public class User
        {
            public int Id { get; set; }
            public string FirstName { get; set; }

            public string LastName { get; set; }
            //public string FullName
            //{
            //    get
            //    {
            //        return FirstName + " " + LastName;
            //    }
            //}
            public int Age { get; set; }
            public string CountryName { get; set; }
            public string Address { get; set; }
            public string PhoneNumber { get; set; }
            public string Email { get; set; }
            public string Language { get; set; }

            public string Gender { get; set; }
        }
        //public void SaveUserList(User UserList)
        //{
        //    System.Xml.Serialization.XmlSerializer mySerializeFile = new System.Xml.Serialization.XmlSerializer(typeof(User));
        //    var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "//UserDetails.xml";
        //    System.IO.FileStream file = System.IO.File.Create(path);
        //    mySerializeFile.Serialize(file, UserList);
        //}

    }
    
}
