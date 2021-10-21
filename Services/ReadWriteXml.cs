using Create_Xml.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Create_Xml.Services
{
    public class ReadWriteXml
    {

        

        public void SaveUserList(User userList)
        {
            System.Xml.Serialization.XmlSerializer mySerializeFile = new System.Xml.Serialization.XmlSerializer(typeof(User));
            var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "//UserDetails.xml";
            System.IO.FileStream file = System.IO.File.Create(path);
            mySerializeFile.Serialize(file, userList);
        }

    }
}
