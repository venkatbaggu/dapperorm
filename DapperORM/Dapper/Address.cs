using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DapperORM.Dapper
{
    public class Address
    {
        public int AddressID { get; set; }
        public int UserID { get; set; }
        public string AddressType { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
    }
}