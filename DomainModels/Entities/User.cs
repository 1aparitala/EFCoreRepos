using System;
using System.Collections.Generic;
using System.Text;
//using Microsoft.AspNetCore.Identity;

namespace DomainModles
{


    public class User//:IdentityUser<int>
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Contact { get; set; }
        public string Address { get; set; }
    }
}
