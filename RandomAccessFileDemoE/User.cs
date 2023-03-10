using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomAccessFileDemoE
{
    internal class User
    {
        public string Name { get; set; }
        public string Password { get; set; }    
        public int age { get; set; }   

        public User(string name, string password, int age)
        {
            this.Name = name;
            this.Password = password;
            this.age = age;
        }
    }

}
