using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DapperORM.Dapper
{
    public class User
    {
        public User()
        {
            this.Address = new List<Address>();
        }

        public int UserID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public List<Address> Address { get; set; }
    }
}