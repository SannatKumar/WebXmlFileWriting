using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Create_Xml.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
        public int Age { get; set; }
        public string CountryName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Gmail { get; set; }
        public string Langauge { get; set; }

        public string Gender { get; set; }

    }
    
}
